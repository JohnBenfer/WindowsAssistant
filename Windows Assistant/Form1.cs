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


namespace Windows_Assistant
{
    public partial class Form1 : Form
    {

        SpeechClient speech = SpeechClient.Create();
        
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices choices = new Choices();
        IFTTT webObject = new IFTTT("cQ3xgk9nxLdnmZzs3VkXzv", "https://maker.ifttt.com/trigger/{event}/with/key/webhookskey");

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
            var client = SpeechClient.Create();
            
            
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


        // [START speech_transcribe_streaming_mic]
        static async Task<object> StreamingMicRecognizeAsync(int seconds)
        {
            var speech = SpeechClient.Create();
            var streamingCall = speech.StreamingRecognize();
            // Write the initial request with the config.
            await streamingCall.WriteAsync(
                new StreamingRecognizeRequest()
                {
                    StreamingConfig = new StreamingRecognitionConfig()
                    {
                        Config = new RecognitionConfig()
                        {
                            Encoding =
                            RecognitionConfig.Types.AudioEncoding.Linear16,
                            SampleRateHertz = 16000,
                            LanguageCode = "en",
                        },
                        InterimResults = true,
                    }
                });
            // Print responses as they arrive.
            Task printResponses = Task.Run(async () =>
            {
                while (await streamingCall.ResponseStream.MoveNext(
                    default(CancellationToken)))
                {
                    foreach (var result in streamingCall.ResponseStream
                        .Current.Results)
                    {
                        foreach (var alternative in result.Alternatives)
                        {
                            Console.WriteLine(alternative.Transcript);
                        }
                    }
                }
            });
            // Read from the microphone and stream to API.
            object writeLock = new object();
            bool writeMore = true;
            var waveIn = new NAudio.Wave.WaveInEvent();
            waveIn.DeviceNumber = 0;
            waveIn.WaveFormat = new NAudio.Wave.WaveFormat(16000, 1);
            waveIn.DataAvailable +=
                (object sender, NAudio.Wave.WaveInEventArgs args) =>
                {
                    lock (writeLock)
                    {
                        if (!writeMore)
                        {
                            return;
                        }

                        streamingCall.WriteAsync(
                            new StreamingRecognizeRequest()
                            {
                                AudioContent = Google.Protobuf.ByteString
                                    .CopyFrom(args.Buffer, 0, args.BytesRecorded)
                            }).Wait();
                    }
                };
            waveIn.StartRecording();
            Console.WriteLine("Speak now.");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
            // Stop recording and shut down.
            waveIn.StopRecording();
            lock (writeLock)
            {
                writeMore = false;
            }

            await streamingCall.WriteCompleteAsync();
            await printResponses;
            return 0;
        }

        private void google_button_Click(object sender, EventArgs e)
        {
            await StreamingMicRecognizeAsync(10);
        }
        // [END speech_transcribe_streaming_mic]

    }
}
