using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GarrysModWorkshopUtil
{
    public partial class PastTasks : Form
    {
        public ArrayList allTasks;
        public GarrysModWorkshopUtility.frmGarrysModWorkshopUtility sendBackToMain;

        public static bool taskWindowIsOpen = false;

        public PastTasks(ArrayList tasks, GarrysModWorkshopUtility.frmGarrysModWorkshopUtility form)
        {
            InitializeComponent();
            allTasks = tasks;
            sendBackToMain = form;
        }

        private void frmPastTasks_Load(object sender, EventArgs e)
        {
            taskWindowIsOpen = true;
            foreach (GarrysModWorkshopUtil.Task task in allTasks)
            {
                lstDeletedTasks.Items.Add(task);
            }
        }

        private void PastTasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            taskWindowIsOpen = false;
        }

        private void btnPermanentlyDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstDeletedTasks.SelectedIndex < 0 || lstDeletedTasks.SelectedIndex > lstDeletedTasks.Items.Count)
            {
                MessageBox.Show("Please select a valid task in the list!", "Error");
            }
        }

        private void btnViewTask_Click(object sender, EventArgs e)
        {
            if (lstDeletedTasks.Items.Count == 0)
            {
                MessageBox.Show("You cannot view an empty list!", "Error");
            }
            else if (lstDeletedTasks.SelectedIndex < 0 || lstDeletedTasks.SelectedIndex > lstDeletedTasks.Items.Count)
            {
                MessageBox.Show("Please select a valid task in the list!", "Error");
            }
            else
            {
                GarrysModWorkshopUtil.Task testTask = (GarrysModWorkshopUtil.Task)allTasks[lstDeletedTasks.SelectedIndex];
                if (testTask.getName().Equals("Create .JSON"))
                {
                    string wildcards = "";
                    if (testTask.wildCards.Count == 0)
                    {
                        foreach (String wildcard in testTask.wildCards)
                        {
                            wildcards += wildcard.ToString() + ",";
                        }
                        wildcards = wildcards.Substring(0, wildcards.LastIndexOf(","));
                    }

                    MessageBox.Show("Addon Output: " + testTask.jsonLocation + "\n\nAddon Title: " + testTask.addonTitle + "\n\nAddon Type: " + testTask.addonType + "\n\nAddon Tags: " + testTask.addonTag1 + " & " + testTask.addonTag2 + "\n\nWildcards: " + wildcards + "\n\nNotes: " + testTask.TaskNotes, "Create JSON Task Info");
                }
                else if (testTask.getName().Equals("Create .GMA"))
                {
                    MessageBox.Show("Addon Input: " + testTask.addonLocation + "\n\nGMad.EXE Location: " + testTask.gMadLocation + "\n\nGMA Filename: " + testTask.gmaName + "\n\nGMA Output: " + testTask.gmaOutput + "\n\nWanted to Delete JSON? " + testTask.wantsToDeleteJSON + "\n\nNotes: " + testTask.TaskNotes, "Create .GMA Task Info");
                }
                else if (testTask.getName().Equals("Extract .GMA"))
                {
                    MessageBox.Show("Addon Output: " + testTask.addonLocation + "\n\nGMad.EXE Location: " + testTask.gMadLocation + "\n\nGMA Filename: " + testTask.gmaName + "\n\nGMA Location: " + testTask.gmaLocation + "\n\nNotes: " + testTask.TaskNotes, "Extract .GMA Task Info");
                }
                else if (testTask.getName().Equals("Publish Addon"))
                {
                    MessageBox.Show("Icon Location: " + testTask.iconLocation + "\n\nGMPublish.EXE Location: " + testTask.gMadLocation + "\n\nGMA Filename: " + testTask.gmaName + "\n\nGMA Location: " + testTask.gmaLocation + "\n\nNotes: " + testTask.TaskNotes, "Publish Addon Task Info");
                }
                else if (testTask.getName().Equals("Update Addon"))
                {
                    MessageBox.Show("GMPublish.EXE Location: " + testTask.gMadLocation + "\n\nGMA Filename: " + testTask.gmaName + "\n\nGMA Location: " + testTask.gmaLocation + "\n\nAddon ID: " + testTask.addonID + "\n\nChange Notes: " + testTask.changeNotes + "\n\nNotes: " + testTask.TaskNotes, "Update Addon Task Info");
                }
                else if (testTask.getName().Equals("Update Icon"))
                {
                    MessageBox.Show("Icon Location: " + testTask.iconLocation + "\n\nGMPublish.EXE Location: " + testTask.gMadLocation + "\n\nAddon ID: " + testTask.addonID + "\n\nNotes: " + testTask.TaskNotes, "Update Addon Task Info");
                }
            }
        }

        private void btnDelSectTask_Click(object sender, EventArgs e)
        {
            int index;
            if (lstDeletedTasks.Items.Count == 0 && (lstDeletedTasks.SelectedIndex > 0 && lstDeletedTasks.SelectedIndex < lstDeletedTasks.Items.Count))
            {
                index = 0;
            }
            else if (lstDeletedTasks.SelectedIndex < 0 || lstDeletedTasks.SelectedIndex > lstDeletedTasks.Items.Count)
            {
                MessageBox.Show("Please select a valid task in the list to delete!", "Error");
            }
            else
            {
                String choice = Microsoft.VisualBasic.Interaction.InputBox("Are you sure you want to delete this task? (Type \"y\" for yes or \"n\" for no, press the X to cancel the removal) ", "Notice");
                choice = choice.ToLower();
                if (choice.Equals("y"))
                {
                    int delIndex = lstDeletedTasks.SelectedIndex;
                    lstDeletedTasks.Items.RemoveAt(delIndex);
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

        private void btnDelAllTasks_Click(object sender, EventArgs e)
        {
            if (lstDeletedTasks.Items.Count == 0)
            {
                MessageBox.Show("You cannot delete tasks from an empty list!", "Error");
            }
            else
            {
                String choice = Microsoft.VisualBasic.Interaction.InputBox("Are you sure you want to delete all tasks? (Type \"y\" for yes or \"n\" for no, press the X to cancel the removal) ", "Notice");
                choice = choice.ToLower();
                if (choice.Equals("y"))
                {
                    int delIndex = lstDeletedTasks.SelectedIndex;
                    lstDeletedTasks.Items.Clear();
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
        }

        private void btnUseTask_Click(object sender, EventArgs e)
        {
            int choice = 0;
            if (lstDeletedTasks.Items.Count == 0)
            {
                MessageBox.Show("You cannot select from an empty list!", "Error");
            }
            else if (lstDeletedTasks.SelectedIndex < 0 || lstDeletedTasks.SelectedIndex > lstDeletedTasks.Items.Count)
            {
                MessageBox.Show("Please select a valid task in the list!", "Error");
            }
            else
            {
                GarrysModWorkshopUtil.Task testTask = (GarrysModWorkshopUtil.Task)allTasks[lstDeletedTasks.SelectedIndex];
                if (testTask.getName().Equals("Create .JSON"))
                {
                    sendBackToMain.jsonOutputLocation = testTask.jsonLocation;
                    choice = 1;
                }
                else if (testTask.getName().Equals("Create .GMA"))
                {
                    sendBackToMain.gmaOutputLocation = testTask.gmaOutput;
                    sendBackToMain.addonInput = testTask.addonLocation;
                    sendBackToMain.deleingJSON = testTask.wantsToDeleteJSON;
                    sendBackToMain.exeFolderLocation = testTask.gMadLocation;
                    choice = 2;
                }
                else if (testTask.getName().Equals("Extract .GMA"))
                {
                    sendBackToMain.gmaOutputLocation = testTask.gmaLocation;
                    sendBackToMain.addonInput = testTask.addonLocation;
                    sendBackToMain.exeFolderLocation = testTask.gMadLocation;
                    choice = 3;
                }
                else if (testTask.getName().Equals("Publish Addon"))
                {
                    sendBackToMain.iconLocation = testTask.iconLocation;
                    sendBackToMain.exeFolderLocation = testTask.gMadLocation;
                    sendBackToMain.addonInput = testTask.gmaLocation;
                    choice = 4;
                }
                else if (testTask.getName().Equals("Update Addon"))
                {
                    sendBackToMain.addonInput = testTask.gmaLocation;
                    sendBackToMain.exeFolderLocation = testTask.gMadLocation;
                    sendBackToMain.addonID = testTask.addonID;
                    choice = 5;
                }
                else if (testTask.getName().Equals("Update Icon"))
                {
                    sendBackToMain.iconLocation = testTask.iconLocation;
                    sendBackToMain.exeFolderLocation = testTask.gMadLocation;
                    sendBackToMain.addonID = testTask.addonID;
                    choice = 6;
                }
            }

            sendBackToMain.receiveTaskInfo(sendBackToMain, choice);
        }
    }
}
