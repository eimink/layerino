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

namespace layerino
{
    public partial class LayerinoForm : Form
    {
        private WebSocketServer wssv;
        private bool invertTeams = false; 

        public LayerinoForm()
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            InitializeComponent();
            wssv = new WebSocketServer(14329);
            wssv.Log.Level = LogLevel.Fatal;
            wssv.AddWebSocketService<LayerinoWebSocket>("/layerino");
            wssv.Start();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            wssv.Stop();
        }

        public void OnClientConnected()
        {
            SendWebsocketDataRefresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
