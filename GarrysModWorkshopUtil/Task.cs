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
using System.Diagnostics;
using GarrysModWorkshopUtility;

namespace GarrysModWorkshopUtil
{
    class Task
    {
        public static bool taskIsRunning;
        private bool wantsToDeleteJSON;
        private String addonLocation;
        private String gMadLocation;
        private String gmaLocation;
        private String gmaName;
        private String gmaOutput;
        private String iconLocation;
        private String TaskName;
        private String TaskNotes;
        private string Command;
        private String jsonLocation;
        private String addonTitle;
        private String addonTag1;
        private String addonTag2;
        private String addonType;
        private String changeNotes;
        private int addonID;
        private ArrayList wildCards;

        public Task(String json, String title, String tag1, String tag2, String type, ArrayList ignoreWildcards, String taskNote)
        {
            jsonLocation = json;
            TaskName = "Create .JSON";
            TaskNotes = taskNote;
            addonTitle = title;
            addonTag1 = tag1;
            addonTag2 = tag2;
            addonType = type;
            wildCards = ignoreWildcards;
        }

        public Task(String addon, String gmad, String GMAName, String taskNote, String output, bool deleteJSON)
        {
            addonLocation = addon;
            gMadLocation = gmad;
            gmaName = GMAName;
            gmaOutput = output;
            TaskName = "Create .GMA";
            TaskNotes = taskNote;
            wantsToDeleteJSON = deleteJSON;
        }

        public Task(String addon, String gmad, String gmaLoc, String fileName, String taskNote)
        {
            addonLocation = addon;
            gMadLocation = gmad;
            gmaLocation = gmaLoc;
            gmaName = fileName;
            TaskName = "Extract .GMA";
            TaskNotes = taskNote;
        }

        public Task(String icon, String gmad, String gmaLoc, int dupeConstProtector, String taskNote)
        {
            iconLocation = icon;
            gMadLocation = gmad;
            gmaLocation = gmaLoc;
            TaskName = "Publish Addon";
            TaskNotes = taskNote;
        }

        public Task(String gmad, String gmaLoc, int id, String notes, String taskNote)
        {
            gMadLocation = gmad;
            gmaLocation = gmaLoc;
            addonID = id;
            changeNotes = notes;
            TaskName = "Update Addon";
            TaskNotes = taskNote;
        }

        public Task(String icon, String gmad, int id, String taskNote)
        {
            iconLocation = icon;
            gMadLocation = gmad;
            addonID = id;
            TaskName = "Update Icon";
            TaskNotes = taskNote;
        }

        public void createJSONFunction()
        {
            int counter = 0;
            StreamWriter scriptWriter = new StreamWriter(jsonLocation + "\\addon.json");
            scriptWriter.WriteLine("{");
            scriptWriter.WriteLine("\t\"title\": \"" + addonTitle + "\",");
            scriptWriter.WriteLine("\t\"type\": \"" + addonType + "\",");
            scriptWriter.WriteLine("\t\"tags\": [\"" + addonTag1 + "\", \"" + addonTag2 + "\"],");
            scriptWriter.WriteLine("\t\"ignore\":");
            scriptWriter.WriteLine("\t[");
            foreach (String wildcard in wildCards)
            {
                if (counter == wildCards.Count - 1)
                {
                    scriptWriter.WriteLine("\t\t\"" + wildcard + "\"");
                }
                else
                {
                    scriptWriter.WriteLine("\t\t\"" + wildcard + "\",");
                }
                counter++;
            }
            scriptWriter.WriteLine("\t]");
            scriptWriter.WriteLine("}");
            scriptWriter.Close();
        }

        public void createGMAFunction()
        {
            if (Directory.Exists(gmaOutput) == false)
            {
                Directory.CreateDirectory(gmaOutput);
            }
            Command = "\"" + gMadLocation + "\"" + " create -folder \"" + addonLocation + "\" -out \"" + gmaOutput + "\\" + gmaName + ".gma" + "\"";
        }

        public void extractGMAFunction()
        {
            Directory.CreateDirectory(addonLocation + "\\" + gmaName.Substring(0, gmaName.IndexOf(".")));
            String newOutputFolder = addonLocation + "\\" + gmaName.Substring(0, gmaName.IndexOf("."));
            Command = "\"" + gMadLocation + "\"" + " extract -file \"" + gmaLocation + "\" -out \"" + newOutputFolder + "\"";
        }

        public void publishAddonFunction()
        {
            Command = "\"" + gMadLocation + "\"" + " create -addon \"" + gmaLocation + "\" -icon \"" + iconLocation + "\"";
        }

        public void updateAddonFunction()
        {
            Command = "\"" + gMadLocation + "\"" + " update -addon \"" + gmaLocation + "\" -id \"" + addonID + "\" -changes \"" + changeNotes + "\"";
        }

        public void updateIconFunction()
        {
            Command = "\"" + gMadLocation + "\"" + " update -icon \"" + iconLocation + "\" -id \"" + addonID + "\"";
        }

        public void deleteScript(String fileName, int choice)
        {
            taskIsRunning = true;
            AutoClosingMessageBox.Show("Waiting to delete script.. Click \"Ok\" to delete it when the program is finished if the program doesn't delete it", "Notice", (int)(GarrysModWorkshopUtil.Properties.Settings.Default.AutoDeleteScriptTime / 0.001));
            taskIsRunning = false;
            File.Delete(fileName);

            switch (choice)
            {
                case 1:
                    if (wantsToDeleteJSON == true)
                    {
                        File.Delete(addonLocation + "\\addon.json");
                    }

                    else
                    {

                    }
                    break;
            }
        }

        public override string ToString()
        {
            return TaskName + TaskNotes;
        }

        public string getName()
        {
            return TaskName;
        }

        public string getCommand()
        {
            return Command;
        }
    }
}
