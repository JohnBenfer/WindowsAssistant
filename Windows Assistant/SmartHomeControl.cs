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
        IFTTT webObject = new IFTTT("cQ3xgk9nxLdnmZzs3VkXzv", "https://maker.ifttt.com/trigger/");

        string command;
        public SmartHomeControl(string command)
        {
            this.command = command;
        }

        public static void process(string command)
        {
            if(command.Contains("SET PLAYBAR VOLUME"))
            {
                int volume = Convert.ToInt32(Regex.Replace(command, "[^0-9]+", string.Empty));

            }
            return;
        }


    }
}
