using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;

namespace GarrysModWorkshopUtility
{
    public partial class frmGarrysModWorkshopUtility : Form
    {
        Resizer resizer;

        public frmGarrysModWorkshopUtility()
        {
            InitializeComponent();
            resizer = new Resizer(this);
            this.Load += Resizer_Load;
            this.Resize += Resizer_Resize;
        }

        private void Resizer_Load(object sender, EventArgs e)
        {
            resizer._get_initial_size();
        }

        private void Resizer_Resize(object sender, EventArgs e)
        {
            resizer._resize();
        }

        public string exeName = "";
        public string imagePath = "";
        public string id;
        public long id_int;
        public String timerValue;
        public String scriptDeleteTime;
        public long timerValue_long;
        public long scriptDeleteTime_long;

        public int fixPublishConstructor = 0;
        public static int formattedTime;
        public static int autoRunDeleteTime;

        public bool preventDeletingAddonJSON = false;
        public bool autoDeleteText = false;
        public static bool enableCommandPause = false;

        bool ignoreNotices = false;
        bool isProgramRunningGMPublish = false;
        string[] lines;

        String[] addonTypes = { "ServerContent", "gamemode", "map", "weapon", "vehicle", "npc", "tool", "effects", "model" };
        String[] addonTags = { "fun", "roleplay", "scenic", "movie", "realism", "cartoon", "water", "comic", "build" };

        public ArrayList tasks = new ArrayList();
        public ArrayList allTasks = new ArrayList();
        ArrayList newStringList = new ArrayList();
        ArrayList forAddonList = new ArrayList();

        public string addonOutput;
        public string addonInput;
        public string exeFolderLocation;
        public string jsonOutputLocation;
        public string iconLocation;
        public string gmaOutputLocation;
        public long addonID;
        public bool deleingJSON;

        private void frmGarrysModWorkshopUtility_Load(object sender, EventArgs e)
        {
            /*Rectangle newRect = Screen.FromControl(this).Bounds;
            int desktopX = newRect.X;
            int desktopY = newRect.Y;
            this.Location = new Point(desktopX, desktopY);*/
            startProgramEffects();
            makeControlsTransparent();
            loadUserInput();
            if (GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime == 0)
            {
                timeToStartTask.Interval = (int) (60 / 0.001);
                GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime = (int)(60 / 0.001);
            }

            else
            {
                timeToStartTask.Interval = GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime;
                lblRunTaskTime.Text = "Running Each Task: Every " + (GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime * 0.001) + " seconds";
            }

            if (chkAutoRun.Checked)
            {
                lblRunTaskTime.Text = "Running Each Task: Every " + (GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime * 0.001) + " seconds";
            }

            else
            {
                lblRunTaskTime.Text = "Running Each Task: Manually";
            }

            if (formattedTime == 0)
            {
                formattedTime = 60;
                lblScriptDelete.Text = "Tasks Delete: " + formattedTime + " Seconds Upon Run";
            }

            else
            {
                lblScriptDelete.Text = "Tasks Delete: " + formattedTime + " Seconds Upon Run";
            }

            if (chkAutoRun.Checked)
            {
                btnModifyTimer.Enabled = true;
            }

            else
            {
                btnModifyTimer.Enabled = false;
            }
        }
        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            if (radCreateGma.Checked == true)
            {
                if (txtAddonFolderLocation.Text.Equals("") || txtGMadFolderLocation.Text.Equals("") || txtGMAOutput.Text.Equals(""))
                {
                    MessageBox.Show("Please do not leave any fields blank!", "Error");
                }
                else
                {
                    String gmaName = Microsoft.VisualBasic.Interaction.InputBox("Type the name of your output .gma here", "Add name");
                    if (gmaName.Equals(""))
                    {
                        MessageBox.Show("You did not type anything so the gma is called \"addon\" when created", "Notice");
                        gmaName = "addon";
                    }

                    String taskNotes = Microsoft.VisualBasic.Interaction.InputBox("Any notes you want to put next to the task name? (Type \"n\" to decline)", "Add notes?");
                    if (taskNotes.Equals("") || taskNotes.Equals("n"))
                    {
                        taskNotes = "";
                    }
                    else
                    {
                        taskNotes = " - " + taskNotes;
                    }
                    GarrysModWorkshopUtil.Task newGMAToCreate = new GarrysModWorkshopUtil.Task(txtAddonFolderLocation.Text, txtGMadFolderLocation.Text, gmaName, taskNotes, txtGMAOutput.Text, preventDeletingAddonJSON/*, "gmod_util_create_gma.bat"*/);
                    tasks.Add(newGMAToCreate);
                    allTasks.Add(newGMAToCreate);
                    lstQueue.Items.Add(newGMAToCreate);
                }
            }
            else if (radPublishAddon.Checked == true)
            {
                if (txtGMALocation.Text.Equals("") || txtIconFolderLocation.Text.Equals("") || txtGMadFolderLocation.Text.Equals(""))
                {
                    MessageBox.Show("Please do not leave any fields blank!", "Error");
                }
                else
                {
                    fixPublishConstructor++;
                    String taskNotes = Microsoft.VisualBasic.Interaction.InputBox("Any notes you want to put next to the task name? (Type \"n\" to decline)", "Add notes?");
                    if (taskNotes.Equals("") || taskNotes.Equals("n"))
                    {
                        taskNotes = "";
                    }
                    else
                    {
                        taskNotes = " - " + taskNotes;
                    }
                    GarrysModWorkshopUtil.Task newAddonToPublish = new GarrysModWorkshopUtil.Task(txtIconFolderLocation.Text, txtGMadFolderLocation.Text, txtGMALocation.Text, fixPublishConstructor, taskNotes/*, "gmod_util_publish.bat"*/);
                    tasks.Add(newAddonToPublish);
                    allTasks.Add(newAddonToPublish);
                    lstQueue.Items.Add(newAddonToPublish);
                }
            }

            else if (radUpdateAddon.Checked == true)
            {
                if (txtGMadFolderLocation.Text.Equals("") || txtGMALocation.Text.Equals("") || txtAddonIDNumber.Text.Equals(""))
                {
                    MessageBox.Show("Please do not leave any fields blank!", "Error");
                }
                else
                {
                    String changeNotes = Microsoft.VisualBasic.Interaction.InputBox("Any change notes you want to put? (Type \"n\" to decline)", "Add change notes?");
                    if (changeNotes.Equals("") || changeNotes.Equals("n"))
                    {
                        changeNotes = "";
                    }
                    String taskNotes = Microsoft.VisualBasic.Interaction.InputBox("Any notes you want to put next to the task name? (Type \"n\" to decline)", "Add notes?");
                    if (taskNotes.Equals("") || taskNotes.Equals("n"))
                    {
                        taskNotes = "";
                    }
                    else
                    {
                        taskNotes = " - " + taskNotes;
                    }

                    try
                    {
                        GarrysModWorkshopUtil.Task newAddonToUpdate = new GarrysModWorkshopUtil.Task(txtGMadFolderLocation.Text, txtGMALocation.Text, Int64.Parse(txtAddonIDNumber.Text), changeNotes, taskNotes/*, "gmod_util_update_addon.bat"*/);
                        tasks.Add(newAddonToUpdate);
                        allTasks.Add(newAddonToUpdate);
                        lstQueue.Items.Add(newAddonToUpdate);
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("You are trying to add a task with invalid input to the queue, please do not do that.", "Error");
                    }
                }
            }

            else if (radUpdateIcon.Checked == true)
            {
                if (txtIconFolderLocation.Text.Equals("") || txtGMadFolderLocation.Text.Equals("") || txtAddonIDNumber.Text.Equals(""))
                {
                    MessageBox.Show("Please do not leave any fields blank!", "Error");
                }

                else
                {
                    String taskNotes = Microsoft.VisualBasic.Interaction.InputBox("Any notes you want to put next to the task name? (Type \"n\" to decline)", "Add notes?");
                    if (taskNotes.Equals("") || taskNotes.Equals("n"))
                    {
                        taskNotes = "";
                    }
                    else
                    {
                        taskNotes = " - " + taskNotes;
                    }

                    try
                    {
                        GarrysModWorkshopUtil.Task iconToUpdate = new GarrysModWorkshopUtil.Task(txtIconFolderLocation.Text, txtGMadFolderLocation.Text, Int64.Parse(txtAddonIDNumber.Text), taskNotes/*, "gmod_util_update_icon.bat"*/);
                        tasks.Add(iconToUpdate);
                        allTasks.Add(iconToUpdate);
                        lstQueue.Items.Add(iconToUpdate);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You are trying to add a task with invalid input to the queue, please do not do that.", "Error");
                    }
                }
            }

            else if (radExtractGMA.Checked)
            {
                if (txtAddonFolderLocation.Equals("") || txtGMadFolderLocation.Text.Equals("") || txtGMALocation.Text.Equals(""))
                {
                    MessageBox.Show("Please do not leave any fields blank!", "Error");
                }
                else
                {
                    String gmaFileName = txtGMALocation.Text.Substring(txtGMALocation.Text.LastIndexOf("\\") + 1);
                    String taskNotes = Microsoft.VisualBasic.Interaction.InputBox("Any notes you want to put next to the task name? (Type \"n\" to decline)", "Add notes?");
                    if (taskNotes.Equals("") || taskNotes.Equals("n"))
                    {
                        taskNotes = "";
                    }
                    else
                    {
                        taskNotes = " - " + taskNotes;
                    }
                    GarrysModWorkshopUtil.Task GMAToExtract = new GarrysModWorkshopUtil.Task(txtAddonFolderLocation.Text, txtGMadFolderLocation.Text, txtGMALocation.Text, gmaFileName, taskNotes/*, "gmod_util_extract_gma.bat"*/);
                    tasks.Add(GMAToExtract);
                    allTasks.Add(GMAToExtract);
                    lstQueue.Items.Add(GMAToExtract);
                }
            }

            else if (radCreateJSon.Checked)
            {
                if (txtDirectoryOfJSon.Text.Equals("") /*|| txtAddonJSONName.Text.Equals("")*/)
                {
                    MessageBox.Show("Please do not leave any fields blank!", "Error");
                }
                else if (radCreateJSon.Checked)
                {
                    if (txtDirectoryOfJSon.Text.Equals(""))
                    {
                        MessageBox.Show("Please do not leave any fields blank!", "Error");
                    }
                    else
                    {
                        String addonTitle = Microsoft.VisualBasic.Interaction.InputBox("What is the name of this addon?\n\nNote: You have to pick a name to continue", "Add addon title");
                        if (addonTitle.Equals(null) || addonTitle.Equals(""))
                        {
                            MessageBox.Show("Please do not leave any fields blank!", "Error");
                        }
                        else
                        {
                            Boolean invalidAddonType = true;
                            String addonType = Microsoft.VisualBasic.Interaction.InputBox("What is this addon's type?\n\nYour choices are:\nServerContent, gamemode, map, weapon, vehicle, npc, tool, effects, model\n\nNote: You have to pick a addon type to continue", "Add addon title");
                            if (addonType.Equals(null) || addonType.Equals(""))
                            {
                                MessageBox.Show("Please do not leave any fields blank!", "Error");
                            }
                            else
                            {
                                for (int i = 0; i < addonTypes.Length; i++)
                                {
                                    if (addonTypes.Contains(addonType))
                                    {
                                        invalidAddonType = false;
                                        break;
                                    }
                                }

                                if (invalidAddonType == true)
                                {
                                    MessageBox.Show("Invalid addon type!", "Error");
                                }

                                else
                                {
                                    Boolean invalidAddonTag1 = true;
                                    String addonTag1 = Microsoft.VisualBasic.Interaction.InputBox("What is this addon's first tag?\n\nYour choices are:\nfun, roleplay, scenic, movie, realism, cartoon, water, comic, build\n\nNote: You have to pick a addon tag to continue", "Add addon title");
                                    for (int i = 0; i < addonTags.Length; i++)
                                    {
                                        if (addonTags.Contains(addonTag1))
                                        {
                                            invalidAddonTag1 = false;
                                            break;
                                        }
                                    }

                                    if (invalidAddonTag1 == true)
                                    {
                                        MessageBox.Show("Invalid addon tag!", "Error");
                                    }

                                    else
                                    {
                                        ArrayList secondArray = new ArrayList();
                                        String choiceModifier = "\n\nYour choices are:\n";
                                        for (int i = 0; i < addonTags.Length; i++)
                                        {
                                            if (addonTags[i].Equals(addonTag1))
                                            {

                                            }
                                            else
                                            {
                                                choiceModifier += addonTags[i] + ", ";
                                                secondArray.Add(addonTags[i]);
                                            }
                                        }

                                        String addonTag2 = Microsoft.VisualBasic.Interaction.InputBox("What is this addon's second tag?" + choiceModifier + "\n\nNote: You have to pick a addon tag to continue", "Add addon title");

                                        if (addonTag2.Equals(addonTag1))
                                        {
                                            MessageBox.Show("You cannot have a duplicate tag!", "Error");
                                        }

                                        else
                                        {
                                            Boolean isValidTag = false;

                                            for (int i = 0; i < secondArray.Count; i++) {
                                                if (secondArray[i].Equals(addonTag2))
                                                {
                                                    isValidTag = true;
                                                    break;
                                                }
                                            }

                                            if (isValidTag == false)
                                            {
                                                MessageBox.Show("You cannot have an invalid tag!", "Error");
                                            }

                                            else
                                            {
                                                Boolean wantsToAddWildcards = true;
                                                ArrayList newWildcardList = new ArrayList();
                                                while (wantsToAddWildcards == true)
                                                {
                                                    String ignoreWildcard = Microsoft.VisualBasic.Interaction.InputBox("Do you want to add a ignore wildcard? (Type \"n\" or \"exit\" to stop, Type an extension (i.e.: exe, txt) to add)\n\nNote: Do not add any dots \" . \" in the input", "Add ignore wildcard");
                                                    ignoreWildcard.ToLower();

                                                    if (ignoreWildcard.Contains("*.") || ignoreWildcard.Contains("."))
                                                    {
                                                        MessageBox.Show("You do not need to add the \" *. \" before an extension, the program will do that for you", "Error");
                                                    }
                                                    else
                                                    {
                                                        if (ignoreWildcard.ToLower().Equals("n") || ignoreWildcard.ToLower().Equals("exit") || ignoreWildcard.ToLower().Equals(""))
                                                        {
                                                            wantsToAddWildcards = false;
                                                        }
                                                        else
                                                        {
                                                            newWildcardList.Add("*." + ignoreWildcard);
                                                        }
                                                    }
                                                }
                                                String taskNotes = Microsoft.VisualBasic.Interaction.InputBox("Any notes you want to put next to the task name? (Type \"n\" to decline)", "Add notes?");
                                                if (taskNotes.Equals("") || taskNotes.Equals("n"))
                                                {
                                                    taskNotes = "";
                                                }
                                                else
                                                {
                                                    taskNotes = " - " + taskNotes;
                                                }
                                                GarrysModWorkshopUtil.Task newJSONToCreate = new GarrysModWorkshopUtil.Task(txtDirectoryOfJSon.Text, addonTitle, addonTag1, addonTag2, addonType, newWildcardList, taskNotes);
                                                tasks.Add(newJSONToCreate);
                                                allTasks.Add(newJSONToCreate);
                                                lstQueue.Items.Add(newJSONToCreate);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAddonID_Click(object sender, EventArgs e)
        {
            if (ignoreNotices == false)
            {
                MessageBox.Show("Remember to look at the addon ID that is on the addon you want to update\n\nIt will always be 9 - 10 digits seen at the end of the addon URL\n\nThe location:\nhttp://steamcommunity.com/sharedfiles/filedetails/?id=(9-10 digits)", "Notice");
            }
            id = Microsoft.VisualBasic.Interaction.InputBox("Add your workshop addon ID here", "Add ID");

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
                    txtAddonIDNumber.Text = id;
                }
            }
        }

        private void btnFolderLocation_Click(object sender, EventArgs e)
        {
            if (ignoreNotices == false)
            {
                if (radExtractGMA.Checked)
                {
                    MessageBox.Show("Remember to put the extracted contents in a good place you can remember", "Notice");
                }
                
                else
                {
                    MessageBox.Show("Remember to make sure your addon folder has a file named \"addon.json\" in it", "Notice");
                }
            }
            checkForPublishOrCreateExe();
            CommonOpenFileDialog findProperFolder = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse addon folder",
                RestoreDirectory = true,
            };

            findProperFolder.IsFolderPicker = true;

            if (findProperFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtAddonFolderLocation.Text = findProperFolder.FileName;
            }
        }

        private void btnIconFolder_Click(object sender, EventArgs e)
        {
            if (ignoreNotices == false)
            {
                MessageBox.Show("Remember to make your icons 512x512, they must also be a .JPG file and baseline\n\nMake sure the icon name is the same name as the .gma!\n\nDo not add any commas or colons in the file name", "Notice");
            }
            checkForPublishOrCreateExe();
            CommonOpenFileDialog findProperIcon = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse supported JPG file",
                RestoreDirectory = true,
            };

            findProperIcon.IsFolderPicker = false;
            findProperIcon.Filters.Add(new CommonFileDialogFilter("JPG Files", "*.jpg"));
            findProperIcon.InitialDirectory = txtIconFolderLocation.Text;

            if (findProperIcon.ShowDialog() == CommonFileDialogResult.Ok)
                {
                System.Drawing.Image imageReader = System.Drawing.Image.FromFile(findProperIcon.FileName);
                if ((imageReader.Width < 512 || imageReader.Width > 512) || (imageReader.Height < 512 || imageReader.Height > 512))
                {
                    MessageBox.Show("This kind of jpg file is not valid!\n\nValid files must be 512x512 in size", "Error");
                }
                else
                {
                    txtIconFolderLocation.Text = findProperIcon.FileName;
                    imagePath = findProperIcon.FileName;
                    updateIconPreview();
                }
            }
        }

        private void btnGmadFolder_Click(object sender, EventArgs e)
        {

            if (chkUseDefLoc.Checked == true)
            {
                MessageBox.Show("You don't need to put in another location for GMad / GMPublish if it's using the default location", "Notice");
            }
            else
            {
                if (ignoreNotices == false)
                {
                    MessageBox.Show("Remember to put the directory where " + "\"" + exeName + "\" is" + "\n\nThe location: (where steam is)\\steamapps\\common\\GarrysMod\\bin", "Notice");
                }

                checkForPublishOrCreateExe();
                String tempName = exeName.Substring(0, exeName.IndexOf("."));


                String appName = "";
                if (exeName.Equals("gmad.exe"))
                {
                    appName = "GMad.exe";
                }
                else if (exeName.Equals("gmpublish.exe"))
                {
                    appName = "GMPublish.exe";
                }

                CommonOpenFileDialog findProperEXE = new CommonOpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Title = "Browse " + appName + " file",
                    RestoreDirectory = true,
                };

                findProperEXE.IsFolderPicker = false;
                findProperEXE.Filters.Add(new CommonFileDialogFilter(appName + " File", "*.exe"));
                findProperEXE.InitialDirectory = txtIconFolderLocation.Text;

                if (findProperEXE.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    if (findProperEXE.FileName.IndexOf(exeName) == -1)
                    {
                        MessageBox.Show("This kind of executable file is not valid!", "Error");
                    }
                    else
                    {
                        txtGMadFolderLocation.Text = findProperEXE.FileName;
                    }
                }
            }
        }

        private void btnDirectoryOfJSon_Click(object sender, EventArgs e)
        {
            if (ignoreNotices == false)
            {
                _ = MessageBox.Show("Remember to use the same directory that has your addon's contents in it", "Notice");
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
            }
        }

        private void btnGMALocation_Click(object sender, EventArgs e)
        {
            if (ignoreNotices == false)
            {
                if (radExtractGMA.Checked)
                {
                    MessageBox.Show("Remember to pick a valid .gma file the program can read", "Notice");
                }

                else if (radUpdateAddon.Checked)
                {
                    MessageBox.Show("Remember to pick a valid .gma file the program can read, also make sure it matches what your addon is! (content wise)", "Notice");
                }

                else
                {
                    MessageBox.Show("Remember to use the correct .gma that goes with your .jpg image\n\nMake sure the icon name is the same name as the .gma!\n\nDo not add any commas or colons in the file name", "Notice");
                }
            }
            CommonOpenFileDialog findProperGMA = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse GMA file",
                RestoreDirectory = true,
            };

            findProperGMA.IsFolderPicker = false;
            findProperGMA.Filters.Add(new CommonFileDialogFilter("Garry's Mod Addon Files", "*.gma"));
            findProperGMA.InitialDirectory = txtIconFolderLocation.Text;

            if (findProperGMA.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtGMALocation.Text = findProperGMA.FileName;
            }
        }

        private void btnGMAOutput_Click(object sender, EventArgs e)
        {
            if (ignoreNotices == false)
            {
                MessageBox.Show("Remember to put the .gma in a good place, a good place could be inside your addon folder", "Notice");
            }

            CommonOpenFileDialog findProperFolder = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse output .gma folder",
                RestoreDirectory = true,
            };

            findProperFolder.IsFolderPicker = true;

            if (findProperFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtGMAOutput.Text = findProperFolder.FileName;
            }
        }

        private void btnJSonName_Click(object sender, EventArgs e)
        {
            String newAddonNameinJSON = Microsoft.VisualBasic.Interaction.InputBox("What is the name of this addon?", "Enter addon name");
            //txtAddonJSONName.Text = newAddonNameinJSON;
        }

        private void btnRunTask_Click(object sender, EventArgs e)
        {
            if (lstQueue.Items.Count == 0)
            {
                MessageBox.Show("You cannot run 0 tasks!", "Error");
            }

            else
            {
                int index;
                if (chkAutoRun.Checked) 
                {
                    MessageBox.Show("You do not need to run a task manually if the program is running it for you!", "Error");
                }

                else
                {
                    try
                    {
                        if (lstQueue.SelectedIndex < 0 || lstQueue.SelectedIndex > lstQueue.Items.Count)
                        {
                            index = 0;
                        }
                        else
                        {
                            index = lstQueue.SelectedIndex;
                        }

                        GarrysModWorkshopUtil.Task testTask = (GarrysModWorkshopUtil.Task)tasks[index];

                        if (testTask.getName().Equals("Create .GMA"))
                        {
                            testTask.createGMAFunction();
                            conControl.StartProcess(testTask.getCommand(), "");
                            testTask.deleteScript("gmod_util_create_gma.bat", 1);
                            lstQueue.Items.RemoveAt(index);
                        }

                        else if (testTask.getName().Equals("Create .JSON"))
                        {
                            testTask.createJSONFunction();
                            lstQueue.Items.RemoveAt(index);
                        }

                        else if (testTask.getName().Equals("Extract .GMA"))
                        {
                            testTask.extractGMAFunction();
                            conControl.StartProcess(testTask.getCommand(), "");
                            testTask.deleteScript("gmod_util_extract_gma.bat", 0);
                            lstQueue.Items.RemoveAt(index);
                        }

                        else if (testTask.getName().Equals("Publish Addon"))
                        {
                            testTask.publishAddonFunction();
                            conControl.StartProcess(testTask.getCommand(), "");
                            testTask.deleteScript("gmod_util_publish.bat", 0);
                            lstQueue.Items.RemoveAt(index);
                        }

                        else if (testTask.getName().Equals("Update Addon"))
                        {
                            testTask.updateAddonFunction();
                            conControl.StartProcess(testTask.getCommand(), "");
                            testTask.deleteScript("gmod_util_update_addon.bat", 0);
                            lstQueue.Items.RemoveAt(index);
                        }

                        else if (testTask.getName().Equals("Update Icon"))
                        {
                            testTask.updateIconFunction();
                            conControl.StartProcess(testTask.getCommand(), "");
                            testTask.deleteScript("gmod_util_update_icon.bat", 0);
                            lstQueue.Items.RemoveAt(index);
                        }

                        tasks.RemoveAt(index);
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("You are trying to run the program with invalid input, please do not do that.", "Error");
                        lstQueue.Items.RemoveAt(0);
                        tasks.RemoveAt(0);
                    }
                }  
            }
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            if (GarrysModWorkshopUtil.Credits.creditsWindowIsOpen == true)
            {

            }
            else
            {
                GarrysModWorkshopUtil.Credits newCreditWindow = new GarrysModWorkshopUtil.Credits();
            }
        }

        private void btnClearTextBoxes_Click(object sender, EventArgs e)
        {
            txtAddonFolderLocation.Text = "";
            txtAddonIDNumber.Text = "";
            if (chkUseDefLoc.Checked == true)
            {

            }
            else
            {
                txtGMadFolderLocation.Text = "";
            }
            txtIconFolderLocation.Text = "";
            txtGMALocation.Text = "";
            txtDirectoryOfJSon.Text = "";
            txtGMAOutput.Text = "";
            pboxIconPreview.Image = GarrysModWorkshopUtil.Properties.Resources.noimagefound;
        }

        private void btnHelpPage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have stumbled across the help page, here's some steps to guide you through this program: \n\n1. Click on which feature you want to run\n\n2. Note the reqirements for each available button in the function\n\n3. Fill in required information using the buttons next to the text boxes\n\n4. Once you have checked everything is right, add the task to the queue\n\n5. Once you're done, add more tasks and run the program as you wish!\n\nNotes: There are toggles to make the program convenient for you as well!", "Welcome to the Garry's Mod Workshop Utility help page!");
        }

        private void btnRemoveFromQueue_Click(object sender, EventArgs e)
        {
            if (lstQueue.Items.Count <= 0)
            {
                MessageBox.Show("You cannot remove nothing!", "Error");
            }

            else if (lstQueue.SelectedIndex == -1)
            {
                if (lstQueue.Items.Count >= 0)
                {
                    String choice = Microsoft.VisualBasic.Interaction.InputBox("Are you sure you want to delete the first task from the queue? (Type \"y\" for yes or \"n\" for no, press the X to cancel the removal) ", "Notice");
                    choice = choice.ToLower();
                    if (choice.Equals("y"))
                    {
                        int index = lstQueue.SelectedIndex;
                        lstQueue.Items.RemoveAt(0);
                        allTasks.RemoveAt(0);
                    }
                    else if (choice.Equals("") || choice.Equals("n"))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Please enter either 'y' or 'n'!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("You cannot remove an unknown element!", "Error");
                }
            }

            else
            {
                String choice = Microsoft.VisualBasic.Interaction.InputBox("Are you sure you want to delete this task from the queue? (Type \"y\" for yes or \"n\" for no, press the X to cancel the removal) ", "Notice");
                choice = choice.ToLower();
                if (choice.Equals("y"))
                {
                    int index = lstQueue.SelectedIndex;
                    lstQueue.Items.RemoveAt(index);
                    allTasks.RemoveAt(index);
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

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            String choice = Microsoft.VisualBasic.Interaction.InputBox("Are you sure you want to delete all tasks from the queue? (Type \"y\" for yes or \"n\" for no, press the X to cancel the removal) ", "Notice");
            choice = choice.ToLower();
            if (choice.Equals("y"))
            {
                lstQueue.Items.Clear();
                allTasks.RemoveRange(0, allTasks.Count);
            }
            else if (choice.Equals("") || choice.Equals("n"))
            {

            }
            else
            {
                MessageBox.Show("Please enter either 'y' or 'n'!", "Error");
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (GarrysModWorkshopUtil.AboutPage.creditsWindowIsOpen == true)
            {

            }
            else
            {
                GarrysModWorkshopUtil.AboutPage newAboutPage = new GarrysModWorkshopUtil.AboutPage();
                newAboutPage.Show();
            }
        }

        private void btnModifyTimer_Click(object sender, EventArgs e)
        {
            timerValue = Microsoft.VisualBasic.Interaction.InputBox("What is the new time you want to run each task at? (Enter in seconds)", "Enter timer value");
            if (Int64.TryParse(timerValue, out timerValue_long))
            {
                if (chkAutoRun.Checked)
                {
                    try
                    {
                        autoRunDeleteTime = (int)(timerValue_long / 0.001);
                        timeToStartTask.Interval = (int)(timerValue_long / 0.001);
                        GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime = autoRunDeleteTime;
                        lblRunTaskTime.Text = "Running Each Task: Every " + (GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime * 0.001) + " seconds";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please enter a number that is not bigger than 2100000!", "Error");
                    }
                }
                else
                {
                    timeToStartTask.Interval = (int)(timerValue_long / 0.001);
                    GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime = timeToStartTask.Interval;
                    lblRunTaskTime.Text = "Running Each Task: Manually";
                }
            }
            else if (timerValue.Equals(""))
            {
                
            }
            else
            {
                MessageBox.Show("Please enter a whole number!", "Error");
            }
        }


        private void btnModifyScriptTime_Click(object sender, EventArgs e)
        {
            scriptDeleteTime = Microsoft.VisualBasic.Interaction.InputBox("What is the new time you want to delete each generated script? (Enter in seconds)", "Enter script delete time value");
            if (Int64.TryParse(scriptDeleteTime, out scriptDeleteTime_long))
            {
                try
                {
                    formattedTime = (int) Int64.Parse(scriptDeleteTime);
                    GarrysModWorkshopUtil.Properties.Settings.Default.AutoDeleteScriptTime = formattedTime;
                    lblScriptDelete.Text = "Scripts Delete: " + GarrysModWorkshopUtil.Properties.Settings.Default.AutoDeleteScriptTime + " Seconds Upon Run";
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a number that is not bigger than 2100000!", "Error");
                }
            }
            else if (scriptDeleteTime.Equals(""))
            {
               
            }
            else
            {
                MessageBox.Show("Please enter a whole number!", "Error");
            }
        }

        private void btnResetResizePosition_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1286, 937);
        }


        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            conControl.ClearOutput();
        }

        private void btnClearAddons_Click(object sender, EventArgs e)
        {
            lstAddons.Items.Clear();
            lblLoadingProgress.Text = "Addon List Not Loaded";
        }


        private void btnLoadAddonList_Click(object sender, EventArgs e)
        {
            if (isProgramRunningGMPublish == false)
            {
                MessageBox.Show("You cannot run this task if your bin folder is looking at GMad.exe!", "Error");
            }
            else if (txtGMadFolderLocation.Text.Equals(""))
            {
                MessageBox.Show("Please enter in the path leading to GMPublish.exe!", "Error");
            }
            else
            {
                try
                {
                    forAddonList.Clear();
                    newStringList.Clear();
                    lstAddons.Items.Clear();
                    var processInfo = new ProcessStartInfo(txtGMadFolderLocation.Text, "list");
                    processInfo.CreateNoWindow = true;
                    processInfo.UseShellExecute = false;
                    processInfo.RedirectStandardError = true;
                    processInfo.RedirectStandardOutput = true;

                    var process = Process.Start(processInfo);
                    while (!process.StandardOutput.EndOfStream)
                    {
                        string line = process.StandardOutput.ReadLine();
                        newStringList.Add(line.Trim());
                    }
                    process.WaitForExit();
                    process.Close();
                    tmrFillAddons.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter in the proper path leading to GMPublish.exe!", "Error");
                }
            }
        }


        private void btnUseAddonID_Click(object sender, EventArgs e)
        {
            if (lstAddons.Items.Count == 0)
            {
                MessageBox.Show("You cannot use 0 ID's!", "Error");
            }
            else if (lstAddons.SelectedIndex < 0)
            {
                MessageBox.Show("You cannot select an unknown index!", "Error");
            }
            else
            {
                ArrayList addonList = new ArrayList();
                foreach (object item in lstAddons.Items)
                {
                    addonList.Add(item);
                }
                if (addonList[lstAddons.SelectedIndex].ToString().IndexOf(" ") != -1)
                {
                    txtAddonIDNumber.Text = addonList[lstAddons.SelectedIndex].ToString().Substring(0, 10).Trim();
                }
                else
                {
                    txtAddonIDNumber.Text = addonList[lstAddons.SelectedIndex].ToString().Substring(0, 11);
                }
            }
        }


        private void btnSearchAddon_Click(object sender, EventArgs e)
        {
            if (txtSearchAddon.Text.Equals(""))
            {
                MessageBox.Show("You cannot search for nothing!", "Error");
            }
            else if (lstAddons.Items.Count == 0 || newStringList.Count == 0)
            {
                MessageBox.Show("You cannot use this until you load the addon list!", "Error");
            }
            else
            {
                String input = txtSearchAddon.Text;
                ArrayList wordsWithSearch = new ArrayList();
                lstAddons.Items.Clear();
                int index = 0;
                foreach (String line in forAddonList)
                {
                    if (line.Contains(input))
                    {
                        wordsWithSearch.Add(line.Trim());
                        lstAddons.Items.Add((string)wordsWithSearch[index]);
                        index++;
                    }
                }
            }
        }


        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            bool allowedToClearSearch = false;
            if (newStringList.Count == 0)
            {
                MessageBox.Show("You cannot use this until you load the addon list!", "Error");
            }
            else if (!txtGMadFolderLocation.Text.Contains("gmpublish.exe"))
            {
                MessageBox.Show("You cannot use this if your program is looking at GMad.exe!", "Error");
            }
            else if (txtSearchAddon.Text.Equals("") && lstAddons.Items.Count != 0)
            {
                MessageBox.Show("You cannot clear an empty search!", "Error");
            }
            else
            {
                txtSearchAddon.Text = "";
                lblLoadingProgress.Text = "Addon List Not Loaded";
                lstAddons.Items.Clear();
                newStringList.Clear();
                forAddonList.Clear();
            }
        }

        private void btnViewDeletedTasks_Click(object sender, EventArgs e)
        {
            if (GarrysModWorkshopUtil.PastTasks.taskWindowIsOpen == true)
            {

            }
            else
            {
                GarrysModWorkshopUtil.PastTasks pastTasks = new GarrysModWorkshopUtil.PastTasks(allTasks, this);
                pastTasks.Show();
            }
        }

        private void radCreateGma_CheckedChanged(object sender, EventArgs e)
        {
            startProgramEffects();
            isProgramRunningGMPublish = false;
        }

        private void radPublishAddon_CheckedChanged(object sender, EventArgs e)
        {
            if (autoDeleteText == true && chkUseDefLoc.Checked == false)
            {
                txtGMadFolderLocation.Text = "";
            }
            checkForPublishOrCreateExe();
            changeGMExeButtonBasedOnChoice();
            changeBinFolderBasedOnChoice();
            enableIconFolderFunction();
            enableBinFunction();
            enableGMAFunction();
            disableAddonIDFunction();
            disableJSONFunction();
            disableGMAOutputFunction();
            disableAddonFolderFunction();
            isProgramRunningGMPublish = true;
        }

        private void radUpdateAddon_CheckedChanged(object sender, EventArgs e)
        {
            if (autoDeleteText == true && chkUseDefLoc.Checked == false)
            {
                txtGMadFolderLocation.Text = "";
            }
            checkForPublishOrCreateExe();
            changeGMExeButtonBasedOnChoice();
            changeBinFolderBasedOnChoice();
            enableAddonFolderFunction();
            enableAddonIDFunction();
            enableGMAFunction();
            enableBinFunction();
            disableIconFolderFunction();
            disableGMAOutputFunction();
            disableJSONFunction();
            disableAddonFolderFunction();
            isProgramRunningGMPublish = true;
        }

        private void radUpdateIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (autoDeleteText == true && chkUseDefLoc.Checked == false)
            {
                txtGMadFolderLocation.Text = "";
            }
            checkForPublishOrCreateExe();
            changeGMExeButtonBasedOnChoice();
            changeBinFolderBasedOnChoice();
            enableAddonIDFunction();
            enableIconFolderFunction();
            enableBinFunction();
            disableGMAOutputFunction();
            disableAddonFolderFunction();
            disableGMAFunction();
            disableJSONFunction();
            isProgramRunningGMPublish = true;
        }

        private void radCreateJSon_CheckedChanged(object sender, EventArgs e)
        {
            if (autoDeleteText == true && chkUseDefLoc.Checked == false)
            {
                txtGMadFolderLocation.Text = "";
            }
            checkForPublishOrCreateExe();
            changeGMExeButtonBasedOnChoice();
            changeBinFolderBasedOnChoice();
            disableAddonIDFunction();
            disableAddonFolderFunction();
            disableIconFolderFunction();
            disableGMAOutputFunction();
            disableGMAFunction();
            disableBinFunction();
            enableJSONFunction();
            isProgramRunningGMPublish = false;
        }

        private void radExtractGMA_CheckedChanged(object sender, EventArgs e)
        {
            checkForPublishOrCreateExe();
            changeGMExeButtonBasedOnChoice();
            changeBinFolderBasedOnChoice();
            btnFolderLocation.Text = "Addon Output";
            if (autoDeleteText == true && chkUseDefLoc.Checked == false)
            {
                txtGMadFolderLocation.Text = "";
            }
            disableAddonIDFunction();
            disableIconFolderFunction();
            disableJSONFunction();
            disableGMAOutputFunction();
            enableAddonFolderFunction();
            enableBinFunction();
            enableGMAFunction();
            isProgramRunningGMPublish = false;
        }

        private void checkForPublishOrCreateExe()
        {
            if (radCreateGma.Checked || radExtractGMA.Checked)
            {
                exeName = "gmad.exe";
            }
            else
            {
                exeName = "gmpublish.exe";
            }
        }

        private void changeGMExeButtonBasedOnChoice()
        {
            if (radCreateJSon.Checked == true || exeName.Equals("gmad.exe"))
            {
                btnGmadFolder.Text = "GMad.EXE Location";
            }
            else if ( exeName.Equals("gmpublish.exe"))
            {
                btnGmadFolder.Text = "GMPublish.EXE Location";
            }
        }

        private void changeBinFolderBasedOnChoice()
        {
            try
            {
                if (exeName.Equals("gmad.exe"))
                {
                    if (!(txtGMadFolderLocation.Text.Equals("")))
                    {
                        txtGMadFolderLocation.Text = txtGMadFolderLocation.Text.Substring(0, txtGMadFolderLocation.Text.LastIndexOf("\\")) + "\\gmad.exe";
                    }
                }
                else if (exeName.Equals("gmpublish.exe"))
                {
                    if (!(txtGMadFolderLocation.Text.Equals("")))
                    {
                        txtGMadFolderLocation.Text = txtGMadFolderLocation.Text.Substring(0, txtGMadFolderLocation.Text.LastIndexOf("\\")) + "\\gmpublish.exe";
                    }
                }
            }
            
            catch (Exception)
            {

            }
        }

        private void updateIconPreview()
        {
            if (txtIconFolderLocation.Text.Equals(""))
            {

            }
            else
            {
                try
                {
                    Image newImg = Image.FromFile(txtIconFolderLocation.Text);
                    pboxIconPreview.Image = newImg;
                }

                catch (Exception)
                {
                    
                }
            }
        }

        private void startProgramEffects()
        {
            checkForPublishOrCreateExe();
            changeGMExeButtonBasedOnChoice();
            btnFolderLocation.Text = "Addon Input";
            enableAddonFolderFunction();
            enableBinFunction();
            enableGMAOutputFunction();
            disableAddonIDFunction();
            disableIconFolderFunction();
            disableJSONFunction();
            disableGMAFunction();
        }

        private void disableGMAFunction() {
            btnGMALocation.Enabled = false;
            txtGMALocation.Enabled = false;
            if (autoDeleteText == true)
            {
                txtGMALocation.Text = "";
            }
        }

        private void enableGMAFunction()
        {
            btnGMALocation.Enabled = true;
            txtGMALocation.Enabled = true;
        }

        private void disableAddonIDFunction()
        {
            btnAddonID.Enabled = false;
            txtAddonIDNumber.Enabled = false;
            if (autoDeleteText == true)
            {
                txtAddonIDNumber.Text = "";
            }
        }

        private void enableAddonIDFunction()
        {
            btnAddonID.Enabled = true;
            txtAddonIDNumber.Enabled = true;
        }

        private void disableAddonFolderFunction() 
        {
            btnFolderLocation.Enabled = false;
            txtAddonFolderLocation.Enabled = false;
            if (autoDeleteText == true)
            {
                txtAddonFolderLocation.Text = "";
            }
        }

        private void enableAddonFolderFunction()
        {
            btnFolderLocation.Enabled = true;
            txtAddonFolderLocation.Enabled = true;
        }

        private void disableIconFolderFunction()
        {
            btnIconFolder.Enabled = false;
            txtIconFolderLocation.Enabled = false;
            if (autoDeleteText == true)
            {
                txtIconFolderLocation.Text = "";
            }
        }

        private void enableIconFolderFunction()
        {
            btnIconFolder.Enabled = true;
            txtIconFolderLocation.Enabled = true;
        }

        private void disableBinFunction()
        {
            btnGmadFolder.Enabled = false;
            txtGMadFolderLocation.Enabled = false;
            if (autoDeleteText == true && chkUseDefLoc.Checked == false)
            {
                txtGMadFolderLocation.Text = "";
            }
        }

        private void enableBinFunction()
        {
            btnGmadFolder.Enabled = true;
            txtGMadFolderLocation.Enabled = true;
        }

        private void disableJSONFunction()
        {
            btnDirectoryOfJSon.Enabled = false;
            txtDirectoryOfJSon.Enabled = false;
            if (autoDeleteText == true)
            {
                txtDirectoryOfJSon.Text = "";
            }
        }

        private void enableJSONFunction()
        {
            btnDirectoryOfJSon.Enabled = true;
            txtDirectoryOfJSon.Enabled = true;
        }

        private void disableGMAOutputFunction()
        {
            btnGMAOutput.Enabled = false;
            txtGMAOutput.Enabled = false;
            if (autoDeleteText == true)
            {
                txtGMAOutput.Text = "";
            }
        }

        private void enableGMAOutputFunction()
        {
            btnGMAOutput.Enabled = true;
            txtGMAOutput.Enabled = true;
        }

        private void makeControlsTransparent()
        {
            lblRunTaskTime.BackColor = System.Drawing.Color.Transparent;
            lblScriptDelete.BackColor = System.Drawing.Color.Transparent;
            lblConsoleText.BackColor = System.Drawing.Color.Transparent;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblQueue.BackColor = System.Drawing.Color.Transparent;
            lblUtilityOptions.BackColor = System.Drawing.Color.Transparent;
            lblIconPreview.BackColor = System.Drawing.Color.Transparent;
            lblCommandPrompts.BackColor = System.Drawing.Color.Transparent;
            chkAutoRun.BackColor = System.Drawing.Color.Transparent;
            chkClearText.BackColor = System.Drawing.Color.Transparent;
            chkDarkMode.BackColor = System.Drawing.Color.Transparent;
            chkEnableAutoDeleteJSON.BackColor = System.Drawing.Color.Transparent;
            chkIgnoreNotices.BackColor = System.Drawing.Color.Transparent;
            chkToggleResizing.BackColor = System.Drawing.Color.Transparent;
            radCreateGma.BackColor = System.Drawing.Color.Transparent;
            radCreateJSon.BackColor = System.Drawing.Color.Transparent;
            radExtractGMA.BackColor = System.Drawing.Color.Transparent;
            radPublishAddon.BackColor = System.Drawing.Color.Transparent;
            radUpdateAddon.BackColor = System.Drawing.Color.Transparent;
            radUpdateIcon.BackColor = System.Drawing.Color.Transparent;
        }

        private void saveUserInput()
        {
            GarrysModWorkshopUtil.Properties.Settings.Default.AddonPath = txtAddonFolderLocation.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.JSONPath = txtDirectoryOfJSon.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.GMAPath = txtGMALocation.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.BinFolderPath = txtGMadFolderLocation.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.IconPath = txtIconFolderLocation.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.AddonID = txtAddonIDNumber.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.ImagePath = txtIconFolderLocation.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.GMAOutputPath = txtGMAOutput.Text;
            //GarrysModWorkshopUtil.Properties.Settings.Default.AddonJSONName = //txtAddonJSONName.Text;
            GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime = autoRunDeleteTime;
            GarrysModWorkshopUtil.Properties.Settings.Default.AutoDeleteScriptTime = formattedTime;

            if (radCreateGma.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.ButtonClicked = 1;
            }

            else if (radCreateJSon.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.ButtonClicked = 2;
            }

            else if (radExtractGMA.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.ButtonClicked = 3;
            }


            else if (radPublishAddon.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.ButtonClicked = 4;
            }

            else if (radUpdateAddon.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.ButtonClicked = 5;
            }

            else if (radUpdateIcon.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.ButtonClicked = 6;
            }

            if (chkUseDefLoc.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableStandardExePath = true;
            }

            else
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableStandardExePath = false;
            }

            if (chkIgnoreNotices.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.IgnoreNoticeChecked = true;
            }

            else
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.IgnoreNoticeChecked = false;
            }

            if (chkAutoRun.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskChecked = true;
            }

            else
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskChecked = false;
            }

            if (chkEnableAutoDeleteJSON.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableAutoDeleteJSONChecked = true;
            }

            else
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableAutoDeleteJSONChecked = false;
            }

            if (chkClearText.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableClearingInputChecked = true;
            }

            else
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableClearingInputChecked = false;
            }


            if (chkToggleResizing.Checked)
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableResizingChecked = true;
            }

            else
            {
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableResizingChecked = false;
            }

            GarrysModWorkshopUtil.Properties.Settings.Default.Save();
        }

        private void loadUserInput()
        {
            switch (GarrysModWorkshopUtil.Properties.Settings.Default.ButtonClicked)
            {
                case 1:
                    radCreateGma.Checked = true;
                    break;
                case 2:
                    radCreateJSon.Checked = true;
                    break;
                case 3:
                    radExtractGMA.Checked = true;
                    break;
                case 4:
                    radPublishAddon.Checked = true;
                    break;
                case 5:
                    radUpdateAddon.Checked = true;
                    break;
                case 6:
                    radUpdateIcon.Checked = true;
                    break;
                default:
                    radCreateGma.Checked = true;
                    break;
            }

            if (GarrysModWorkshopUtil.Properties.Settings.Default.EnableStandardExePath == true)
            {
                chkUseDefLoc.Checked = true;
            }

            else
            {
                chkUseDefLoc.Checked = false;
            }

            if (GarrysModWorkshopUtil.Properties.Settings.Default.IgnoreNoticeChecked == true)
            {
                chkIgnoreNotices.Checked = true;
            }

            else
            {
                chkIgnoreNotices.Checked = false;
            }

            if (GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskChecked == true)
            {
                chkAutoRun.Checked = true;
                btnModifyTimer.Enabled = true;
            }

            else
            {
                chkAutoRun.Checked = false;
            }

            if (GarrysModWorkshopUtil.Properties.Settings.Default.EnableAutoDeleteJSONChecked == true)
            {
                chkEnableAutoDeleteJSON.Checked = true;
            }

            else
            {
                chkEnableAutoDeleteJSON.Checked = false;
            }

            if (GarrysModWorkshopUtil.Properties.Settings.Default.EnableClearingInputChecked == true)
            {
                chkClearText.Checked = true;
            }

            else
            {
                chkClearText.Checked = false;
            }

            if (GarrysModWorkshopUtil.Properties.Settings.Default.EnableDarkMode == true)
            {
                chkDarkMode.Checked = true;
            }

            else
            {
                chkDarkMode.Checked = false;
            }

            if (GarrysModWorkshopUtil.Properties.Settings.Default.EnableResizingChecked == true)
            {
                chkToggleResizing.Checked = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }

            else
            {
                chkToggleResizing.Checked = false;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }

            txtAddonFolderLocation.Text = GarrysModWorkshopUtil.Properties.Settings.Default.AddonPath;
            txtDirectoryOfJSon.Text = GarrysModWorkshopUtil.Properties.Settings.Default.JSONPath;
            txtGMALocation.Text = GarrysModWorkshopUtil.Properties.Settings.Default.GMAPath;
            txtGMadFolderLocation.Text  = GarrysModWorkshopUtil.Properties.Settings.Default.BinFolderPath;
            txtIconFolderLocation.Text = GarrysModWorkshopUtil.Properties.Settings.Default.IconPath;
            txtGMAOutput.Text = GarrysModWorkshopUtil.Properties.Settings.Default.GMAOutputPath;
            txtAddonIDNumber.Text = GarrysModWorkshopUtil.Properties.Settings.Default.AddonID;
            //txtAddonJSONName.Text = GarrysModWorkshopUtil.Properties.Settings.Default.AddonJSONName;
            autoRunDeleteTime = GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime;
            formattedTime = GarrysModWorkshopUtil.Properties.Settings.Default.AutoDeleteScriptTime;
            updateIconPreview();
        }

        public ArrayList getAllTasks()
        {
            return allTasks;
        }

        public void receiveTaskInfo(GarrysModWorkshopUtility.frmGarrysModWorkshopUtility form, int choice)
        {
            switch (choice)
            {
                case 1:
                    txtDirectoryOfJSon.Text = form.jsonOutputLocation;
                    break;
                case 2:
                    txtGMAOutput.Text = form.gmaOutputLocation;
                    txtAddonFolderLocation.Text = form.addonInput;
                    txtGMadFolderLocation.Text = form.exeFolderLocation;
                    if (form.deleingJSON == true)
                    {
                        chkEnableAutoDeleteJSON.Checked = true;
                    }
                    else
                    {
                        chkEnableAutoDeleteJSON.Checked = false;
                    }
                    break;
                case 3:
                    txtGMAOutput.Text = form.gmaOutputLocation;
                    txtAddonFolderLocation.Text = form.addonInput;
                    txtGMadFolderLocation.Text = form.exeFolderLocation;
                    break;
                case 4:
                    txtGMALocation.Text = form.addonInput;
                    txtGMadFolderLocation.Text = form.exeFolderLocation;
                    txtIconFolderLocation.Text = form.iconLocation;
                    break;
                case 5:
                    txtAddonFolderLocation.Text = form.addonInput;
                    txtGMadFolderLocation.Text = form.exeFolderLocation;
                    txtAddonIDNumber.Text = form.addonID.ToString();
                    break;
                case 6:
                    txtIconFolderLocation.Text = form.iconLocation;
                    txtGMadFolderLocation.Text = form.exeFolderLocation;
                    txtAddonIDNumber.Text = form.addonID.ToString();
                    break;
            }
        }

        private void frmGarrysModWorkshopUtility_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveUserInput();
        }


        private void chkUseDefLoc_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkUseDefLoc.Checked)
            {
                String programName = "";
                String oldExeLocation = txtGMadFolderLocation.Text;
                if (radCreateGma.Checked || radExtractGMA.Checked)
                {
                    programName = "gmad.exe";
                }
                else
                {
                    programName = "gmpublish.exe";
                }
                oldExeLocation = txtGMadFolderLocation.Text;
                txtGMadFolderLocation.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\GarrysMod\\bin\\" + programName;
                txtGMadFolderLocation.ReadOnly = true;
            }
            else
            {
                txtGMadFolderLocation.ReadOnly = false;
            }
        }

        private void chkAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoRun.Checked)
            {
                timeToStartTask.Start();
                lblRunTaskTime.Text = "Running Each Task: Every " + (GarrysModWorkshopUtil.Properties.Settings.Default.AutoRunTaskTime * 0.001) + " seconds";
                btnRunTask.Enabled = false;
                btnModifyTimer.Enabled = true;
            }
            else
            {
                timeToStartTask.Stop();
                lblRunTaskTime.Text = "Running Each Task: Manually";
                btnRunTask.Enabled = true;
                btnModifyTimer.Enabled = false;
            }
        }

        private void timeToStartTask_Tick(object sender, EventArgs e)
        {
            if (lstQueue.Items.Count <= 0)
            {

            }
            else
            {
                if (GarrysModWorkshopUtil.Task.taskIsRunning == true)
                {

                }

                else
                {
                    GarrysModWorkshopUtil.Task testTask = (GarrysModWorkshopUtil.Task)tasks[0];

                    if (testTask.getName().Equals("Create .GMA"))
                    {
                        testTask.createGMAFunction();
                        conControl.StartProcess(testTask.getCommand(), "");
                        testTask.deleteScript("gmod_util_create_gma.bat", 1);
                        lstQueue.Items.RemoveAt(0);
                    }

                    else if (testTask.getName().Equals("Create .JSON"))
                    {
                        testTask.createJSONFunction();
                        lstQueue.Items.RemoveAt(0);
                    }

                    else if (testTask.getName().Equals("Extract .GMA"))
                    {
                        testTask.extractGMAFunction();
                        conControl.StartProcess(testTask.getCommand(), "");
                        testTask.deleteScript("gmod_util_extract_gma.bat", 0);
                        lstQueue.Items.RemoveAt(0);
                    }

                    else if (testTask.getName().Equals("Publish Addon"))
                    {
                        testTask.publishAddonFunction();
                        conControl.StartProcess(testTask.getCommand(), "");
                        testTask.deleteScript("gmod_util_publish.bat", 0);
                        lstQueue.Items.RemoveAt(0);
                    }

                    else if (testTask.getName().Equals("Update Addon"))
                    {
                        testTask.updateAddonFunction();
                        conControl.StartProcess(testTask.getCommand(), "");
                        testTask.deleteScript("gmod_util_update_addon.bat", 0);
                        lstQueue.Items.RemoveAt(0);
                    }

                    else if (testTask.getName().Equals("Update Icon"))
                    {
                        testTask.updateIconFunction();
                        conControl.StartProcess(testTask.getCommand(), "");
                        testTask.deleteScript("gmod_util_update_icon.bat", 0);
                        lstQueue.Items.RemoveAt(0);
                    }

                    tasks.RemoveAt(0);
                }
            }
        }


        private void tmrFillAddons_Tick(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                foreach (String line in newStringList)
                {
                    if (index < 5)
                    {

                    }
                    else
                    {
                        lstAddons.Items.Add(line.Trim());
                        forAddonList.Add(line.Trim());
                    }
                    index++;
                }
                lstAddons.Items.RemoveAt(lstAddons.Items.Count - 1);
                lstAddons.Items.RemoveAt(lstAddons.Items.Count - 1);
                forAddonList.RemoveAt(forAddonList.Count - 1);
                forAddonList.RemoveAt(forAddonList.Count - 1);
                lblLoadingProgress.Text = "Addon List Loaded!";
                tmrFillAddons.Stop();
            }
            catch (Exception)
            {
                lblLoadingProgress.Text = "Error Loading List!";
                tmrFillAddons.Stop();
            }
            
        }

        private void chkIgnoreNotices_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIgnoreNotices.Checked)
            {
                ignoreNotices = true;
            }

            else
            {
                ignoreNotices = false;
            }
        }

        private void chkToggleResizing_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToggleResizing.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MaximizeBox = true;
            }

            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
            }
        }

        private void chkEnableAutoDeleteJSON_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableAutoDeleteJSON.Checked)
            {
                preventDeletingAddonJSON = true;
            }

            else
            {
                preventDeletingAddonJSON = false;
            }
        }

        private void chkClearText_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClearText.Checked)
            {
                autoDeleteText = true;
            }

            else
            {
                autoDeleteText = false;
            }
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                this.BackColor = System.Drawing.Color.DimGray;
                lstQueue.BackColor = System.Drawing.Color.DimGray;
                lstQueue.ForeColor = SystemColors.Window;
                lstAddons.BackColor = System.Drawing.Color.DimGray;
                lstAddons.ForeColor = SystemColors.Window;
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableDarkMode = true;
            }

            else
            {
                this.BackColor = SystemColors.Control;
                lstQueue.BackColor = SystemColors.Window;
                lstAddons.BackColor = SystemColors.Window;
                lstAddons.ForeColor = System.Drawing.Color.Black;
                lstQueue.ForeColor = System.Drawing.Color.Black;
                GarrysModWorkshopUtil.Properties.Settings.Default.EnableDarkMode = false;
            }
        }
    }
}
