using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Windows_Assistant
{
    public partial class UI : Form
    {
        VoiceToText voiceToText = new VoiceToText();
        ActionController actionController = new ActionController();
        bool speaking = false; // acts as a lock

        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices choices = new Choices();

        RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public UI()
        {
            InitializeComponent();
            detect_Speech();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // sets the start postion of the window
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(950, 20);

            // sets the run on startup checkbox accordingly
            try
            {
                Console.WriteLine(rk.GetValue(Application.ProductName).ToString());
                checkRunOnStart.CheckState = CheckState.Checked;
            } catch
            {
                checkRunOnStart.CheckState = CheckState.Unchecked;
            }

            choices.Add(new string[] { "activate" });
            Grammar grammar = new Grammar(new GrammarBuilder(choices));
            sre.LoadGrammarAsync(grammar);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += Sre_SpeechRecognized;
            WindowsAudio_Click(sender, e);


        }

        private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (!speaking)
            {
                if (e.Result.Text.Equals("activate"))
                {
                    Console.WriteLine(e.Result.Text + "..");
                    speaking = true;
                    VoiceActivated(sender, e);
                }
            }
        }

        private async void VoiceActivated(object sender, EventArgs e)
        {
            this.Text = "Listening...";
            TextOutput.Text = "Listening...";
            List<string> textTranslation = new List<string>();
            speaking = true;
            try
            {
                textTranslation = (List<string>)await voiceToText.Activated(7, sender, e);
                SystemSounds.Hand.Play();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                
            }
            this.Text = "Voice Assistant";
            speaking = false;
            TextOutput.Text = "";
            if (checkPrintResults.Checked) 
            {
                    printResults(textTranslation);
            } else
            {
                if (textTranslation.Count < 1)
                {
                    // no new command found..
                    TextOutput.Text = "No new command";
                } else
                {
                    TextOutput.Text = textTranslation[textTranslation.Count - 1];
                }
            }

            actionController.NewRequest(textTranslation);

        }

        private void printResults(List<string> textTranslation)
        {
            TextOutput.Clear();
            if (textTranslation.Count > 0)
            {
                
                TextOutput.Text += "Final transcription: " + textTranslation[textTranslation.Count - 1] + Environment.NewLine;
                TextOutput.Text += Environment.NewLine;
                foreach (string s in textTranslation)
                {
                    TextOutput.Text += s;
                    TextOutput.Text += Environment.NewLine;
                    Console.WriteLine(s);
                }
            }
            else
            {
                // no new command found..
                TextOutput.Text += "No new command..";
            }
        }

        private void WindowsAudio_Click(object sender, EventArgs e)
        {
            TextOutput.Clear();
            TextOutput.Text += "Online.." + Environment.NewLine;
            sre.RecognizeAsync(RecognizeMode.Multiple);

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            try { Application.Exit(); }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {

        }


        private void detect_Speech()
        {
            Console.WriteLine("aqui");

        }

        private void Sre_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            //Console.WriteLine("speech detected..");
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            VoiceActivated(sender, e);
        }

        private void checkRunOnStart_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(Application.ProductName);
            if (checkRunOnStart.Checked)
            {
                rk.SetValue(Application.ProductName, Application.ExecutablePath);
            }
            else
            {
                rk.DeleteValue(Application.ProductName, false);
            }
        }


        //////////////////////////////////////// UI Buttons /////////////////////////////////////////////


        WindowsControl wc = new WindowsControl();
        SmartHomeControl smartHome = new SmartHomeControl();
        private void BedroomLightsOnButton_Click(object sender, EventArgs e)
        {
            smartHome.BedroomLightsOn();
        }

        private void BedroomLightsOffButton_Click(object sender, EventArgs e)
        {
            smartHome.BedroomLightsOff();
        }

        private void HeaterOnButton_Click(object sender, EventArgs e)
        {
            smartHome.BedroomHeaterOn();
        }

        private void HeaterOffButton_Click(object sender, EventArgs e)
        {
            smartHome.BedroomHeaterOff();
        }

        private void BathroomLightsOnButton_Click(object sender, EventArgs e)
        {
            smartHome.BathroomLightsOn();
        }

        private void BathroomLightsOffButton_Click(object sender, EventArgs e)
        {
            smartHome.BathroomLightsOff();
        }
        private void LivingroomLightsOnButton_Click(object sender, EventArgs e)
        {
            smartHome.LivingRoomLightsOn();
        }

        private void LivingroomLightsOffButton_Click(object sender, EventArgs e)
        {
            smartHome.LivingRoomLightsOff();
        }

        private void PlaybarVolumeUpButton_Click(object sender, EventArgs e)
        {
            smartHome.PlaybarVolumeUp();
        }

        private void PlaybarVolumeDownButton_Click(object sender, EventArgs e)
        {
            smartHome.PlaybarVolumeDown();
        }

        private void CloseAllAppsButton_Click(object sender, EventArgs e)
        {
            wc.CloseAllApps();
        }

        private void OpenChromeButton_Click(object sender, EventArgs e)
        {
            wc.LaunchApplication("chrome");
        }

        private void OpenSpotifyButton_Click(object sender, EventArgs e)
        {
            wc.LaunchApplication("spotify");
        }

        private void OpenLightroomButton_Click(object sender, EventArgs e)
        {
            wc.LaunchApplication("lightroom");
        }

        private void OpenNotepadButton_Click(object sender, EventArgs e)
        {
            wc.LaunchApplication("notepad++");
        }

        private void PCSleepButton_Click(object sender, EventArgs e)
        {
            wc.PCSleep();
        }

        private void OpenChromeButton1_Click(object sender, EventArgs e)
        {
            wc.LaunchApplication("chrome");
        }

        private void CloseChromeButton1_Click(object sender, EventArgs e)
        {
            wc.ExitApplication("chrome");
        }

        private void OpenLightroomButton1_Click(object sender, EventArgs e)
        {
            wc.LaunchApplication("lighroom");
        }

        private void CloseLightroomButton1_Click(object sender, EventArgs e)
        {
            wc.ExitApplication("lighroom");
        }

        private void OpenSpotifyButton1_Click(object sender, EventArgs e)
        {
            wc.LaunchApplication("spotify");
        }

        private void CloseSpotifyButton1_Click(object sender, EventArgs e)
        {
            wc.ExitApplication("spotify");
        }

        private void OpenNotepadButton1_Click(object sender, EventArgs e)
        {
            wc.LaunchApplication("notepad++");
        }

        private void CloseNotepadButton1_Click(object sender, EventArgs e)
        {
            wc.ExitApplication("notepad++");
        }

        private void CloseAllAppsButton1_Click(object sender, EventArgs e)
        {
            wc.CloseAllApps();
        }

        private void PCSleepButton1_Click(object sender, EventArgs e)
        {
            wc.PCSleep();
        }

        private void BedroomLightsOnButton2_Click(object sender, EventArgs e)
        {
            smartHome.BedroomLightsOn();
        }

        private void BedroomLightsOffButton3_Click(object sender, EventArgs e)
        {
            smartHome.BedroomLightsOff();
        }

        private void HeaterOnButton2_Click(object sender, EventArgs e)
        {
            smartHome.BedroomHeaterOn();
        }

        private void HeaterOffButton2_Click(object sender, EventArgs e)
        {
            smartHome.BedroomHeaterOff();
        }

        private void PlaybarVolumeUpButton2_Click(object sender, EventArgs e)
        {
            smartHome.PlaybarVolumeUp();
        }

        private void PlaybarVolumeDownButton2_Click(object sender, EventArgs e)
        {
            smartHome.PlaybarVolumeDown();
        }

        private void LivingroomLightsOnButton3_Click(object sender, EventArgs e)
        {
            smartHome.LivingRoomLightsOn();
        }

        private void LivingroomLightsOffButton3_Click(object sender, EventArgs e)
        {
            smartHome.LivingRoomLightsOff();
        }

        private void BathroomLightsOnButton4_Click(object sender, EventArgs e)
        {
            smartHome.BathroomLightsOn();
        }

        private void BathroomLightsOffButton4_Click(object sender, EventArgs e)
        {
            smartHome.BathroomLightsOff();
        }

        private void BedroomLightsOnButton5_Click(object sender, EventArgs e)
        {
            smartHome.BedroomLightsOn();
        }

        private void BedroomLightsOffButton5_Click(object sender, EventArgs e)
        {
            smartHome.BedroomLightsOff();
        }

        private void BathroomLightsOnButton5_Click(object sender, EventArgs e)
        {
            smartHome.BathroomLightsOn();
        }

        private void BathroomLightsOffButton5_Click(object sender, EventArgs e)
        {
            smartHome.BathroomLightsOff();
        }

        private void LivingroomLightsOnButton5_Click(object sender, EventArgs e)
        {
            smartHome.LivingRoomLightsOn();
        }

        private void LivingroomLightsOffButton5_Click(object sender, EventArgs e)
        {
            smartHome.LivingRoomLightsOff();
        }

        private void HeaterOnButton5_Click(object sender, EventArgs e)
        {
            smartHome.BedroomHeaterOn();
        }

        private void HeaterOffButton5_Click(object sender, EventArgs e)
        {
            smartHome.BedroomHeaterOff();
        }

        private void PlaybarVolumeUpButton5_Click(object sender, EventArgs e)
        {
            smartHome.PlaybarVolumeUp();
        }

        private void PlaybarVolumeDownButton5_Click(object sender, EventArgs e)
        {
            smartHome.PlaybarVolumeDown();
        }
    }
}
