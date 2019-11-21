using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Windows_Assistant
{
    
    class ActionController
    {
        private List<string> SmartHomeVocab = new List<string>();
        private List<string> WindowsVocab = new List<string>();
        enum RequestType { Windows, SmartHome, Unknown };

        public ActionController()
        {
            LoadSmartHomeVocab();
            LoadWindowsVocab();
        }

        private void LoadSmartHomeVocab()
        {
            string[] words = Properties.Resources.SmartHomeVocab.Split('\n');
            foreach(string s in words)
            {
                SmartHomeVocab.Add(s);
            }
        }

        private void LoadWindowsVocab()
        {
            string[] words = Properties.Resources.WindowsVocab.Split('\n');
            foreach (string s in words)
            {
                WindowsVocab.Add(s);
            }
        }

        public void NewRequest(List<string> textTranslation)
        {
            Windows_or_SmartHome(textTranslation[textTranslation.Count - 1]);
        }

        private RequestType Windows_or_SmartHome(string command)
        {
            if(command.Contains("light"))
            {
                return RequestType.SmartHome;
            }

            

            foreach (string s in SmartHomeVocab)
            {

            } 


            return RequestType.Unknown;
        }
    }
}
