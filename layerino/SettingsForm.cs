using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace layerino
{
    public partial class SettingsForm : MetroForm
    {
        private LayerinoForm mainForm;

        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(LayerinoForm form)
        {
            InitializeComponent();
            mainForm = form;
            SetContents();
        }

        public LayerinoForm MainForm { get => mainForm; set => mainForm = value; }

        private void SetContents()
        {
            topLogoBox.Items.Clear();
            topOverlayBox.Items.Clear();
            foreach (string fn in MainForm.TopLogoFiles.GetFileNames())
            {
                topLogoBox.Items.Add(fn);
            }
            foreach (string fn in MainForm.TopOverlayFiles.GetFileNames())
            {
                topOverlayBox.Items.Add(fn);
            }
            topLogoBox.SelectedIndex = topLogoBox.FindString(MainForm.SelectedTopLogo);
            topOverlayBox.SelectedIndex = topOverlayBox.FindString(MainForm.SelectedTopOverlay);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            mainForm.SelectedTopLogo = topLogoBox.GetItemText(topLogoBox.SelectedItem);
            mainForm.SelectedTopOverlay = topOverlayBox.GetItemText(topOverlayBox.SelectedItem);
            mainForm.SaveConfiguration();
            mainForm.Focus();
            Close();
        }

        private void RescanButton_Click(object sender, EventArgs e)
        {
            mainForm.RefreshDirectories();
            topLogoBox.SelectedIndex = topLogoBox.FindString(MainForm.SelectedTopLogo);
            topOverlayBox.SelectedIndex = topOverlayBox.FindString(MainForm.SelectedTopOverlay);
            topLogoBox.Focus();
            topOverlayBox.Focus();
            rescanButton.Focus();
        }
    }
}
