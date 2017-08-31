namespace layerino
{
    partial class LayerinoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayerinoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.team1Name = new System.Windows.Forms.TextBox();
            this.team2Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.team1Score = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.team2Score = new System.Windows.Forms.TextBox();
            this.team1ScoreInc = new System.Windows.Forms.Button();
            this.team1ScoreDec = new System.Windows.Forms.Button();
            this.team2ScoreDec = new System.Windows.Forms.Button();
            this.team2ScoreInc = new System.Windows.Forms.Button();
            this.toggleTopBar = new System.Windows.Forms.Button();
            this.swapTeams = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // team1Name
            // 
            this.team1Name.Location = new System.Drawing.Point(50, 16);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(298, 20);
            this.team1Name.TabIndex = 1;
            // 
            // team2Name
            // 
            this.team2Name.Location = new System.Drawing.Point(50, 76);
            this.team2Name.Name = "team2Name";
            this.team2Name.Size = new System.Drawing.Size(298, 20);
            this.team2Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score";
            // 
            // team1Score
            // 
            this.team1Score.Location = new System.Drawing.Point(404, 16);
            this.team1Score.Name = "team1Score";
            this.team1Score.Size = new System.Drawing.Size(50, 20);
            this.team1Score.TabIndex = 5;
            this.team1Score.Text = "0";
            this.team1Score.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score";
            // 
            // team2Score
            // 
            this.team2Score.Location = new System.Drawing.Point(404, 76);
            this.team2Score.Name = "team2Score";
            this.team2Score.Size = new System.Drawing.Size(50, 20);
            this.team2Score.TabIndex = 7;
            this.team2Score.Text = "0";
            this.team2Score.WordWrap = false;
            // 
            // team1ScoreInc
            // 
            this.team1ScoreInc.Location = new System.Drawing.Point(477, 13);
            this.team1ScoreInc.Name = "team1ScoreInc";
            this.team1ScoreInc.Size = new System.Drawing.Size(38, 23);
            this.team1ScoreInc.TabIndex = 8;
            this.team1ScoreInc.Text = "+1";
            this.team1ScoreInc.UseVisualStyleBackColor = true;
            this.team1ScoreInc.Click += new System.EventHandler(this.Team1ScoreInc_Click);
            // 
            // team1ScoreDec
            // 
            this.team1ScoreDec.Location = new System.Drawing.Point(521, 13);
            this.team1ScoreDec.Name = "team1ScoreDec";
            this.team1ScoreDec.Size = new System.Drawing.Size(38, 23);
            this.team1ScoreDec.TabIndex = 9;
            this.team1ScoreDec.Text = "-1";
            this.team1ScoreDec.UseVisualStyleBackColor = true;
            this.team1ScoreDec.Click += new System.EventHandler(this.Team1ScoreDec_Click);
            // 
            // team2ScoreDec
            // 
            this.team2ScoreDec.Location = new System.Drawing.Point(521, 74);
            this.team2ScoreDec.Name = "team2ScoreDec";
            this.team2ScoreDec.Size = new System.Drawing.Size(38, 23);
            this.team2ScoreDec.TabIndex = 11;
            this.team2ScoreDec.Text = "-1";
            this.team2ScoreDec.UseVisualStyleBackColor = true;
            this.team2ScoreDec.Click += new System.EventHandler(this.Team2ScoreDec_Click);
            // 
            // team2ScoreInc
            // 
            this.team2ScoreInc.Location = new System.Drawing.Point(477, 74);
            this.team2ScoreInc.Name = "team2ScoreInc";
            this.team2ScoreInc.Size = new System.Drawing.Size(38, 23);
            this.team2ScoreInc.TabIndex = 10;
            this.team2ScoreInc.Text = "+1";
            this.team2ScoreInc.UseVisualStyleBackColor = true;
            this.team2ScoreInc.Click += new System.EventHandler(this.Team2ScoreInc_Click);
            // 
            // toggleTopBar
            // 
            this.toggleTopBar.Location = new System.Drawing.Point(15, 130);
            this.toggleTopBar.Name = "toggleTopBar";
            this.toggleTopBar.Size = new System.Drawing.Size(96, 23);
            this.toggleTopBar.TabIndex = 12;
            this.toggleTopBar.Text = "Show top bar";
            this.toggleTopBar.UseVisualStyleBackColor = true;
            this.toggleTopBar.Click += new System.EventHandler(this.ToggleTopBar_Click);
            // 
            // swapTeams
            // 
            this.swapTeams.Location = new System.Drawing.Point(117, 130);
            this.swapTeams.Name = "swapTeams";
            this.swapTeams.Size = new System.Drawing.Size(96, 23);
            this.swapTeams.TabIndex = 13;
            this.swapTeams.Text = "Swap teams";
            this.swapTeams.UseVisualStyleBackColor = true;
            this.swapTeams.Click += new System.EventHandler(this.SwapTeams_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(463, 130);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(96, 23);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LayerinoForm
            // 
            this.ClientSize = new System.Drawing.Size(576, 168);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.swapTeams);
            this.Controls.Add(this.toggleTopBar);
            this.Controls.Add(this.team2ScoreDec);
            this.Controls.Add(this.team2ScoreInc);
            this.Controls.Add(this.team1ScoreDec);
            this.Controls.Add(this.team1ScoreInc);
            this.Controls.Add(this.team2Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.team1Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.team2Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.team1Name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LayerinoForm";
            this.Text = "eimink\'s layerino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox team1Name;
        private System.Windows.Forms.TextBox team2Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox team1Score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox team2Score;
        private System.Windows.Forms.Button team1ScoreInc;
        private System.Windows.Forms.Button team1ScoreDec;
        private System.Windows.Forms.Button team2ScoreDec;
        private System.Windows.Forms.Button team2ScoreInc;
        private System.Windows.Forms.Button toggleTopBar;
        private System.Windows.Forms.Button swapTeams;
        private System.Windows.Forms.Button refreshButton;
    }
}

