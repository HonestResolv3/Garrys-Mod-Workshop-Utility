using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GarrysModWorkshopUtil
{
    class PresetData
    {
        private string addonInput;
        private string addoniconInput;
        private string exeInput;
        private string gmaLocInput;
        private string gmaOutput;
        private string addonID;
        private string presetName;

        public PresetData(string preName, string addon, string addonIcon, string exe, string gmaLoc, string gmaOut, string id)
        {
            presetName = preName;
            addonInput = addon;
            addoniconInput = addonIcon;
            exeInput = exe;
            gmaLocInput = gmaLoc;
            gmaOutput = gmaOut;
            addonID = id;
        }

        public string getAddonInput()
        {
            return addonInput;
        }

        public string getAddonIconInput()
        {
            return addoniconInput;
        }

        public string getExeInput()
        {
            return exeInput;
        }

        public string getGMALocInput()
        {
            return gmaLocInput;
        }

        public string getGMAOutput()
        {
            return gmaOutput;
        }

        public string getAddonID()
        {
            return addonID;
        }

        public string getPresetName()
        {
            return presetName;
        }

        public override String ToString()
        {
            return presetName;
        }
    }
}
