using System;
using System.Collections.Generic;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Windows_Assistant
{
    public partial class UI : Form
    {
        VoiceToText voiceToText = new VoiceToText();
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices choices = new Choices();
        IFTTT webObject = new IFTTT("cQ3xgk9nxLdnmZzs3VkXzv", "https://maker.ifttt.com/trigger/");
        public bool SystemExit = false;

        public UI()
        {
            InitializeComponent();
            //google_button_Click(new object(), new EventArgs());

            detect_Speech();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void StopButton_Click(object sender, EventArgs e)
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

            sre.SpeechDetected += Sre_SpeechDetected;

        }

        private void Sre_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            Console.WriteLine("speech detected..");
            google_button_Click(sender, e);
        }

        private async void google_button_Click(object sender, EventArgs e)
        {
            while (!SystemExit)
            {
                List<string> textTranslation = new List<string>();
                // throws exception when 'activate' is heard
                try
                {
                    
                    await voiceToText.Listen(10, sender, e);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Here is the exception................. " + ex.ToString());
                    //if(ex.Equals(AggregateException))
                    //{

                    //}
                    TextOutput.Clear();
                    textTranslation = (List<string>)await voiceToText.Activated(8, sender, e);
                    if (textTranslation.Count > 0)
                    {
                        TextOutput.Text += textTranslation[textTranslation.Count - 1];
                    }
                    TextOutput.Text += Environment.NewLine;
                    foreach (string s in textTranslation)
                    {
                        TextOutput.Text += s;
                        TextOutput.Text += Environment.NewLine;
                        Console.WriteLine(s);
                    }

                }
                SystemExit = true;
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
