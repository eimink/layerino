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

namespace layerino
{
    public partial class LayerinoForm : Form
    {
        private WebSocketServer wssv;
        private bool invertTeams = false;

        private GlobalHotkey[] ghks;

        public LayerinoForm()
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            InitializeComponent();
            ghks = new GlobalHotkey[7];
            ghks[0] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D4, this);
            ghks[1] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D5, this);
            ghks[2] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D6, this);
            ghks[3] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D7, this);
            ghks[4] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D8, this);
            ghks[5] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D9, this);
            ghks[6] = new GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D0, this);
            wssv = new WebSocketServer(14329);
            wssv.Log.Level = LogLevel.Fatal;
            wssv.AddWebSocketService<LayerinoWebSocket>("/layerino");
            wssv.Start();
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
            if (!invertTeams)
            {
                data.TeamLeftName = this.team1Name.Text;
                data.TeamRightName = this.team2Name.Text;
                data.TeamLeftScore = Convert.ToInt32(this.team1Score.Text);
                data.TeamRightScore = Convert.ToInt32(this.team2Score.Text);
            }
            else
            {
                data.TeamLeftName = this.team2Name.Text;
                data.TeamRightName = this.team1Name.Text;
                data.TeamLeftScore = Convert.ToInt32(this.team2Score.Text);
                data.TeamRightScore = Convert.ToInt32(this.team1Score.Text);
            }
            
            return JsonConvert.SerializeObject(data,Formatting.Indented);
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
    }
}
