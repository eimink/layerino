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
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.team1Name = new MetroFramework.Controls.MetroTextBox();
            this.team2Name = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.team1Score = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.team2Score = new MetroFramework.Controls.MetroTextBox();
            this.team1ScoreInc = new MetroFramework.Controls.MetroButton();
            this.team1ScoreDec = new MetroFramework.Controls.MetroButton();
            this.team2ScoreInc = new MetroFramework.Controls.MetroButton();
            this.team2ScoreDec = new MetroFramework.Controls.MetroButton();
            this.toggleTopBar = new MetroFramework.Controls.MetroButton();
            this.swapTeams = new MetroFramework.Controls.MetroButton();
            this.refreshButton = new MetroFramework.Controls.MetroButton();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logoBox1 = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.logoBox2 = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitImage = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // team1Name
            // 
            this.team1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team1Name.ForeColor = System.Drawing.SystemColors.Control;
            this.team1Name.Location = new System.Drawing.Point(50, 28);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(299, 23);
            this.team1Name.TabIndex = 1;
            this.team1Name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.team1Name.TextChanged += new System.EventHandler(this.Team1Name_Changed);
            // 
            // team2Name
            // 
            this.team2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team2Name.ForeColor = System.Drawing.SystemColors.Control;
            this.team2Name.Location = new System.Drawing.Point(51, 28);
            this.team2Name.Name = "team2Name";
            this.team2Name.Size = new System.Drawing.Size(298, 20);
            this.team2Name.TabIndex = 3;
            this.team2Name.TextChanged += new System.EventHandler(this.Team2Name_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score";
            this.label4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // team1Score
            // 
            this.team1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team1Score.ForeColor = System.Drawing.SystemColors.Control;
            this.team1Score.Location = new System.Drawing.Point(415, 27);
            this.team1Score.Name = "team1Score";
            this.team1Score.Size = new System.Drawing.Size(38, 23);
            this.team1Score.TabIndex = 5;
            this.team1Score.Text = "0";
            this.team1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.team1Score.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score";
            this.label3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // team2Score
            // 
            this.team2Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team2Score.ForeColor = System.Drawing.SystemColors.Control;
            this.team2Score.Location = new System.Drawing.Point(415, 28);
            this.team2Score.Name = "team2Score";
            this.team2Score.Size = new System.Drawing.Size(38, 23);
            this.team2Score.TabIndex = 7;
            this.team2Score.Text = "0";
            this.team2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.team2Score.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // team1ScoreInc
            // 
            this.team1ScoreInc.Location = new System.Drawing.Point(371, 68);
            this.team1ScoreInc.Name = "team1ScoreInc";
            this.team1ScoreInc.Size = new System.Drawing.Size(38, 29);
            this.team1ScoreInc.TabIndex = 8;
            this.team1ScoreInc.Text = "+1";
            this.team1ScoreInc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.team1ScoreInc.Click += new System.EventHandler(this.Team1ScoreInc_Click);
            // 
            // team1ScoreDec
            // 
            this.team1ScoreDec.Location = new System.Drawing.Point(415, 68);
            this.team1ScoreDec.Name = "team1ScoreDec";
            this.team1ScoreDec.Size = new System.Drawing.Size(38, 29);
            this.team1ScoreDec.TabIndex = 9;
            this.team1ScoreDec.Text = "-1";
            this.team1ScoreDec.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.team1ScoreDec.Click += new System.EventHandler(this.Team1ScoreDec_Click);
            // 
            // team2ScoreInc
            // 
            this.team2ScoreInc.Location = new System.Drawing.Point(371, 70);
            this.team2ScoreInc.Name = "team2ScoreInc";
            this.team2ScoreInc.Size = new System.Drawing.Size(38, 29);
            this.team2ScoreInc.TabIndex = 10;
            this.team2ScoreInc.Text = "+1";
            this.team2ScoreInc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.team2ScoreInc.Click += new System.EventHandler(this.Team2ScoreInc_Click);
            // 
            // team2ScoreDec
            // 
            this.team2ScoreDec.Location = new System.Drawing.Point(415, 70);
            this.team2ScoreDec.Name = "team2ScoreDec";
            this.team2ScoreDec.Size = new System.Drawing.Size(38, 29);
            this.team2ScoreDec.TabIndex = 11;
            this.team2ScoreDec.Text = "-1";
            this.team2ScoreDec.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.team2ScoreDec.Click += new System.EventHandler(this.Team2ScoreDec_Click);
            // 
            // toggleTopBar
            // 
            this.toggleTopBar.Location = new System.Drawing.Point(12, 275);
            this.toggleTopBar.Name = "toggleTopBar";
            this.toggleTopBar.Size = new System.Drawing.Size(96, 23);
            this.toggleTopBar.TabIndex = 12;
            this.toggleTopBar.Text = "Show top bar";
            this.toggleTopBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleTopBar.Click += new System.EventHandler(this.ToggleTopBar_Click);
            // 
            // swapTeams
            // 
            this.swapTeams.Location = new System.Drawing.Point(114, 275);
            this.swapTeams.Name = "swapTeams";
            this.swapTeams.Size = new System.Drawing.Size(96, 23);
            this.swapTeams.TabIndex = 1;
            this.swapTeams.Text = "Swap teams";
            this.swapTeams.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.swapTeams.Click += new System.EventHandler(this.SwapTeams_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(468, 275);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(96, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Logo";
            this.label5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logoBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.team1ScoreDec);
            this.groupBox1.Controls.Add(this.team1ScoreInc);
            this.groupBox1.Controls.Add(this.team1Score);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.team1Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(-1, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 114);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home Team";
            // 
            // logoBox1
            // 
            this.logoBox1.FormattingEnabled = true;
            this.logoBox1.ItemHeight = 23;
            this.logoBox1.Location = new System.Drawing.Point(50, 68);
            this.logoBox1.Name = "logoBox1";
            this.logoBox1.Size = new System.Drawing.Size(299, 29);
            this.logoBox1.TabIndex = 26;
            this.logoBox1.SelectedIndexChanged += new System.EventHandler(this.Team1Logo_Changed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(468, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroTextBox1);
            this.groupBox2.Controls.Add(this.logoBox2);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.team2Name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.team2Score);
            this.groupBox2.Controls.Add(this.team2ScoreInc);
            this.groupBox2.Controls.Add(this.team2ScoreDec);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(-1, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 115);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Away Team";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Logo";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(50, 28);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(299, 23);
            this.metroTextBox1.TabIndex = 24;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // logoBox2
            // 
            this.logoBox2.FormattingEnabled = true;
            this.logoBox2.ItemHeight = 23;
            this.logoBox2.Location = new System.Drawing.Point(50, 70);
            this.logoBox2.Name = "logoBox2";
            this.logoBox2.Size = new System.Drawing.Size(299, 29);
            this.logoBox2.TabIndex = 23;
            this.logoBox2.SelectedIndexChanged += new System.EventHandler(this.Team2Logo_Changed);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(468, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // ExitImage
            // 
            this.ExitImage.Image = ((System.Drawing.Image)(resources.GetObject("ExitImage.Image")));
            this.ExitImage.Location = new System.Drawing.Point(553, 7);
            this.ExitImage.Name = "ExitImage";
            this.ExitImage.Size = new System.Drawing.Size(24, 24);
            this.ExitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitImage.TabIndex = 28;
            this.ExitImage.TabStop = false;
            this.ExitImage.Click += new System.EventHandler(this.Exit_Click);
            this.ExitImage.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.ExitImage.MouseLeave += new System.EventHandler(this.Exit_MouseExit);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 25);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // LayerinoForm
            // 
            this.ClientSize = new System.Drawing.Size(576, 311);
            this.ControlBox = false;
            this.Controls.Add(this.ExitImage);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.swapTeams);
            this.Controls.Add(this.toggleTopBar);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LayerinoForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "eimink\'s layerino";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LayerinoForm_FormClosing);
            this.Load += new System.EventHandler(this.LayerinoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox team1Name;
        private MetroFramework.Controls.MetroTextBox team2Name;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroTextBox team1Score;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroTextBox team2Score;
        private MetroFramework.Controls.MetroButton team1ScoreInc;
        private MetroFramework.Controls.MetroButton team1ScoreDec;
        private MetroFramework.Controls.MetroButton team2ScoreInc;
        private MetroFramework.Controls.MetroButton team2ScoreDec;
        private MetroFramework.Controls.MetroButton toggleTopBar;
        private MetroFramework.Controls.MetroButton swapTeams;
        private MetroFramework.Controls.MetroButton refreshButton;
        private MetroFramework.Controls.MetroLabel label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroComboBox logoBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox logoBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ExitImage;
    }
}

