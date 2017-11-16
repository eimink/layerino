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
        private string selectedTopLogo = "";
        private string selectedTopOverlay = "";

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
            LoadConfiguration();
            SetComboBoxSelected(ref logoBox1, Config.DefaultHomeLogo);
            SetComboBoxSelected(ref logoBox2, Config.DefaultAwayLogo);

            wssv = new WebSocketServer(14329);
            wssv.Log.Level = LogLevel.Fatal;
            wssv.AddWebSocketService<LayerinoWebSocket>("/layerino");
            wssv.Start();
        }

        private void CheckDirectories()
        {
            List<string> directories = new List<String>();
            directories.Add(Config.LogoDirectory);
            directories.Add(Config.BackgroundDirectory);
            directories.Add(Config.TopLogoDirectory);
            directories.Add(Config.TopOverlayDirectory);
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
        }

        private void SetTopOverlayBoxFiles()
        {
            TopOverlayFiles = new FileListing();
            TopOverlayFiles.Add(Config.DefaultTopOverlay, Config.DefaultTopOverlay, false);
            TopOverlayFiles.ParseDirectory(Directory.GetCurrentDirectory() + Config.TopOverlayDirectory);
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
            });

            if (!invertTeams)
            {
                data.TeamLeftName = this.team1Name.Text;
                data.TeamRightName = this.team2Name.Text;
                data.TeamLeftScore = Convert.ToInt32(this.team1Score.Text);
                data.TeamRightScore = Convert.ToInt32(this.team2Score.Text);
                data.TeamLeftLogo = homeTeamLogo;
                data.TeamRightLogo = awayTeamLogo;
            }
            else
            {
                data.TeamLeftName = this.team2Name.Text;
                data.TeamRightName = this.team1Name.Text;
                data.TeamLeftScore = Convert.ToInt32(this.team2Score.Text);
                data.TeamRightScore = Convert.ToInt32(this.team1Score.Text);
                data.TeamLeftLogo = awayTeamLogo;
                data.TeamRightLogo = homeTeamLogo;
            }
            data.HomeTeamName = this.team1Name.Text;
            data.AwayTeamName = this.team2Name.Text;
            data.HomeTeamLogo = homeTeamLogo;
            data.AwayTeamLogo = awayTeamLogo;
            data.TopLogo = GetURIForLayer(GetTopLogoPath());
            data.TopOverlay = GetURIForLayer(GetTopOverlayPath());

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
                TopLogo = SelectedTopLogo,
                TopOverlay = SelectedTopOverlay
            };
            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }

        private void SetDataToUI(ConfigData data)
        {
            team1Name.Text = data.HomeTeamName;
            team2Name.Text = data.AwayTeamName;
            team1Score.Text = data.HomeTeamScore;
            team2Score.Text = data.AwayTeamScore;
            SelectedTopLogo = data.TopLogo;
            SelectedTopOverlay = data.TopOverlay;
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

        private Info GetAwayLogoPath()
        {
            return TeamLogoFiles.GetFilePath(logoBox2.GetItemText(logoBox2.SelectedItem), Config.DefaultAwayLogo);
        }

        private Info GetHomeLogoPath()
        {
            return TeamLogoFiles.GetFilePath(logoBox1.GetItemText(logoBox1.SelectedItem), Config.DefaultHomeLogo);
        }
        
        private Info GetTopLogoPath()
        {
            return TopLogoFiles.GetFilePath(selectedTopLogo, Config.KaupunkiSotaLogo);
        }

        private Info GetTopOverlayPath()
        {
            return TopOverlayFiles.GetFilePath(selectedTopOverlay, Config.DefaultTopOverlay);
        }

        public void RefreshDirectories()
        {
            SetTeamLogoBoxFiles();
            SetTopLogoBoxFiles();
            SetTopOverlayBoxFiles();
            Team1Name_Changed(this, null);
            Team2Name_Changed(this, null);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm(this);
            frm.Show();
        }
    }
}
