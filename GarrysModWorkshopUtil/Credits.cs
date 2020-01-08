using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GarrysModWorkshopUtil
{
    public partial class Credits : Form
    {
        int pictureBoxValue = 0;

        public static bool creditsWindowIsOpen = false;

        public Credits()
        {
            InitializeComponent();
        }

        private void btnSteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561198376332678");
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DefyTheRush");
        }

        private void pboxDefyAvatar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuties aren't they?", "What do you think?");
        }

        private void lblCreditsTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm DefyTheRush, or \"Rush\" as some call me. I create weapons for a Source game, I create programs, I also like anime\n\nHuge thanks to \"Ak47toh\" and \"Hidden\" for testing this program and giving feedback!", "Some info");
        }

        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            switch (pictureBoxValue)
            {
                case 0:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture_start;
                    pictureBoxValue++;
                    break;
                case 1:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture;
                    pictureBoxValue++;
                    break;
                case 2:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture2;
                    pictureBoxValue++;
                    break;
                case 3:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture3;
                    pictureBoxValue++;
                    break;
                case 4:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture4;
                    pictureBoxValue = 0;
                    break;
            }
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            tmrChangeImage.Start();
            pictureBoxValue++;
            creditsWindowIsOpen = true;
            loadUserInput();
        }

        private void chkPreventImageSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPreventImageSwitch.Checked)
            {
                tmrChangeImage.Stop();
                GarrysModWorkshopUtil.Properties.Settings.Default.PreventImageSwitching = true;
            }
            else
            {
                tmrChangeImage.Start();
                GarrysModWorkshopUtil.Properties.Settings.Default.PreventImageSwitching = false;
            }
        }

        private void btnResetImage_Click(object sender, EventArgs e)
        {
            pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture_start;
        }

        private void Credits_FormClosed(object sender, FormClosedEventArgs e)
        {
            creditsWindowIsOpen = false;
        }

        private void Credits_FormClosing(object sender, FormClosingEventArgs e)
        {
            GarrysModWorkshopUtil.Properties.Settings.Default.Save();
        }

        private void loadUserInput()
        {
            if (GarrysModWorkshopUtil.Properties.Settings.Default.PreventImageSwitching == true)
            {
                chkPreventImageSwitch.Checked = true;
            }

            else
            {
                chkPreventImageSwitch.Checked = false;
            }
        }
    }
}
