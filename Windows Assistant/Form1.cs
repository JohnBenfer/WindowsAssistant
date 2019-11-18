using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Diagnostics;
using Google.Cloud.Speech.V1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using NAudio.Mixer;



namespace Windows_Assistant
{
    public partial class Form1 : Form
    {
        VoiceToText voiceToText = new VoiceToText();
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices choices = new Choices();
        IFTTT webObject = new IFTTT("cQ3xgk9nxLdnmZzs3VkXzv", "https://maker.ifttt.com/trigger/");

        public Form1()
        {
            InitializeComponent();
            choices.Add(new string[] { "hello", "open chrome", "shutdown", "lights on", "lights off"});
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void RecordButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = false;
            StopButton.Enabled = true;
            Grammar gr = new Grammar(new GrammarBuilder(choices));

            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechDetected += sre_SpeechDetected;
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void sre_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            string s = e.ToString() + Environment.NewLine;
            TextOutput.Text += s;
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {
                case "hello":

                    break;
                case "open chrome":
                    Process.Start("chrome", "http://www.google.com");
                    break;
                case "shutdown":
                    Application.Exit();
                    break;
                case "lights on":
                    webObject.executeAction("bedroom_lights_on");
                    break;
                case "lights off":
                    webObject.executeAction("bedroom_lights_off");
                    break;
                default:
                    break;
            }

            TextOutput.Text += e.Result.Text.ToString() + Environment.NewLine;

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = true;
            StopButton.Enabled = false;
            sre.RecognizeAsyncStop();

        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {

        }


        

        private async void google_button_Click(object sender, EventArgs e)
        {
            List<string> textTranslation = new List<string>();
            textTranslation = (List<string>)await voiceToText.Listen(20, sender, e);
            foreach(string s in textTranslation)
            {
                TextOutput.Text += s;
                TextOutput.Text += Environment.NewLine;
                Console.WriteLine(s);
            }


        }

        private void apitest_Click(object sender, EventArgs e)
        {

            webObject.executeAction("bedroom_lights_on");
            ApiHelper api = new ApiHelper("https://api.sonos.com/");
            TextOutput.Text += api.execute();

        }

    }
}
