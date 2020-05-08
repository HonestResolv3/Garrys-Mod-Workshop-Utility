using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            cboxTag1.SelectedIndex = 0;
            cboxTag2.SelectedIndex = 0;
            windowIsOpen = true;
            loadInput();
        }

        private void AddonJsonUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            windowIsOpen = false;
            saveInput();
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

            try
            {
                if (findJSonFolder.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtDirectoryOfJSon.Text = findJSonFolder.FileName;
                    if (chkAllowAutofillingTitle.Checked)
                    {
                        txtAddonTitle.Text = findJSonFolder.FileName.Substring(findJSonFolder.FileName.LastIndexOf("\\") + 1);
                    }
                    findJSonFolder = null;
                    GC.Collect();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error when trying to auto-fill the information, is the folder name empty?", "Error");
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

                    int index = 0;
                    foreach (String wildcard in wildcards)
                    {
                        wildcards[index] = wildcard.ToLower();
                        index++;
                    }
                }

                String addonTag1 = cboxTag1.SelectedItem.ToString().ToLower();
                String addonTag2 = cboxTag2.SelectedItem.ToString().ToLower();

                if (!addonTag1.Equals(addonTag2))
                {
                    ArrayList cards = new ArrayList();
                    foreach (string card in wildcards)
                    {
                        cards.Add(card.ToLower());
                    }

                    String changeNotes = "";
                    if (!(txtTaskNotes.Text.Equals("")))
                    {
                        changeNotes = " - " + txtTaskNotes.Text;
                    }
                    Task jsonTask = new Task(txtDirectoryOfJSon.Text, txtAddonTitle.Text, addonTag1, addonTag2, addonType, cards, changeNotes);
                    sendBackToMain.lstQueue.Items.Add(jsonTask);
                    sendBackToMain.allTasks.Add(jsonTask);
                    sendBackToMain.tasks.Add(jsonTask);
                    return;
                }

                MessageBox.Show("Please do not enter the same tag twice!", "Error");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To use this User Interface, make sure to enter in all information correctly for each part" +
                "\n\nFor the JSon Output, Press the \"JSon Output\" button and select a destination for the file" +
                "\n\nFor the Addon Title, type in anything that you want, just do not enclose it in quotes ( Example: \"text\" )" +
                "\n\nFor the Wildcards, enter in each wildcard and do not enclose in quotes ( Example: *.txt,*png )" +
                "\n\nFor the Addon Tags, select the proper tags from the drop-downs, no duplicates!" +
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
                String addonTag1 = cboxTag1.SelectedItem.ToString().ToLower();
                String addonTag2 = cboxTag2.SelectedItem.ToString().ToLower();
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

                if (!addonTag1.Equals(addonTag2))
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
                                scriptWriter.WriteLine("\t\t\"" + wildcard.ToLower() + "\"");
                            }
                            else
                            {
                                scriptWriter.WriteLine("\t\t\"" + wildcard.ToLower() + "\",");
                            }
                            counter++;
                        }
                    }
                    scriptWriter.WriteLine("\t]");
                    scriptWriter.WriteLine("}");
                    scriptWriter.Close();
                    return;
                }

                MessageBox.Show("Please do not enter the same tag twice!", "Error");
            }
        }


        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtDirectoryOfJSon.Text = "";
            txtAddonTitle.Text = "";
            txtTaskNotes.Text = "";
            txtWildcards.Text = "";
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
            else if (radEntity.Checked)
            {
                addonType = "entity";
            }
            return addonType;
        }

        public void saveInput()
        {
            GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIOutput = txtDirectoryOfJSon.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUITitle = txtAddonTitle.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIWildcards = txtWildcards.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUITaskNotes = txtTaskNotes.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonTag1 = cboxTag1.SelectedIndex;
            GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonTag2 = cboxTag2.SelectedIndex;

            if (chkAllowAutofillingTitle.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AllowAutofillOfTitle = true;
            }
            else
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AllowAutofillOfTitle = false;
            }

            if (radServerContent.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 0;
            }
            else if (radGamemode.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 1;
            }
            else if (radMap.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 2;
            }
            else if (radWeapon.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 3;
            }
            else if (radVehicle.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 4;
            }
            else if (radNpc.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 5;
            }
            else if (radTool.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 6;
            }
            else if (radEffects.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 7;
            }
            else if (radModel.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 8;
            }
            else if (radEntity.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType = 9;
            }

            GarrysModWorkshopUtil.Properties.Settings.Default.Save();
        }

        public void loadInput()
        {
            txtDirectoryOfJSon.Text = GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIOutput;
            txtAddonTitle.Text = GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUITitle;
            txtWildcards.Text = GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIWildcards;
            txtTaskNotes.Text = GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUITaskNotes;
            cboxTag1.SelectedIndex = GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonTag1;
            cboxTag2.SelectedIndex = GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonTag2;

            switch (GarrysModWorkshopUtil.Properties.Settings.Default.AddonJsonUIAddonType)
            {
                case 0:
                    radServerContent.Checked = true;
                    break;
                case 1:
                    radGamemode.Checked = true;
                    break;
                case 2:
                    radMap.Checked = true;
                    break;
                case 3:
                    radWeapon.Checked = true;
                    break;
                case 4:
                    radVehicle.Checked = true;
                    break;
                case 5:
                    radNpc.Checked = true;
                    break;
                case 6:
                    radTool.Checked = true;
                    break;
                case 7:
                    radEffects.Checked = true;
                    break;
                case 8:
                    radModel.Checked = true;
                    break;
                case 9:
                    radEntity.Checked = true;
                    break;
            }

            if (GarrysModWorkshopUtil.Properties.Settings.Default.AllowAutofillOfTitle)
            {
                chkAllowAutofillingTitle.Checked = true;
            }
            else
            {
                chkAllowAutofillingTitle.Checked = false;
            }
        }
    }
}
