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
            this.label2 = new System.Windows.Forms.Label();
            this.team2Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.team1Score = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.team2Score = new System.Windows.Forms.TextBox();
            this.team1ScoreInc = new System.Windows.Forms.Button();
            this.team1ScoreDec = new System.Windows.Forms.Button();
            this.team2ScoreInc = new System.Windows.Forms.Button();
            this.team2ScoreDec = new System.Windows.Forms.Button();
            this.toggleTopBar = new System.Windows.Forms.Button();
            this.swapTeams = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.logoBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.logoBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // team1Name
            // 
            this.team1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team1Name.ForeColor = System.Drawing.SystemColors.Control;
            this.team1Name.Location = new System.Drawing.Point(51, 27);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(298, 20);
            this.team1Name.TabIndex = 1;
            this.team1Name.TextChanged += new System.EventHandler(this.Team1Name_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
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
            this.label4.Location = new System.Drawing.Point(368, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score";
            // 
            // team1Score
            // 
            this.team1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team1Score.ForeColor = System.Drawing.SystemColors.Control;
            this.team1Score.Location = new System.Drawing.Point(405, 27);
            this.team1Score.Name = "team1Score";
            this.team1Score.Size = new System.Drawing.Size(50, 20);
            this.team1Score.TabIndex = 5;
            this.team1Score.Text = "0";
            this.team1Score.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score";
            // 
            // team2Score
            // 
            this.team2Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team2Score.ForeColor = System.Drawing.SystemColors.Control;
            this.team2Score.Location = new System.Drawing.Point(405, 28);
            this.team2Score.Name = "team2Score";
            this.team2Score.Size = new System.Drawing.Size(50, 20);
            this.team2Score.TabIndex = 7;
            this.team2Score.Text = "0";
            this.team2Score.WordWrap = false;
            // 
            // team1ScoreInc
            // 
            this.team1ScoreInc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team1ScoreInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.team1ScoreInc.Location = new System.Drawing.Point(371, 68);
            this.team1ScoreInc.Name = "team1ScoreInc";
            this.team1ScoreInc.Size = new System.Drawing.Size(38, 23);
            this.team1ScoreInc.TabIndex = 8;
            this.team1ScoreInc.Text = "+1";
            this.team1ScoreInc.UseVisualStyleBackColor = false;
            this.team1ScoreInc.Click += new System.EventHandler(this.Team1ScoreInc_Click);
            // 
            // team1ScoreDec
            // 
            this.team1ScoreDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team1ScoreDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.team1ScoreDec.Location = new System.Drawing.Point(415, 68);
            this.team1ScoreDec.Name = "team1ScoreDec";
            this.team1ScoreDec.Size = new System.Drawing.Size(38, 23);
            this.team1ScoreDec.TabIndex = 9;
            this.team1ScoreDec.Text = "-1";
            this.team1ScoreDec.UseVisualStyleBackColor = false;
            this.team1ScoreDec.Click += new System.EventHandler(this.Team1ScoreDec_Click);
            // 
            // team2ScoreInc
            // 
            this.team2ScoreInc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team2ScoreInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.team2ScoreInc.Location = new System.Drawing.Point(371, 70);
            this.team2ScoreInc.Name = "team2ScoreInc";
            this.team2ScoreInc.Size = new System.Drawing.Size(38, 23);
            this.team2ScoreInc.TabIndex = 10;
            this.team2ScoreInc.Text = "+1";
            this.team2ScoreInc.UseVisualStyleBackColor = false;
            this.team2ScoreInc.Click += new System.EventHandler(this.Team2ScoreInc_Click);
            // 
            // team2ScoreDec
            // 
            this.team2ScoreDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.team2ScoreDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.team2ScoreDec.Location = new System.Drawing.Point(415, 70);
            this.team2ScoreDec.Name = "team2ScoreDec";
            this.team2ScoreDec.Size = new System.Drawing.Size(38, 23);
            this.team2ScoreDec.TabIndex = 11;
            this.team2ScoreDec.Text = "-1";
            this.team2ScoreDec.UseVisualStyleBackColor = false;
            this.team2ScoreDec.Click += new System.EventHandler(this.Team2ScoreDec_Click);
            // 
            // toggleTopBar
            // 
            this.toggleTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.toggleTopBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleTopBar.Location = new System.Drawing.Point(12, 275);
            this.toggleTopBar.Name = "toggleTopBar";
            this.toggleTopBar.Size = new System.Drawing.Size(96, 23);
            this.toggleTopBar.TabIndex = 12;
            this.toggleTopBar.Text = "Show top bar";
            this.toggleTopBar.UseVisualStyleBackColor = false;
            this.toggleTopBar.Click += new System.EventHandler(this.ToggleTopBar_Click);
            // 
            // swapTeams
            // 
            this.swapTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.swapTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swapTeams.Location = new System.Drawing.Point(114, 275);
            this.swapTeams.Name = "swapTeams";
            this.swapTeams.Size = new System.Drawing.Size(96, 23);
            this.swapTeams.TabIndex = 13;
            this.swapTeams.Text = "Swap teams";
            this.swapTeams.UseVisualStyleBackColor = false;
            this.swapTeams.Click += new System.EventHandler(this.SwapTeams_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(468, 275);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(96, 23);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Logo";
            // 
            // logoBox1
            // 
            this.logoBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.logoBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.logoBox1.FormattingEnabled = true;
            this.logoBox1.Location = new System.Drawing.Point(51, 70);
            this.logoBox1.Name = "logoBox1";
            this.logoBox1.Size = new System.Drawing.Size(298, 21);
            this.logoBox1.TabIndex = 17;
            this.logoBox1.SelectedIndexChanged += new System.EventHandler(this.Team1Logo_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Logo";
            // 
            // logoBox2
            // 
            this.logoBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.logoBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.logoBox2.FormattingEnabled = true;
            this.logoBox2.Location = new System.Drawing.Point(51, 72);
            this.logoBox2.Name = "logoBox2";
            this.logoBox2.Size = new System.Drawing.Size(298, 21);
            this.logoBox2.TabIndex = 19;
            this.logoBox2.SelectedIndexChanged += new System.EventHandler(this.Team2Logo_Changed);
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(468, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.logoBox1);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.logoBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.team2Name);
            this.groupBox2.Controls.Add(this.label2);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("BigNoodleToo", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "eimink\'s layerino";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(550, 10);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(22, 22);
            this.exitButton.TabIndex = 26;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseMnemonic = false;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LayerinoForm
            // 
            this.ClientSize = new System.Drawing.Size(576, 311);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.swapTeams);
            this.Controls.Add(this.toggleTopBar);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox team1Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox team2Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox team1Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox team2Score;
        private System.Windows.Forms.Button team1ScoreInc;
        private System.Windows.Forms.Button team1ScoreDec;
        private System.Windows.Forms.Button team2ScoreInc;
        private System.Windows.Forms.Button team2ScoreDec;
        private System.Windows.Forms.Button toggleTopBar;
        private System.Windows.Forms.Button swapTeams;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox logoBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox logoBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exitButton;
    }
}

