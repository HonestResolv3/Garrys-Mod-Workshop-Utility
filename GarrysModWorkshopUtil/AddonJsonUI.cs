using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GarrysModWorkshopUtil
{
    public partial class AddonJsonUI : Form
    {
        public GarrysModWorkshopUtility.frmGarrysModWorkshopUtility sendBackToMain;
        String[] addonTags = { "fun", "roleplay", "scenic", "movie", "realism", "cartoon", "water", "comic", "build" };

        public static bool windowIsOpen = false;

        public AddonJsonUI(GarrysModWorkshopUtility.frmGarrysModWorkshopUtility form)
        {
            InitializeComponent();
            sendBackToMain = form;
        }

        private void AddonJsonUI_Load(object sender, EventArgs e)
        {
            radServerContent.Checked = true;
            windowIsOpen = true;
        }

        private void AddonJsonUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            windowIsOpen = false;
        }

        private void btnDirectoryOfJSon_Click(object sender, EventArgs e)
        {
            if (sendBackToMain.ignoreNotices == false)
            {
                MessageBox.Show("Remember to use the same directory that has your addon's contents in it", "Notice");
            }

            CommonOpenFileDialog findJSonFolder = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse folder to output .JSON result",
                RestoreDirectory = true,
            };

            findJSonFolder.IsFolderPicker = true;

            if (findJSonFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtDirectoryOfJSon.Text = findJSonFolder.FileName;
                findJSonFolder = null;
                GC.Collect();
            }
        }

        private void btnSendBackToMain_Click(object sender, EventArgs e)
        {
            String addonType = getAddonType();

            if (txtDirectoryOfJSon.Text.Equals(""))
            {
                MessageBox.Show("Please select a json output directory!", "Error");
            }
            else if (txtAddonTitle.Text.Equals(""))
            {
                MessageBox.Show("Please enter an addon title!", "Error");
            }
            else if (addonType.Equals(""))
            {
                MessageBox.Show("Please select an addon type!", "Error");
            }
            else
            {
                string[] wildcards = null;
                if (txtWildcards.Text.Equals(""))
                {
                    wildcards = new string[1];
                    wildcards[0] = "";
                }
                else
                {
                    String wildCardFormatter = Regex.Replace(txtWildcards.Text, @"\s+", String.Empty);
                    wildcards = wildCardFormatter.Split(',');
                }

                if (txtAddonTags.Text.Equals("") || !txtAddonTags.Text.Contains(","))
                {
                    MessageBox.Show("Please enter 2 addon tags!", "Error");
                }
                else
                {
                    String addonTagFormatter = Regex.Replace(txtAddonTags.Text, @"\s+", String.Empty);
                    string[] tags = addonTagFormatter.Split(',');
                    String addonTag1 = tags[0];
                    String addonTag2 = tags[1];
                    bool firstTagValid = false;

                    foreach (string tag in addonTags)
                    {
                        if (addonTag1.Equals(tag))
                        {
                            firstTagValid = true;
                            break;
                        }
                    }

                    if (firstTagValid == false)
                    {
                        MessageBox.Show("Enter a valid first tag for addon.json!", "Error");
                    }

                    else
                    {
                        if (addonTag2.Equals(addonTag1))
                        {
                            MessageBox.Show("Enter another second tag for addon.json! (not the same one twice)", "Error");
                        }
                        else
                        {

                        }
                        bool secondTagValid = false;
                        foreach (string tag in addonTags)
                        {
                            if (addonTag2.Equals(tag))
                            {
                                secondTagValid = true;
                                break;
                            }
                        }

                        if (secondTagValid == false)
                        {
                            MessageBox.Show("Enter a valid second tag for addon.json!", "Error");
                        }
                        else
                        {
                            ArrayList cards = new ArrayList();
                            foreach (string card in wildcards)
                            {
                                cards.Add(card);
                            }

                            String changeNotes = "";
                            if (!(txtChangeNotes.Text.Equals("")))
                            {
                                changeNotes = " - " + txtChangeNotes.Text;
                            }
                            Task jsonTask = new Task(txtDirectoryOfJSon.Text, txtAddonTitle.Text, addonTag1, addonTag2, addonType, cards, changeNotes);
                            sendBackToMain.lstQueue.Items.Add(jsonTask);
                            sendBackToMain.allTasks.Add(jsonTask);
                            sendBackToMain.tasks.Add(jsonTask);
                        }
                    }
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To use this User Interface, make sure to enter in all information correctly for each part" +
                "\n\nFor the JSon Output, Press the \"JSon Output\" button and select a destination for the file" +
                "\n\nFor the Addon Title, type in anything that you want, just do not enclose it in quotes ( Example: \"text\" )" +
                "\n\nFor the Wildcards, enter in each wildcard and do not enclose in quotes ( Example: *.txt,*png )" +
                "\n\nFor the Addon Tags, enter them in and do not enclose them in quotes ( Example: fun, realism )" +
                "\n\nAlso, the valid addon tags you can have are: \"fun\", \"roleplay\", \"scenic\", \"movie\", \"realism\", \"cartoon\", \"water\", \"comic\", and \"build\"" +
                "\n\nWhen you are done, press the \"Send Back To Program\" then you can run the task and get your new file!", "Help Page");
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            if (txtDirectoryOfJSon.Text.Equals(""))
            {
                MessageBox.Show("Please select a json output directory!", "Error");
            }
            else if (txtAddonTitle.Text.Equals(""))
            {
                MessageBox.Show("Please enter an addon title!", "Error");
            }
            else if (getAddonType().Equals(""))
            {
                MessageBox.Show("Please select an addon type!", "Error");
            }
            else
            {
                if (txtAddonTags.Text.Equals("") || !txtAddonTags.Text.Contains(","))
                {
                    MessageBox.Show("Please enter 2 addon tags!", "Error");
                }
                else
                {
                    String addonTagFormatter = Regex.Replace(txtAddonTags.Text, @"\s+", String.Empty);
                    string[] tags = addonTagFormatter.Split(',');
                    String addonTag1 = tags[0];
                    String addonTag2 = tags[1];
                    string[] wildcards = null;
                    if (txtWildcards.Text.Equals(""))
                    {
                        wildcards = new string[1];
                        wildcards[0] = "";
                    }
                    else
                    {
                        String wildCardFormatter = Regex.Replace(txtWildcards.Text, @"\s+", String.Empty);
                        wildcards = wildCardFormatter.Split(',');
                    }

                    bool firstTagValid = false;

                    foreach (string tag in addonTags)
                    {
                        if (addonTag1.Equals(tag))
                        {
                            firstTagValid = true;
                            break;
                        }
                    }

                    if (firstTagValid == false)
                    {
                        MessageBox.Show("Enter a valid first tag for addon.json!", "Error");
                    }

                    else
                    {
                        if (addonTag2.Equals(addonTag1))
                        {
                            MessageBox.Show("Enter another second tag for addon.json! (not the same one twice)", "Error");
                        }
                        else
                        {

                        }
                        bool secondTagValid = false;
                        foreach (string tag in addonTags)
                        {
                            if (addonTag2.Equals(tag))
                            {
                                secondTagValid = true;
                                break;
                            }
                        }

                        if (secondTagValid == false)
                        {
                            MessageBox.Show("Enter a valid second tag for addon.json!", "Error");
                        }
                        else
                        {

                            int counter = 0;
                            StreamWriter scriptWriter = new StreamWriter(txtDirectoryOfJSon.Text + "\\addon.json");
                            scriptWriter.WriteLine("{");
                            scriptWriter.WriteLine("\t\"title\": \"" + txtAddonTitle.Text + "\",");
                            scriptWriter.WriteLine("\t\"type\": \"" + getAddonType() + "\",");
                            scriptWriter.WriteLine("\t\"tags\": [\"" + addonTag1 + "\", \"" + addonTag2 + "\"],");
                            scriptWriter.WriteLine("\t\"ignore\":");
                            scriptWriter.WriteLine("\t[");
                            if (wildcards.Length == 1 && wildcards[0].Equals(""))
                            {

                            }
                            else
                            {
                                foreach (String wildcard in wildcards)
                                {
                                    if (counter == wildcards.Length - 1)
                                    {
                                        scriptWriter.WriteLine("\t\t\"" + wildcard + "\"");
                                    }
                                    else
                                    {
                                        scriptWriter.WriteLine("\t\t\"" + wildcard + "\",");
                                    }
                                    counter++;
                                }
                            }
                            scriptWriter.WriteLine("\t]");
                            scriptWriter.WriteLine("}");
                            scriptWriter.Close();
                        }
                    }
                }
            }
        }

        public String getAddonType()
        {
            String addonType = "";
            if (radServerContent.Checked)
            {
                addonType = "ServerContent";
            }
            else if (radGamemode.Checked)
            {
                addonType = "gamemode";
            }
            else if (radMap.Checked)
            {
                addonType = "map";
            }
            else if (radWeapon.Checked)
            {
                addonType = "weapon";
            }
            else if (radVehicle.Checked)
            {
                addonType = "vehicle";
            }
            else if (radNpc.Checked)
            {
                addonType = "npc";
            }
            else if (radTool.Checked)
            {
                addonType = "tool";
            }
            else if (radEffects.Checked)
            {
                addonType = "effects";
            }
            else if (radModel.Checked)
            {
                addonType = "model";
            }
            return addonType;
        }
    }
}
