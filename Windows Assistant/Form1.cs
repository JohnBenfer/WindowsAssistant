﻿using System;
using System.Collections.Generic;
using System.Media;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Windows_Assistant
{
    public partial class UI : Form
    {
        VoiceToText voiceToText = new VoiceToText();
        ActionController actionController = new ActionController();
        bool speaking = false; // acts as a lock

        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices choices = new Choices();

        public bool SystemExit = false;

        public UI()
        {
            InitializeComponent();
            detect_Speech();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            List<string> textTranslation = new List<string>();
            
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
            printResults(textTranslation);
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
    }
}
