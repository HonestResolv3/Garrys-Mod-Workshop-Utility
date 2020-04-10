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
        string[] Version4Info = {"- Added addon lister", "- Added task history function" ,"- Added search and clear addon list features", "- Added ability to use past task info, view old task info, and permanently delete task info", "- Improved program design", "- Changelog viewing is more organized","- Added ability to select a task to run manually", "- Users can now reload the program to clear memory (if it uses too much)", "- Users can no longer run more than one instance of the program at a time", "- Fixed addon.json second tag being able to be any word", "- Fixed some high number addon ID's not working" ,"- Fixed program appearing below the users screen upon start", "- Fixed potential error with ID's that are 9 digits", "- Fixed dark mode not affecting queue item text color", "- Fixed list boxes not having horizontal scrolling", "- Fixed input boxes not taking \"n\" as an answer to prompts", "- Added another credits to the description"};
        string[] Version5Info = {"- Added addon.json user interface", "- Added presets for program parameters", "- Cleaner appearance for main program", "- Changed about page look, adding the people who tested my program and gave the most feedback", "- Added ability to instantly create an addon.json file if needed", "- Addons will load regardless of which task you are intending to run", "- Addon searching buttons won't load until you load the addons now", "- Fixed \"Clear Search\" function erasing your loaded addons and not loading them again", "- Addon searching is no longer case sensitive", "- Spamming \"Clear Search\" won't mess with future search results anymore", "- Fixed removing counts for items from the queue", "- Task history will no longer show items that have incorrect formats (throws exceptions when running)", "- If an exception is thrown when running a task, now the correct task gets removed", "- Resetting image on about page now replays the images in proper order", "- All drop-down lists cannot be edited anymore"};
        string[] Description = { "A program to make publishing to the game Garry's Mod easier", "", "It took 3+ months to get this project to it's current state with lots of challenges and hassles over time", "", "Written in C#, Utilizes: File creation and running, Tasks & Queue Creation, External packages", "", "Has 6 functions, a working queue system, and a working console screen for output!", "", "Huge thanks to Ak47toh, Hidden, and Helios for testing this project!", "", "And best for last, thanks to everyone (and you) for using this program! I really hope you enjoy it!"};

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
            GarrysModWorkshopUtil.Credits.creditsWindowIsOpen = false;
            GarrysModWorkshopUtil.Properties.Settings.Default.Save();
            pboxDefyAvatar.Image = null;
            pboxDefyAvatar = null;
            pboxAk47Avatar.Image = null;
            pboxAk47Avatar = null;
            pboxHeliosAvatar.Image = null;
            pboxHeliosAvatar = null;
            pboxHiddenAvatar.Image = null;
            pboxHiddenAvatar = null;
            GC.Collect();
        }

        private void AboutPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            creditsWindowIsOpen = false;
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            loadChangelog(0);
            cboxChangelogs.SelectedIndex = 0;
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
            pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture5;
            pictureBoxValue = 0;
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
            switch (expandedWindow)
            {
                case true:
                    tmrRetractWindow.Start();
                    break;
                case false:
                    tmrExpandWindow.Start();
                    break;
            }
        }

        private void chkPreventImageSwitch_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkPreventImageSwitch.Checked)
            {
                case true:
                    tmrChangeImage.Stop();
                    GarrysModWorkshopUtil.Properties.Settings.Default.PreventImageSwitching = true;
                    break;
                case false:
                    tmrChangeImage.Start();
                    GarrysModWorkshopUtil.Properties.Settings.Default.PreventImageSwitching = false;
                    break;
            }
        }

        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            switch (pictureBoxValue)
            {
                case 0:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture5;
                    pictureBoxValue++;
                    break;
                case 1:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.kouko;
                    pictureBoxValue++;
                    break;
                case 2:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture_start;
                    pictureBoxValue++;
                    break;
                case 3:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture;
                    pictureBoxValue++;
                    break;
                case 4:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture2;
                    pictureBoxValue++;
                    break;
                case 5:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture3;
                    pictureBoxValue++;
                    break;
                case 6:
                    pboxDefyAvatar.Image = GarrysModWorkshopUtil.Properties.Resources.defypicture4;
                    pictureBoxValue = 0;
                    break;
            }
        }

        private void tmrExpandWindow_Tick(object sender, EventArgs e)
        {
            this.Height += 5;
            if (this.Height == 637)
            {
                tmrExpandWindow.Stop();
                expandedWindow = true;
            }

        }

        private void tmrRetractWindow_Tick(object sender, EventArgs e)
        {
            this.Height -= 5;
            if (this.Height == 362)
            {
                tmrRetractWindow.Stop();
                expandedWindow = false;
            }
        }

        private void cboxChangelogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxChangelogs.SelectedIndex)
            {
                case 0:
                    loadChangelog(0);
                    break;
                case 1:
                    loadChangelog(1);
                    break;
                case 2:
                    loadChangelog(2);
                    break;
                case 3:
                    loadChangelog(3);
                    break;
                case 4:
                    loadChangelog(4);
                    break;
                case 5:
                    loadChangelog(5);
                    break;

            }
        }


        private void loadChangelog(int num)
        {
            switch (num)
            {
                case 0:
                    lstChangelog.Items.Clear();
                    foreach (String s in Description)
                    {
                        lstChangelog.Items.Add(s);
                    }
                    break;
                case 1:
                    lstChangelog.Items.Clear();
                    foreach (String s in Version1Info)
                    {
                        lstChangelog.Items.Add(s);
                    }
                    break;
                case 2:
                    lstChangelog.Items.Clear();
                    foreach (String s in Version2Info)
                    {
                        lstChangelog.Items.Add(s);
                    }
                    break;
                case 3:
                    lstChangelog.Items.Clear();
                    foreach (String s in Version3Info)
                    {
                        lstChangelog.Items.Add(s);
                    }
                    break;
                case 4:
                    lstChangelog.Items.Clear();
                    foreach (String s in Version4Info)
                    {
                        lstChangelog.Items.Add(s);
                    }
                    break;
                case 5:
                    lstChangelog.Items.Clear();
                    foreach (String s in Version5Info)
                    {
                        lstChangelog.Items.Add(s);
                    }
                    break;
            }
        }

        private void loadUserInput()
        {
            switch (GarrysModWorkshopUtil.Properties.Settings.Default.PreventImageSwitching)
            {
                case true:
                    chkPreventImageSwitch.Checked = true;
                    break;
                case false:
                    chkPreventImageSwitch.Checked = false;
                    break;
            }
        }

        public bool getCurrentlyOpenState()
        {
            return creditsWindowIsOpen;
        }

        private void btnHeliosSteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561198054526488");
        }

        private void btnHiddenSteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561198034487277");
        }

        private void btnAk47tohSteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561198217570803");
        }
    }
}

