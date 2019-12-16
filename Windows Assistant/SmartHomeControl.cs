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
 * bathroom_lights_on
 * 
 * bathroom_lights_off
 * 
 * livingroom_lights_on
 * 
 * livingroom_lights_off
 * 
 * bedroom_heater_on
 * 
 * bedroom_heater_off
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

            if(command.Contains("PLAYBAR") || command.Contains("PLAY BAR") || (command.Contains("BEDROOM") && command.Contains("VOLUME")))
            {
                if(command.Contains("UP"))
                {
                    PlaybarVolumeUp();
                    Console.WriteLine("vol up");
                } else if(command.Contains("DOWN"))
                {
                    PlaybarVolumeDown();
                    Console.WriteLine("vol down");
                } else if(command.Contains("SET"))
                {
                    SetPlaybarVolume(command);
                } else if(command.Contains("MUTE"))
                {
                    SetPlaybarVolume("0");
                }
            } 
            else if(command.Contains("HEATER") || command.Contains("BEDROOM HEATER"))
            {
                if (command.Contains("TURN ON"))
                {
                    BedroomHeaterOn();
                } else if (command.Contains("TURN OFF"))
                {
                    BedroomHeaterOff();
                }
            } else if(command.Contains("LIGHT") || command.Contains("LIGHTS") || command.Contains("LAMP"))
            {
                if(command.Contains("ON"))
                {
                    if(command.Contains("BEDROOM"))
                    {
                        BedroomLightsOn();
                    } else if (command.Contains("BATHROOM"))
                    {
                        BathroomLightsOn();
                    } else if (command.Contains("LIVING ROOM"))
                    {
                        LivingRoomLightsOn();
                    } else
                    {
                        BedroomLightsOn();
                    }
                } else if (command.Contains("OFF"))
                {
                    if (command.Contains("BEDROOM"))
                    {
                        BedroomLightsOff();
                    }
                    else if (command.Contains("BATHROOM"))
                    {
                        BathroomLightsOff();
                    }
                    else if (command.Contains("LIVING ROOM"))
                    {
                        LivingRoomLightsOff();
                    } else
                    {
                        BedroomLightsOff();
                    }
                } else if (command.Contains("DIM"))
                {
                    if (command.Contains("BEDROOM"))
                    {
                        BedroomLightsDim();
                    }
                    else if (command.Contains("BATHROOM"))
                    {
                        BathroomLightsDim();
                    }
                    else if (command.Contains("LIVING ROOM"))
                    {
                        LivingRoomLightsDim();
                    }
                }
            }

            return;
        }

        public void BathroomLightsDim()
        {
            webObjects.executeAction("bathroom_lights_dim");
            Console.WriteLine("Dimming Bathroom Lights");
        }
        public void LivingRoomLightsDim()
        {
            webObjects.executeAction("livingroom_lights_dim");
            Console.WriteLine("Dimming Living Room Lights");
        }
        public void BedroomLightsDim()
        {
            webObjects.executeAction("bedroom_lights_dim");
            Console.WriteLine("Dimming Bedroom Lights");
        }
        public void BathroomLightsOn()
        {
            webObjects.executeAction("bathroom_lights_on");
            Console.WriteLine("Bathroom Lights On");
        }

        public void BathroomLightsOff()
        {
            webObjects.executeAction("bathroom_lights_off");
            Console.WriteLine("Bathroom Lights Off");
        }
        public void BedroomHeaterOn()
        {
            webObjects.executeAction("bedroom_heater_on");
            Console.WriteLine("Bedroom Heater On");
        }

        public void BedroomHeaterOff()
        {
            webObjects.executeAction("bedroom_heater_off");
            Console.WriteLine("Bedroom Heater Off");
        }

        public void LivingRoomLightsOn()
        {
            webObjects.executeAction("livingroom_lights_on");
            Console.WriteLine("Living Room Lights On");
        }

        public void LivingRoomLightsOff()
        {
            webObjects.executeAction("livingroom_lights_off");
            Console.WriteLine("Living Room Lights Off");
        }

        /// <summary>
        /// turns off bedroom lights
        /// </summary>
        public void BedroomLightsOff()
        {
            webObjects.executeAction("bedroom_lights_off");
            Console.WriteLine("Bedroom Lights Off");
        }

        /// <summary>
        /// turns on bedroom lights to 100% brightness
        /// </summary>
        public void BedroomLightsOn()
        {
            webObjects.executeAction("bedroom_lights_on");
            Console.WriteLine("Bedroom Lights On");
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
        public void PlaybarVolumeUp()
        {
            webObjects.executeAction("playbar_volume_up");
        }

        /// <summary>
        /// turns down the playbar volume
        /// </summary>
        public void PlaybarVolumeDown()
        {
            webObjects.executeAction("playbar_volume_down");
        }


    }
}
