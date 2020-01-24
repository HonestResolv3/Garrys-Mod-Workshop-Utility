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
        public Form sendBackToMain;

        public static bool taskWindowIsOpen = false;

        public PastTasks(ArrayList tasks)
        {
            InitializeComponent();
            allTasks = tasks;
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
            if (lstDeletedTasks.SelectedIndex < 0 || lstDeletedTasks.SelectedIndex > lstDeletedTasks.Items.Count)
            {
                MessageBox.Show("Please select a valid task in the list!", "Error");
            }
            else
            {
                GarrysModWorkshopUtil.Task testTask = (GarrysModWorkshopUtil.Task)allTasks[0];
                if (testTask.getName().Equals("Create .JSON"))
                {
                    string wildcards = "";
                    foreach (String wildcard in testTask.wildCards)
                    {
                        wildcards += wildcard.ToString() + ",";
                    }
                    wildcards = wildcards.Substring(0, wildcards.LastIndexOf(","));
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
                    MessageBox.Show("GMPublish.EXE Location: " + testTask.gMadLocation + "\n\nGMA Filename: " + testTask.gmaName + "\n\nGMA Location: " + testTask.gmaLocation + "\n\nAddon ID: " + testTask.addonID + "\n\nChange Notes" + testTask.changeNotes + "\n\nNotes: " + testTask.TaskNotes, "Update Addon Task Info");
                }
                else if (testTask.getName().Equals("Update Icon"))
                {
                    MessageBox.Show("Icon Location: " + testTask.iconLocation + "\n\nGMPublish.EXE Location: " + testTask.gMadLocation + "\n\nAddon ID: " + testTask.addonID + "\n\nNotes: " + testTask.TaskNotes, "Update Addon Task Info");
                }
            }
        }
    }
}
