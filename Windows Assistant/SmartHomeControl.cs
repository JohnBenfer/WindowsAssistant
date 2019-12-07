using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 * set_playbar_volume + value
 * 
 * playbar_volume_up
 * 
 * playbar_volume_down
 * 
 * bedroom_lights_off
 * 
 * bedroom_lights_on
 * 
 * bedroom_lights_dim
 * 
 * livingroom_lights_on
 * 
 * livingroom_lights_off
 */

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

            if(command.Contains("SET PLAYBAR VOLUME") || command.Contains("SET PLAY BAR VOLUME") || command.Contains("SET THE PLAYBAR VOLUME") || command.Contains("SET THE PLAY BAR VOLUME") || command.Contains("SET THE VOLUME IN THE BEDROOM"))
            {
                SetPlaybarVolume(command);
            }
            else if(command.Contains("PLAYBAR VOLUME UP") || command.Contains("TURN UP PLAYBAR") || command.Contains("TURN UP PLAY BAR") || command.Contains("TURN UP THE PLAYBAR") || command.Contains("TURN UP THE PLAY BAR") || command.Contains("TURN UP THE VOLUME IN THE BEDROOM"))
            {
                PlaybarVolumeUp();
                Console.WriteLine("vol up");
            } else if(command.Contains("PLAYBAR VOLUME DOWN") || command.Contains("TURN DOWN PLAYBAR") || command.Contains("TURN DOWN PLAY BAR") || command.Contains("TURN DOWN THE PLAYBAR") || command.Contains("TURN DOWN THE PLAY BAR") || command.Contains("TURN DOWN THE VOLUME IN THE BEDROOM"))
            {
                PlaybarVolumeDown();
                Console.WriteLine("vol down");
            } else if(command.Contains("TURN OFF THE BEDROOM LIGHTS") || command.Contains("TURN THE BEDROOM LIGHTS OFF") || command.Contains("TURN OFF THE LIGHTS") || command.Contains("TURN LIGHTS OFF"))
            {
                BedroomLightsOff();
            }
            else if (command.Contains("TURN ON THE BEDROOM LIGHTS") || command.Contains("TURN THE BEDROOM LIGHTS ON") || command.Contains("TURN ON THE LIGHTS") || command.Contains("TURN LIGHTS ON"))
            {
                BedroomLightsOn();
            } else if (command.Contains("TURN ON THE LIVING ROOM LIGHTS") || command.Contains("TURN THE LIVING ROOM LIGHTS ON") || command.Contains("TURN ON THE LIGHTS IN THE LIVING ROOM") || command.Contains("TURN LIGHTS ON IN LIVING ROOM"))
            {
                LivingRoomLightsOn();
            }
            else if (command.Contains("TURN OFF THE LIVING ROOM LIGHTS") || command.Contains("TURN THE LIVING ROOM LIGHTS OFF") || command.Contains("TURN OFF THE LIGHTS IN THE LIVING ROOM") || command.Contains("TURN LIGHTS OFF IN LIVING ROOM"))
            {
                LivingRoomLightsOn();
            }

            return;
        }

        private void LivingRoomLightsOn()
        {
            webObjects.executeAction("livingroom_lights_on");

        }

        private void LivingRoomLightsOff()
        {
            webObjects.executeAction("livingroom_lights_off");

        }

        /// <summary>
        /// turns off bedroom lights
        /// </summary>
        private void BedroomLightsOff()
        {
            webObjects.executeAction("bedroom_lights_off");
        }

        /// <summary>
        /// turns on bedroom lights to 100% brightness
        /// </summary>
        private void BedroomLightsOn()
        {
            webObjects.executeAction("bedroom_lights_on");
        }

        /// <summary>
        /// sets playbar volume to defined amount
        /// </summary>
        /// <param name="command">the voice command</param>
        private void SetPlaybarVolume(string command)
        {
            try
            {
                int volume = Convert.ToInt32(Regex.Replace(command, "[^0-9]+", string.Empty));
                Console.WriteLine("Sonos volume: " + volume);
                webObjects.executeAction("set_playbar_volume", volume.ToString());
            }
            catch
            {
                // maybe implement asking the user to enter the desired volume
                Console.WriteLine("No volume set");
            }
        }

        /// <summary>
        /// turns up the playbar volume
        /// </summary>
        private void PlaybarVolumeUp()
        {
            webObjects.executeAction("playbar_volume_up");
        }

        /// <summary>
        /// turns down the playbar volume
        /// </summary>
        private void PlaybarVolumeDown()
        {
            webObjects.executeAction("playbar_volume_down");
        }


    }
}
