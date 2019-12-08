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

        SmartHomeControl smc = new SmartHomeControl();
        WindowsControl wc = new WindowsControl();

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
                
                SmartHomeVocab.Add(s.ToUpper().Replace("\r\n", "").Replace("\r", "").Replace("\n", ""));
            }
        }

        private void LoadWindowsVocab()
        {
            string[] words = Properties.Resources.WindowsVocab.Split('\n');
            foreach (string s in words)
            {
                WindowsVocab.Add(s.ToUpper().Replace("\r\n", "").Replace("\r", "").Replace("\n", ""));
            }
        }

        public void NewRequest(List<string> textTranslation)
        {
            if(textTranslation.Count == 0)
            {
                return;
            }

            string request = textTranslation[textTranslation.Count - 1].ToUpper();

            RequestType requestType = Windows_or_SmartHome(request);
            switch (requestType)
            {
                case RequestType.SmartHome:
                    smc.process(request);
                    Console.WriteLine("Smart Home request");
                    return;
                case RequestType.Windows:
                    wc.process(request);
                    Console.WriteLine("Windows request");
                    return;
                case RequestType.Unknown:
                    Console.WriteLine("Unkown request");
                    return;
            }
        }

        private RequestType Windows_or_SmartHome(string command)
        {
            // counts smart home words
            int smartHomeCount = 0;
            foreach (string s in SmartHomeVocab)
            {
                if (command.Contains(s))
                {
                    smartHomeCount++;
                }
            }

            // counts windows words
            int windowsCount = 0;
            foreach (string s in WindowsVocab)
            {
                if (command.Contains(s))
                {
                    windowsCount++;
                }
            }

            // compares which topic was discussed more
            if(smartHomeCount > windowsCount)
            {
                return RequestType.SmartHome;
            } else if(smartHomeCount < windowsCount)
            {
                return RequestType.Windows;
            }

            return RequestType.Unknown;
        }
    }
}
