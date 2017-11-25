using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace layerino
{
    public partial class LayerinoForm : MetroForm
    {
        private WebSocketServer wssv;
        private bool invertTeams = false;
        private FileListing teamLogoFiles;
        private FileListing topLogoFiles;
        private FileListing topOverlayFiles;
        private string selectedTopLogo = Config.KaupunkiSotaLogo;
        private string selectedTopOverlay = Config.DefaultTopOverlay;

        private GlobalHotkey[] ghks;

        public string SelectedTopOverlay { get => selectedTopOverlay; set => selectedTopOverlay = value; }
        public string SelectedTopLogo { get => selectedTopLogo; set => selectedTopLogo = value; }
        public FileListing TopOverlayFiles { get => topOverlayFiles; set => topOverlayFiles = value; }
        public FileListing TopLogoFiles { get => topLogoFiles; set => topLogoFiles = value; }
        public FileListing TeamLogoFiles { get => teamLogoFiles; set => teamLogoFiles = value; }

        public LayerinoForm()
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            
            InitializeComponent();
            CheckDirectories();
            ghks = new GlobalHotkey[7];
            ghks[0] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D4, this);
            ghks[1] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D5, this);
            ghks[2] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D6, this);
            ghks[3] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D7, this);
            ghks[4] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D8, this);
            ghks[5] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D9, this);
            ghks[6] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D0, this);

            SetTeamLogoBoxFiles();
            SetTopLogoBoxFiles();
            SetTopOverlayBoxFiles();
            SetComboBoxSelected(ref logoBox1, Config.DefaultHomeLogo);
            SetComboBoxSelected(ref logoBox2, Config.DefaultAwayLogo);
            SetComboBoxSelected(ref topOverlayBox, Config.DefaultTopOverlay);
            SetComboBoxSelected(ref topLogoBox, Config.KaupunkiSotaLogo);
            LoadConfiguration();
            
            wssv = new WebSocketServer(14329);
            wssv.Log.Level = LogLevel.Fatal;
            wssv.AddWebSocketService<LayerinoWebSocket>("/layerino");
            wssv.Start();
        }

        private void CheckDirectories()
        {
            List<string> directories = new List<String>
            {
                Config.LogoDirectory,
                Config.BackgroundDirectory,
                Config.TopLogoDirectory,
                Config.TopOverlayDirectory
            };
            foreach (string dir in directories)
            {
                if (!Directory.Exists(Directory.GetCurrentDirectory() + dir))
                {
                    string path = Directory.GetCurrentDirectory() + dir;
                    Directory.CreateDirectory(path);
                }
            }
        }

        private void SetTeamLogoBoxFiles()
        {
            TeamLogoFiles = new FileListing();
            TeamLogoFiles.Add(Config.DefaultHomeLogo, Config.DefaultHomeLogo, false);
            TeamLogoFiles.Add(Config.DefaultAwayLogo, Config.DefaultAwayLogo, false);
            TeamLogoFiles.ParseDirectory(Directory.GetCurrentDirectory() + Config.LogoDirectory);
            logoBox1.Items.Clear();
            logoBox2.Items.Clear();
            foreach (string fn in TeamLogoFiles.GetFileNames())
            {
                logoBox1.Items.Add(fn);
                logoBox2.Items.Add(fn);
            }
        }

        private void SetTopLogoBoxFiles()
        {
            TopLogoFiles = new FileListing();
            TopLogoFiles.Add(Config.KaupunkiSotaLogo, Config.KaupunkiSotaLogo, false);
            TopLogoFiles.ParseDirectory(Directory.GetCurrentDirectory() + Config.TopLogoDirectory);
            topLogoBox.Items.Clear();
            foreach (string fn in TopLogoFiles.GetFileNames())
            {
                topLogoBox.Items.Add(fn);
            }
        }

        private void SetTopOverlayBoxFiles()
        {
            TopOverlayFiles = new FileListing();
            TopOverlayFiles.Add(Config.DefaultTopOverlay, Config.DefaultTopOverlay, false);
            TopOverlayFiles.ParseDirectory(Directory.GetCurrentDirectory() + Config.TopOverlayDirectory);
            topOverlayBox.Items.Clear();
            foreach (string fn in TopOverlayFiles.GetFileNames())
            {
                topOverlayBox.Items.Add(fn);
            }
        }

        private void SetComboBoxSelected(ref MetroComboBox comboBox, string selected)
        {
            comboBox.SelectedIndex = comboBox.FindString(selected);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            wssv.Stop();
        }

        private int GetHotKeyHash(int lpInt)
        {
            int key = (lpInt >> 16) & 0xFFFF;
            int modifier = lpInt & 0xFFFF;
            return modifier ^ key ^ this.Handle.ToInt32();
        }

        private void HandleHotkeys(int key)
        {
            int hotkeyIndex = -1;
            try
            {
                hotkeyIndex = Array.FindIndex(ghks, delegate (GlobalHotkey k) { return k.GetHashCode() == key; });
            }
            catch (ArgumentNullException e)
            {
                Debug.Write(e.Message);
            }
            finally
            {
                switch (hotkeyIndex)
                {
                    case 0:
                        Team1ScoreInc_Click(this, null);
                        break;
                    case 1:
                        Team1ScoreDec_Click(this, null);
                        break;
                    case 2:
                        Team2ScoreInc_Click(this, null);
                        break;
                    case 3:
                        Team2ScoreDec_Click(this, null);
                        break;
                    case 4:
                        SwapTeams_Click(this, null);
                        break;
                    case 5:
                        RefreshButton_Click(this, null);
                        break;
                    case 6:
                        ToggleTopBar_Click(this, null);
                        break;
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkeys(GetHotKeyHash((int)m.LParam));
            base.WndProc(ref m);
        }

        public void OnClientConnected()
        {
            SendWebsocketDataRefresh();
        }

        private void LayerinoForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ghks.Length; i++)
            {
                if (ghks[i].Register())
                    Console.WriteLine("Hotkey registered!");
                else
                    Console.WriteLine("Unable to register hotkey!");
            }
        }

        private void LayerinoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < ghks.Length; i++)
            {
                ghks[i].Unregister();
            }
        }

        private string BuildDataForRefresh()
        {
            RefreshData data = new RefreshData();
            string homeTeamLogo = "";
            string awayTeamLogo = "";

            this.Invoke((MethodInvoker)delegate ()
            {
                homeTeamLogo = GetURIForLayer(GetHomeLogoPath());
                awayTeamLogo = GetURIForLayer(GetAwayLogoPath());
                selectedTopLogo = GetURIForLayer(GetTopLogoPath());
                selectedTopOverlay = GetURIForLayer(GetTopOverlayPath());

            });

            if (!invertTeams)
            {
                data.TeamLeftName = team1Name.Text;
                data.TeamRightName = team2Name.Text;
                data.TeamLeftScore = Convert.ToInt32(team1Score.Text);
                data.TeamRightScore = Convert.ToInt32(team2Score.Text);
                data.TeamLeftLogo = homeTeamLogo;
                data.TeamRightLogo = awayTeamLogo;
            }
            else
            {
                data.TeamLeftName = team2Name.Text;
                data.TeamRightName = team1Name.Text;
                data.TeamLeftScore = Convert.ToInt32(team2Score.Text);
                data.TeamRightScore = Convert.ToInt32(team1Score.Text);
                data.TeamLeftLogo = awayTeamLogo;
                data.TeamRightLogo = homeTeamLogo;
            }
            data.HomeTeamName = team1Name.Text;
            data.AwayTeamName = team2Name.Text;
            data.HomeTeamLogo = homeTeamLogo;
            data.AwayTeamLogo = awayTeamLogo;
            data.TopLogo = SelectedTopLogo;
            data.TopOverlay = SelectedTopOverlay;

            // Bracket
            data.Team1Name = bracketTeam1TextBox.Text;
            data.Team2Name = bracketTeam2TextBox.Text;
            data.Team3Name = bracketTeam3TextBox.Text;
            data.Team4Name = bracketTeam4TextBox.Text;
            data.Team5Name = bracketTeam5TextBox.Text;
            data.Team6Name = bracketTeam6TextBox.Text;
            data.Team7Name = bracketTeam7TextBox.Text;
            data.Team8Name = bracketTeam8TextBox.Text;
            data.Semi1Name = semiTeam1TextBox.Text;
            data.Semi2Name = semiTeam2TextBox.Text;
            data.Semi3Name = semiTeam3TextBox.Text;
            data.Semi4Name = semiTeam4TextBox.Text;
            data.Final1Name = finalTeam1TextBox.Text;
            data.Final2Name = finalTeam2TextBox.Text;
            data.Team1Score = Convert.ToInt32(bracketTeam1Score.Text);
            data.Team2Score = Convert.ToInt32(bracketTeam2Score.Text);
            data.Team3Score = Convert.ToInt32(bracketTeam3Score.Text);
            data.Team4Score = Convert.ToInt32(bracketTeam4Score.Text);
            data.Team5Score = Convert.ToInt32(bracketTeam5Score.Text);
            data.Team6Score = Convert.ToInt32(bracketTeam6Score.Text);
            data.Team7Score = Convert.ToInt32(bracketTeam7Score.Text);
            data.Team8Score = Convert.ToInt32(bracketTeam8Score.Text);
            data.Semi1Score = Convert.ToInt32(semiTeam1Score.Text);
            data.Semi2Score = Convert.ToInt32(semiTeam2Score.Text);
            data.Semi3Score = Convert.ToInt32(semiTeam1Score.Text);
            data.Semi4Score = Convert.ToInt32(semiTeam2Score.Text);
            data.Final1Score = Convert.ToInt32(finalTeam1Score.Text);
            data.Final2Score = Convert.ToInt32(finalTeam2Score.Text);



            return JsonConvert.SerializeObject(data,Formatting.Indented);
        }

        private string BuildDataForConfig()
        {
            ConfigData data = new ConfigData
            {
                HomeTeamName = this.team1Name.Text,
                AwayTeamName = this.team2Name.Text,
                HomeTeamScore = this.team1Score.Text,
                AwayTeamScore = this.team2Score.Text,
                TopLogo = topLogoBox.GetItemText(topLogoBox.SelectedItem),
                TopOverlay = topOverlayBox.GetItemText(topOverlayBox.SelectedItem)
            };
            data.Team1Name = bracketTeam1TextBox.Text;
            data.Team2Name = bracketTeam2TextBox.Text;
            data.Team3Name = bracketTeam3TextBox.Text;
            data.Team4Name = bracketTeam4TextBox.Text;
            data.Team5Name = bracketTeam5TextBox.Text;
            data.Team6Name = bracketTeam6TextBox.Text;
            data.Team7Name = bracketTeam7TextBox.Text;
            data.Team8Name = bracketTeam8TextBox.Text;
            data.Semi1Name = semiTeam1TextBox.Text;
            data.Semi2Name = semiTeam2TextBox.Text;
            data.Semi3Name = semiTeam3TextBox.Text;
            data.Semi4Name = semiTeam4TextBox.Text;
            data.Final1Name = finalTeam1TextBox.Text;
            data.Final2Name = finalTeam2TextBox.Text;
            data.Team1Score = Convert.ToInt32(bracketTeam1Score.Text);
            data.Team2Score = Convert.ToInt32(bracketTeam2Score.Text);
            data.Team3Score = Convert.ToInt32(bracketTeam3Score.Text);
            data.Team4Score = Convert.ToInt32(bracketTeam4Score.Text);
            data.Team5Score = Convert.ToInt32(bracketTeam5Score.Text);
            data.Team6Score = Convert.ToInt32(bracketTeam6Score.Text);
            data.Team7Score = Convert.ToInt32(bracketTeam7Score.Text);
            data.Team8Score = Convert.ToInt32(bracketTeam8Score.Text);
            data.Semi1Score = Convert.ToInt32(semiTeam1Score.Text);
            data.Semi2Score = Convert.ToInt32(semiTeam2Score.Text);
            data.Semi3Score = Convert.ToInt32(semiTeam3Score.Text);
            data.Semi4Score = Convert.ToInt32(semiTeam4Score.Text);
            data.Final1Score = Convert.ToInt32(finalTeam1Score.Text);
            data.Final2Score = Convert.ToInt32(finalTeam2Score.Text);
            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }

        private void SetDataToUI(ConfigData data)
        {
            team1Name.Text = data.HomeTeamName;
            team2Name.Text = data.AwayTeamName;
            team1Score.Text = data.HomeTeamScore;
            team2Score.Text = data.AwayTeamScore;
            topLogoBox.SelectedIndex = topLogoBox.FindString(data.TopLogo);
            topOverlayBox.SelectedIndex = topOverlayBox.FindString(data.TopOverlay);
            bracketTeam1TextBox.Text = data.Team1Name;
            bracketTeam2TextBox.Text = data.Team2Name;
            bracketTeam3TextBox.Text = data.Team3Name;
            bracketTeam4TextBox.Text = data.Team4Name;
            bracketTeam5TextBox.Text = data.Team5Name;
            bracketTeam6TextBox.Text = data.Team6Name;
            bracketTeam7TextBox.Text = data.Team7Name;
            bracketTeam8TextBox.Text = data.Team8Name;
            semiTeam1TextBox.Text = data.Semi1Name;
            semiTeam2TextBox.Text = data.Semi2Name;
            semiTeam3TextBox.Text = data.Semi3Name;
            semiTeam4TextBox.Text = data.Semi4Name;
            finalTeam1TextBox.Text = data.Final1Name;
            finalTeam2TextBox.Text = data.Final2Name;
            bracketTeam1Score.Text = Convert.ToString(data.Team1Score);
            bracketTeam2Score.Text = Convert.ToString(data.Team2Score);
            bracketTeam3Score.Text = Convert.ToString(data.Team3Score);
            bracketTeam4Score.Text = Convert.ToString(data.Team4Score);
            bracketTeam5Score.Text = Convert.ToString(data.Team5Score);
            bracketTeam6Score.Text = Convert.ToString(data.Team6Score);
            bracketTeam7Score.Text = Convert.ToString(data.Team7Score);
            bracketTeam8Score.Text = Convert.ToString(data.Team8Score);
            semiTeam1Score.Text = Convert.ToString(data.Semi1Score);
            semiTeam2Score.Text = Convert.ToString(data.Semi2Score);
            semiTeam3Score.Text = Convert.ToString(data.Semi3Score);
            semiTeam4Score.Text = Convert.ToString(data.Semi4Score);
            finalTeam1Score.Text = Convert.ToString(data.Final1Score);
            finalTeam2Score.Text = Convert.ToString(data.Final2Score);
        }

        public void SaveConfiguration()
        {
            string conf = BuildDataForConfig();
            TextWriter writer = null;
            try
            {
                writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\config.json", false);
                writer.Write(conf);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public void LoadConfiguration()
        {
            string filePath = Directory.GetCurrentDirectory() + @"\config.json";
            if (File.Exists(filePath))
            {
                TextReader reader = null;
                try
                {
                    reader = new StreamReader(filePath);
                    var fileContents = reader.ReadToEnd();
                    SetDataToUI(JsonConvert.DeserializeObject<ConfigData>(fileContents));
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            }
        }

        private void SendWebsocketDataRefresh()
        {
            wssv.WebSocketServices.Broadcast(BuildDataForRefresh());
        }

        private void ToggleTopBar_Click(object sender, EventArgs e)
        {
            if (this.toggleTopBar.Text.Contains("Show"))
            {
                this.toggleTopBar.Text = "Hide top bar";
                wssv.WebSocketServices.Broadcast("MainFadeIn");
            }
            else
            {
                this.toggleTopBar.Text = "Show top bar";
                wssv.WebSocketServices.Broadcast("MainFadeOut");
            }
        }

        private void SwapTeams_Click(object sender, EventArgs e)
        {
            invertTeams = !invertTeams;
            SendWebsocketDataRefresh();
        }

        private void Team1ScoreInc_Click(object sender, EventArgs e)
        {
            this.team1Score.Text = Convert.ToString(Convert.ToInt32(this.team1Score.Text) + 1);
            SendWebsocketDataRefresh();
        }

        private void Team1ScoreDec_Click(object sender, EventArgs e)
        {
            this.team1Score.Text = Convert.ToString(Convert.ToInt32(this.team1Score.Text) - 1);
            SendWebsocketDataRefresh();
        }

        private void Team2ScoreInc_Click(object sender, EventArgs e)
        {
            this.team2Score.Text = Convert.ToString(Convert.ToInt32(this.team2Score.Text) + 1);
            SendWebsocketDataRefresh();
        }

        private void Team2ScoreDec_Click(object sender, EventArgs e)
        {
            this.team2Score.Text = Convert.ToString(Convert.ToInt32(this.team2Score.Text) - 1);
            SendWebsocketDataRefresh();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SendWebsocketDataRefresh();
        }

        private void Team1Name_Changed(object sender, EventArgs e)
        {
            string text = this.team1Name.Text.ToLowerInvariant();
            if (!logoBox1.Items.Contains(text))
                text = Config.DefaultHomeLogo;
            logoBox1.SelectedIndex = logoBox1.FindString(text);
            logoBox1.Focus();
        }

        private void Team2Name_Changed(object sender, EventArgs e)
        {
            string text = this.team2Name.Text.ToLowerInvariant();
            if (!logoBox2.Items.Contains(text))
                text = Config.DefaultAwayLogo;
            logoBox2.SelectedIndex = logoBox2.FindString(text);
            logoBox2.Focus();
        }

        private void Team1Logo_Changed(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = GetImage(GetHomeLogoPath());
            pictureBox1.Update();
            pictureBox1.Refresh();
        }

        private void Team2Logo_Changed(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
                pictureBox2.Image.Dispose();
            pictureBox2.Image = GetImage(GetAwayLogoPath());
            pictureBox2.Update();
            pictureBox2.Refresh();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
        }

        private void RefreshLogos_Click(object sender, EventArgs e)
        {
            SetTeamLogoBoxFiles();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            ExitImage.Image = (Image)((Image)Properties.Resources.ResourceManager.GetObject("ruksi")).Clone();
        }

        private void Exit_MouseExit(object sender, EventArgs e)
        {
            ExitImage.Image = (Image)((Image)Properties.Resources.ResourceManager.GetObject("ruksi_transp")).Clone();
        }

        private Image GetImage(Info info)
        {
            if (info.isFile)
                return (Image)Image.FromFile(info.path).Clone();
            else
                return (Image)((Image)Properties.Resources.ResourceManager.GetObject(info.path)).Clone();
        }

        private string GetURIForLayer(Info info)
        {
            if (info.isFile)
                return new Uri(info.path).AbsoluteUri;
            else
                return @"images/" + info.path + @".png";
        }

        private Info GetAwayLogoPath() => TeamLogoFiles.GetFilePath(logoBox2.GetItemText(logoBox2.SelectedItem), Config.DefaultAwayLogo);

        private Info GetHomeLogoPath() => TeamLogoFiles.GetFilePath(logoBox1.GetItemText(logoBox1.SelectedItem), Config.DefaultHomeLogo);

        private Info GetTopLogoPath() => TopLogoFiles.GetFilePath(topLogoBox.GetItemText(topLogoBox.SelectedItem), Config.KaupunkiSotaLogo);

        private Info GetTopOverlayPath() => TopOverlayFiles.GetFilePath(topOverlayBox.GetItemText(topOverlayBox.SelectedItem), Config.DefaultTopOverlay);

        public void RefreshDirectories()
        {
            SetTeamLogoBoxFiles();
            SetTopLogoBoxFiles();
            SetTopOverlayBoxFiles();
            Team1Name_Changed(this, null);
            Team2Name_Changed(this, null);
        }

        private void RescanButton_Click(object sender, EventArgs e)
        {
            string topLogo = topLogoBox.GetItemText(topLogoBox.SelectedItem);
            string topOverlay = topOverlayBox.GetItemText(topOverlayBox.SelectedItem);
            RefreshDirectories();
            topLogoBox.SelectedIndex = topLogoBox.FindString(topLogo);
            topOverlayBox.SelectedIndex = topOverlayBox.FindString(topOverlay);
            topLogoBox.Focus();
            topOverlayBox.Focus();
            rescanButton.Focus();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            RefreshButton_Click(sender, e);
        }
    }
}
