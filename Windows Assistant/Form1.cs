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

namespace Windows_Assistant
{
    public partial class Form1 : Form
    {

        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices choices = new Choices();
        
        //choices.Add(new string[] {"hello", "open"});

        public Form1()
        {
            InitializeComponent();
            choices.Add(new string[] { "hello", "open chrome", "shutdown"});
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
    }
}
