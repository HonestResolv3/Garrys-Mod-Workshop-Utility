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
    public partial class AboutPage : Form
    {
        int pictureBoxValue = 0;
        bool expandedWindow = false;

        public static bool creditsWindowIsOpen = false;

        public AboutPage()
        {
            InitializeComponent();
        }

        string[] Version1Info = {"- Added 6 program functions (Creating, Extracting, Publishing, Updating)", "- Added credits and help functions", "- Added validation checks for many parts of the program", "- Added clean design"};
        string[] Version2Info = {"- Added queue system","- Added way to change task auto-run time", "- Added toggle for resizing program","- Added toggle for automatically deleting addon.json","- Added toggle for automatically clearing text","- Added toggle for command prompt pausing","- Users can now type into the text boxes","- Users can choose where to place the output .gma after creation","- Users can choose how long they want each script to delete for","- User input is now saved for all parts of the program","- All required .dll's are embeeded into the.exe now","- Folder opening dialog is improved","- Icon preview resets if input is cleared","- Addon.json supports multiple wildcards with proper parsing","- Improved validation checking","- Credits window is restricted to one at a time","- Bug fixes & General formatting fixes"};
        string[] Version3Info = {"- Added working output console","- Improved design","- Experimental dark mode added","- Improved credits / about page","- Removed command pausing (it was useless when the console came)","- Changing MessageBox notices","- Users can clear the console screen","- Users can no longer run tasks manually if auto-run is enabled","- Users can no longer modify time if manual task run is on","- Credits page now saves choice for image switching","- Changed default program text to something better","- Fixed task running time not changing internally when loading program","- Fixed .exe directories when switching functions","- Fixed auto-run time button disabling if program is re-opened","- Fixed error with parsing icon updates","- Fixed useless error if you entered in nothing for ID, or times", "- Fixed tab indexes and random tab stops","- Fixed .gma's failing to save and extract with Unicode characters","- Fixed remove queue message displays"};
        string[] Version4Info = {"- Added addon lister", "- Improved program design", "- Changelog viewing is more organized", "- Users can no longer run more than one instance of the program at a time", "- Fixed dark mode not affecting queue item text color", "- Fixed list boxes not having horizontal scrolling"};
        string[] Description = { "A program to make publishing to the game Garry's Mod easier", "", "It took 1-1.5 months to fully complete this project with lots of challenges and hassles along the way", "", "Written in C#, Utilizes: File creation and running, Tasks & Queue Creation, External packages", "", "Has 6 functions, a working queue system, and a working console screen for output!", "", "Huge thanks to Ak47toh and Hidden for testing this project!"};

        private void AboutPage_Load(object sender, EventArgs e)
        {
            lstChangelog.Items.Clear();
            foreach (String s in Description)
            {
                lstChangelog.Items.Add(s);
            }
            tmrChangeImage.Start();
            pictureBoxValue++;
            creditsWindowIsOpen = true;
            loadUserInput();
            cboxChangelogs.SelectedIndex = 0;
        }

        private void AboutPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            GarrysModWorkshopUtil.Properties.Settings.Default.CurrentImageNumber = pictureBoxValue;
            GarrysModWorkshopUtil.Properties.Settings.Default.Save();
        }

        private void AboutPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            creditsWindowIsOpen = false;
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            loadChangelog(0);
        }

        private void pboxDefyAvatar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuties aren't they?", "What do you think?");
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DefyTheRush");
        }

        private void btnSteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561198376332678");
        }

        private void btnResetImage_Click(object sender, EventArgs e)
        {
            pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.kouko;
        }

        private void lblCreditsTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm DefyTheRush or Kouko Matsumoto, \"Rush\" or \"Kouko\" as some call me. I create weapons for a Source game, I create programs, I also like anime", "Some info");
        }

        private void lblCreditsTitle2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm DefyTheRush or Kouko Matsumoto, \"Rush\" or \"Kouko\" as some call me. I create weapons for a Source game, I create programs, I also like anime", "Some info");
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            if (expandedWindow == false)
            {
                tmrExpandWindow.Start();
            }
            else
            {
                tmrRetractWindow.Start();
            }
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

        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            switch (pictureBoxValue)
            {
                case 0:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.kouko;
                    pictureBoxValue++;
                    break;
                case 1:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture_start;
                    pictureBoxValue++;
                    break;
                case 2:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture;
                    pictureBoxValue++;
                    break;
                case 3:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture2;
                    pictureBoxValue++;
                    break;
                case 4:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture3;
                    pictureBoxValue++;
                    break;
                case 5:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture4;
                    pictureBoxValue = 0;
                    break;
            }
        }

        private void tmrExpandWindow_Tick(object sender, EventArgs e)
        {
            this.Width += 5;
            if (this.Width == 836)
            {
                tmrExpandWindow.Stop();
                expandedWindow = true;
            }

        }

        private void tmrRetractWindow_Tick(object sender, EventArgs e)
        {
            this.Width -= 5;
            if (this.Width == 571)
            {
                tmrRetractWindow.Stop();
                expandedWindow = false;
            }
        }

        private void cboxChangelogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxChangelogs.SelectedIndex == 0)
            {
                loadChangelog(0);
            }
            else if (cboxChangelogs.SelectedIndex == 1)
            {
                loadChangelog(1);
            }
            else if (cboxChangelogs.SelectedIndex == 2)
            {
                loadChangelog(2);
            }
            else if (cboxChangelogs.SelectedIndex == 3)
            {
                loadChangelog(3);
            }
            else if (cboxChangelogs.SelectedIndex == 4)
            {
                loadChangelog(4);
            }
        }


        private void loadChangelog(int num)
        {
            if (num == 0)
            {
                lstChangelog.Items.Clear();
                foreach (String s in Description)
                {
                    lstChangelog.Items.Add(s);
                }
            }
            else if (num == 1)
            {
                lstChangelog.Items.Clear();
                foreach (String s in Version1Info)
                {
                    lstChangelog.Items.Add(s);
                }
            }
            else if (num == 2)
            {
                lstChangelog.Items.Clear();
                foreach (String s in Version2Info)
                {
                    lstChangelog.Items.Add(s);
                }
            }
            else if (num == 3)
            {
                lstChangelog.Items.Clear();
                foreach (String s in Version3Info)
                {
                    lstChangelog.Items.Add(s);
                }
            }
            else if (num == 4)
            {
                lstChangelog.Items.Clear();
                foreach (String s in Version4Info)
                {
                    lstChangelog.Items.Add(s);
                }
            }
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
