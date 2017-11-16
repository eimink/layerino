namespace layerino
{
    partial class SettingsForm
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
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.topOverlayBox = new MetroFramework.Controls.MetroComboBox();
            this.topLogoBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.rescanButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(186, 202);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.Style = MetroFramework.MetroColorStyle.Black;
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Settings";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Top Overlay";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.topLogoBox);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.topOverlayBox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(-7, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // topOverlayBox
            // 
            this.topOverlayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topOverlayBox.FormattingEnabled = true;
            this.topOverlayBox.ItemHeight = 23;
            this.topOverlayBox.Location = new System.Drawing.Point(30, 39);
            this.topOverlayBox.MaxDropDownItems = 64;
            this.topOverlayBox.Name = "topOverlayBox";
            this.topOverlayBox.Size = new System.Drawing.Size(238, 29);
            this.topOverlayBox.Style = MetroFramework.MetroColorStyle.Black;
            this.topOverlayBox.TabIndex = 3;
            this.topOverlayBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // topLogoBox
            // 
            this.topLogoBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topLogoBox.FormattingEnabled = true;
            this.topLogoBox.ItemHeight = 23;
            this.topLogoBox.Location = new System.Drawing.Point(30, 104);
            this.topLogoBox.MaxDropDownItems = 64;
            this.topLogoBox.Name = "topLogoBox";
            this.topLogoBox.Size = new System.Drawing.Size(238, 29);
            this.topLogoBox.Style = MetroFramework.MetroColorStyle.Black;
            this.topLogoBox.TabIndex = 5;
            this.topLogoBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Top Logo";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // rescanButton
            // 
            this.rescanButton.Location = new System.Drawing.Point(23, 202);
            this.rescanButton.Name = "rescanButton";
            this.rescanButton.Size = new System.Drawing.Size(75, 23);
            this.rescanButton.Style = MetroFramework.MetroColorStyle.Black;
            this.rescanButton.TabIndex = 4;
            this.rescanButton.Text = "Rescan";
            this.rescanButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rescanButton.Click += new System.EventHandler(this.RescanButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.ControlBox = false;
            this.Controls.Add(this.rescanButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.closeButton);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox topLogoBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox topOverlayBox;
        private MetroFramework.Controls.MetroButton rescanButton;
    }
}