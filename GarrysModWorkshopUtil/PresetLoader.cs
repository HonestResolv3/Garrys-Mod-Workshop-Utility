using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace GarrysModWorkshopUtil
{
    public partial class PresetLoader : Form
    {
        public GarrysModWorkshopUtility.frmGarrysModWorkshopUtility programSender;
        public static bool presetWindowIsOpen = false;
        ArrayList presets = new ArrayList();
        string[] files;
        public PresetLoader(GarrysModWorkshopUtility.frmGarrysModWorkshopUtility form)
        {
            InitializeComponent();
            programSender = form;
        }

        private void PresetLoader_Load(object sender, EventArgs e)
        {
            radGmad.Checked = true;
            presetWindowIsOpen = true;
            txtPresetLocation.Text = GarrysModWorkshopUtil.Properties.Settings.Default.DirectoryForPresets;
            btnViewPresetInfo.Enabled = false;
            if ((!(GarrysModWorkshopUtil.Properties.Settings.Default.DirectoryForPresets.Equals(""))) && Directory.Exists(GarrysModWorkshopUtil.Properties.Settings.Default.DirectoryForPresets))
            {
                loadPresets();
            }
        }

        private void PresetLoader_FormClosing(object sender, FormClosingEventArgs e)
        {
            presetWindowIsOpen = false;
        }

        private void btnSavePreset_Click(object sender, EventArgs e)
        {
            if (txtPresetName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a name for the preset file!", "Error");
            }
            else
            {
                if (txtPresetLocation.Text.Equals(""))
                {
                    CommonOpenFileDialog whereToSave = new CommonOpenFileDialog()
                    {
                        InitialDirectory = @"C:\",
                        IsFolderPicker = true,
                        RestoreDirectory = true,
                        Title = "Where to save preset?"
                    };

                    if (whereToSave.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        savePreset();
                    }
                }
                else
                {
                    if (Directory.Exists(txtPresetLocation.Text))
                    {
                        savePreset();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid path!");
                    }
                }
            }
            loadPresets();
        }

        private void btnLoadPreset_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderLoader = new CommonOpenFileDialog()
            {
                Title = "Load Preset Folder",
                InitialDirectory = @"C:\",
                IsFolderPicker = true,
                RestoreDirectory = true
            };

            if (folderLoader.ShowDialog() == CommonFileDialogResult.Ok)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.DirectoryForPresets = folderLoader.FileName;
                txtPresetLocation.Text = folderLoader.FileName;
                GarrysModWorkshopUtil.Properties.Settings.Default.Save();
            }
        }

        private void btnLoadContents_Click(object sender, EventArgs e)
        {
            loadPresets();
        }

        private void btnViewPresetInfo_Click(object sender, EventArgs e)
        {
            readPreset();
        }


        private void btnSendBackToMain_Click(object sender, EventArgs e)
        {
            if (lstPresets.Items.Count == 0)
            {
                MessageBox.Show("You cannot load 0 presets!", "Error");
            }
            else if (lstPresets.SelectedIndex < 0 || lstPresets.SelectedIndex > lstPresets.Items.Count)
            {
                lstPresets.SelectedIndex = 0;
            }
            readPreset();
            programSender.addonInput = txtAddonFolderLocationPreset.Text;
            programSender.exeFolderLocation = txtGMadFolderLocationPreset.Text;
            programSender.iconLocation = txtIconFolderLocationPreset.Text;
            programSender.gmaOutputLocation = txtGMAOutputPreset.Text;
            if (!(txtAddonFolderLocationPreset.Text.Equals("")))
            {
                try
                {
                    programSender.addonID = Int64.Parse(txtAddonIDNumberPreset.Text);
                }
                catch (Exception)
                {
                    programSender.addonID = 000000000;
                }
            }
            programSender.addonOutput = txtGMALocationPreset.Text;
            programSender.receiveTaskInfo(programSender, 7);
        }

        private void loadPresets()
        {
            if (Directory.Exists(txtPresetLocation.Text))
            {
                try
                {
                    files = System.IO.Directory.GetFiles(txtPresetLocation.Text, "*.gmwu_preset");
                    if (files.Length != 0)
                    {
                        presets.Clear();
                        lstPresets.Items.Clear();
                        int index = 0;
                        foreach (string file in files)
                        {
                            StreamReader fileReader = new StreamReader(file);
                            string presetName = fileReader.ReadLine();
                            string addonInput = fileReader.ReadLine();
                            string iconLocationInput = fileReader.ReadLine();
                            string exePath = fileReader.ReadLine();
                            string gmaLoc = fileReader.ReadLine();
                            string gmaOutput = fileReader.ReadLine();
                            string addonIDNumber = fileReader.ReadLine();
                            presets.Add(new PresetData(presetName, addonInput, iconLocationInput, exePath, gmaLoc, gmaOutput, addonIDNumber, file));
                            lstPresets.Items.Add(presets[index]);
                            index++;
                            btnViewPresetInfo.Enabled = true;
                            fileReader.Dispose();
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You cannot load presets from this location", "Error");
                }
                catch (Exception)
                {
                    MessageBox.Show("An unexpected error happened", "Error");
                }
            }  
        }

        private void btnFolderLocation_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog findProperFolder = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse addon folder",
                RestoreDirectory = true,
            };

            findProperFolder.IsFolderPicker = true;

            if (findProperFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtAddonFolderLocationPreset.Text = findProperFolder.FileName;
                findProperFolder = null;
                GC.Collect();
            }
            else
            {
                findProperFolder = null;
                GC.Collect();
            }
        }

        private void btnIconFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog findProperIcon = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse supported JPG file",
                RestoreDirectory = true,
            };

            findProperIcon.IsFolderPicker = false;
            findProperIcon.Filters.Add(new CommonFileDialogFilter("JPG Files", "*.jpg"));
            findProperIcon.InitialDirectory = txtIconFolderLocationPreset.Text;

            if (findProperIcon.ShowDialog() == CommonFileDialogResult.Ok)
            {
                System.Drawing.Image imageReader = System.Drawing.Image.FromFile(findProperIcon.FileName);
                if ((imageReader.Width != 512) || (imageReader.Height != 512))
                {
                    MessageBox.Show("This kind of jpg file is not valid!\n\nValid files must be 512x512 in size", "Error");
                }
                else
                {
                    txtIconFolderLocationPreset.Text = findProperIcon.FileName;
                    findProperIcon = null;
                    GC.Collect();

                }
            }
            else
            {
                findProperIcon = null;
                GC.Collect();
            }
        }

        private void btnGmadFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog findProperEXE = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse exe file",
                RestoreDirectory = true,
            };

            findProperEXE.IsFolderPicker = false;
            findProperEXE.Filters.Add(new CommonFileDialogFilter("GMad or GMPublish Exe File", "*.exe"));
            findProperEXE.InitialDirectory = txtGMadFolderLocationPreset.Text;

            if (findProperEXE.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string formatting = findProperEXE.FileName.Substring(0, findProperEXE.FileName.LastIndexOf("\\"));
                string exeName = "";
                if (radGmad.Checked)
                {
                    exeName = "gmad.exe";
                }
                else if (radGMPublish.Checked)
                {
                    exeName = "gmpublish.exe";
                }
                formatting += "\\" + exeName;
                txtGMadFolderLocationPreset.Text = formatting;
                findProperEXE = null;
                GC.Collect();
            }                    
            else
            {
                findProperEXE = null;
                GC.Collect();
            }
        }

        private void btnGMALocation_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog findProperGMA = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse GMA file",
                RestoreDirectory = true,
            };

            findProperGMA.IsFolderPicker = false;
            findProperGMA.Filters.Add(new CommonFileDialogFilter("Garry's Mod Addon Files", "*.gma"));
            findProperGMA.InitialDirectory = txtGMALocationPreset.Text;

            if (findProperGMA.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtGMALocationPreset.Text = findProperGMA.FileName;
                findProperGMA = null;
                GC.Collect();
            }
        }

        private void btnGMAOutput_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog findProperFolder = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse output .gma folder",
                RestoreDirectory = true,
            };

            findProperFolder.IsFolderPicker = true;
            findProperFolder.InitialDirectory = txtGMALocationPreset.Text;

            if (findProperFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtGMAOutputPreset.Text = findProperFolder.FileName;
                findProperFolder = null;
                GC.Collect();
            }
        }

        private void btnAddonID_Click(object sender, EventArgs e)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox("Add your workshop addon ID here", "Add ID");
            long id_int;

            if (id.Equals(""))
            {

            }

            else if (!(Int64.TryParse(id, out id_int)))
            {
                MessageBox.Show("Do not add any spaces or letters!", "Error");
            }

            else
            {
                if (id.Length < 9 || id.Length > 10)
                {
                    MessageBox.Show("Your addon ID should only be 9 - 10 digits!", "Error");
                }

                else
                {
                    txtAddonIDNumberPreset.Text = id;
                }
            }
        }


        private void btnDeletePreset_Click(object sender, EventArgs e)
        {
            if (lstPresets.Items.Count == 0)
            {
                MessageBox.Show("You cannot delete nothing!", "Error");
            }
            else if (lstPresets.SelectedIndex > lstPresets.Items.Count)
            {
                MessageBox.Show("Select a valid preset!", "Error");
            }
            else
            {
                if (lstPresets.SelectedIndex < 0)
                {
                    lstPresets.SelectedIndex = 0;
                }
                String choice = Microsoft.VisualBasic.Interaction.InputBox("Are you sure you want to delete this preset from the list? (Type \"y\" for yes or \"n\" for no, press the X to cancel the removal) ", "Notice");
                choice = choice.ToLower();
                if (choice.Equals("y"))
                {
                    try
                    {
                        int index = lstPresets.SelectedIndex;
                        File.Delete(files[index]);
                        files[index] = "";
                        lstPresets.Items.RemoveAt(index);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occured when trying to delete the file, it may not exist or it is invalid", "Error");
                    }
                }
                else if (choice.Equals("") || choice.Equals("n"))
                {

                }
                else
                {
                    MessageBox.Show("Please enter either 'y' or 'n'!", "Error");
                }
            }
        }

        private void readPreset()
        {
            try
            {
                int index = lstPresets.SelectedIndex;
                if (lstPresets.SelectedIndex < 0 && lstPresets.Items.Count != 0)
                {
                    index = 0;
                }

                GarrysModWorkshopUtil.PresetData newData = (GarrysModWorkshopUtil.PresetData)presets[lstPresets.SelectedIndex];
                txtAddonFolderLocationPreset.Text = newData.getAddonInput();
                txtIconFolderLocationPreset.Text = newData.getAddonIconInput();
                txtAddonIDNumberPreset.Text = newData.getAddonID();
                txtGMadFolderLocationPreset.Text = newData.getExeInput();
                txtGMALocationPreset.Text = newData.getGMALocInput();
                txtGMAOutputPreset.Text = newData.getGMAOutput();
                txtPresetName.Text = newData.getPresetName();
            }
            catch (Exception)
            {
                MessageBox.Show("You may have attenpted to load a preset after it was deleted, do not do that", "Error");
            }
        }

        private void savePreset()
        {
            StreamWriter presetWriter = new StreamWriter(txtPresetLocation.Text + "\\" + txtPresetName.Text + ".gmwu_preset");
            presetWriter.WriteLine(txtPresetName.Text);
            presetWriter.WriteLine(txtAddonFolderLocationPreset.Text);
            presetWriter.WriteLine(txtIconFolderLocationPreset.Text);
            presetWriter.WriteLine(txtGMadFolderLocationPreset.Text);
            presetWriter.WriteLine(txtGMALocationPreset.Text);
            presetWriter.WriteLine(txtGMAOutputPreset.Text);
            presetWriter.WriteLine(txtAddonIDNumberPreset.Text);
            presetWriter.WriteLine("DO NOT MODIFY THIS FILE, UNEXPECTED OUTPUTS WILL OCCUR");
            presetWriter.Close();
            presetWriter.Dispose();
            presetWriter = null;
            GC.Collect();
            MessageBox.Show("Preset saved successfully!", "Notice");
        }
    }
}
