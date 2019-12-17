using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Assistant
{
    class WindowsControl
    {

        public void process(string command)
        {

            if (command.Equals("EXIT") || command.Equals("QUIT") || command.Equals("CLOSE"))
            {
                Application.Exit();
            } else if (command.Contains("OPEN") || command.Contains("LAUNCH") || command.Contains("OPEN UP") || command.Contains("START")) {
                if (command.Contains("CHROME") || command.Contains("GOOGLE") || command.Contains("GOOGLE CHROME"))
                {
                    LaunchApplication("CHROME");
                } else if (command.Contains("SPOTIFY"))
                {
                    LaunchApplication("SPOTIFY");
                } else if (command.Contains("VISUAL STUDIO 2015"))
                {
                    LaunchApplication("VISUAL STUDIO 2015");
                } else if (command.Contains("NOTEPAD") || command.Contains("NOTEPAD PLUS PLUS") || command.Contains("NOTEPAD++"))
                {
                    LaunchApplication("NOTEPAD++");
                }
                else if (command.Contains("LIGHTROOM") || command.Contains("ADOBE LIGHTROOM") || command.Contains("LIGHTROOM CLASSIC"))
                {
                    LaunchApplication("LIGHTROOM");
                }
                else if (command.Contains("POSTMAN"))
                {
                    LaunchApplication("POSTMAN");
                } else if(command.Contains("ALL"))
                {

                }
            } else if (command.Contains("EXIT") || command.Contains("QUIT") || command.Contains("CLOSE"))
            {
                if (command.Contains("SPOTIFY"))
                {
                    ExitApplication("Spotify");
                } else if (command.Contains("CHROME") || command.Contains("GOOGLE"))
                {
                    ExitApplication("Google Chrome");
                } else if (command.Contains("NOTEPAD") || command.Contains("NOTEPAD PLUS PLUS") || command.Contains("NOTEPAD++"))
                {
                    ExitApplication("Notepad++");
                } else if (command.Contains("VISUAL STUDIO 2015") || command.Contains("VISUAL STUDIO")) {
                    ExitApplication("Visual Studio 2015");
                }
                else if (command.Contains("POSTMAN"))
                {
                    ExitApplication("POSTMAN");
                }
                else if (command.Contains("LIGHTROOM") || command.Contains("ADOBE LIGHTROOM") || command.Contains("LIGHTROOM CLASSIC"))
                {
                    ExitApplication("Lightroom");
                }
                else
                {
                    MessageBox.Show("Application not found");
                }
            } else if(command.Contains("PLAY SPOTIFY") || command.Contains("PLAY MUSIC") || command.Contains("PLAY SOME MUSIC") || command.Contains("PLAY SOME SPOTIFY"))
            {
                if(command.Contains("PLAYBAR"))
                {

                }
            } else if(command.Contains("SLEEP"))
            {
                PCSleep();
            }
            else
            {
                MessageBox.Show("Command not found..");
            }


            return;
        }

        public void ExitApplication(string app)
        {
            try
            {
                foreach(Process proc in Process.GetProcessesByName(app))
                {
                    proc.Kill();
                    Console.WriteLine("Killing..");
                }

            } catch
            {
                MessageBox.Show("Application " + app + " not found");
            }
        }
        
        /// <summary>
        /// launches a passed in application from a shortcut link in the Apps folder
        /// </summary>
        /// <param name="app">the app to launch</param>
        public void LaunchApplication(string app)
        {
            try
            {
                Console.WriteLine("launching..");
                string link = "C:/Apps/" + app.ToLower() + ".exe.lnk";
                Process proc = new Process();
                proc.StartInfo.FileName = @link;
                proc.Start();
            } catch
            {

            }
        }

        public void PCSleep()
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }

        public void CloseAllApps()
        {
            foreach (Process p in Process.GetProcesses(System.Environment.MachineName))
            {
                if (p.MainWindowHandle != IntPtr.Zero)
                {
                    if (!p.ProcessName.Contains("Visual Studio") && !p.ProcessName.Contains("Chrome") && !p.ProcessName.Contains("Windows Assistant"))
                    {
                        p.Kill();
                    }

                }
            }
        }



    }
}
