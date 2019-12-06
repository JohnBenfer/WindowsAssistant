using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Windows_Assistant
{
    class SmartHomeControl
    {
        IFTTT webObjects = new IFTTT("cQ3xgk9nxLdnmZzs3VkXzv", "https://maker.ifttt.com/trigger/");
        public SmartHomeControl()
        {
            
        }

        public void process(string command)
        {

            if(command.Contains("SET PLAYBAR VOLUME") || command.Contains("SET PLAY BAR VOLUME"))
            {
                SetPlaybarVolume(command);

            }

            return;
        }

        private void SetPlaybarVolume(string command)
        {
            try
            {
                int volume = Convert.ToInt32(Regex.Replace(command, "[^0-9]+", string.Empty));
                Console.WriteLine("Sonos volume: " + volume);
                webObjects.executeAction("playbar_volume_set", volume.ToString());
            }
            catch
            {
                // maybe implement asking the user to enter the desired volume
                Console.WriteLine("No volume set");
            }
        }


    }
}
