using Google.Cloud.Speech.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;

namespace Windows_Assistant
{
    class VoiceToText
    {
        //public CancellationToken token = new CancellationToken();

        // [START speech_transcribe_streaming_mic]
        public async Task<object> Listen(int seconds, object s, EventArgs e)
        {
            List<string> textTranslation = new List<string>();
            CancellationTokenSource token = new CancellationTokenSource();

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
                            Model = "command_and_search",
                        },
                        InterimResults = true,
                        
                    }
                });
            // Print responses as they arrive.
            int count = 0;
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
                            //TextOutput.Text += alternative.Transcript + "\n";
                            textTranslation.Add(alternative.Transcript);
                            Console.WriteLine(alternative.Transcript);
                            if(alternative.Transcript.Contains("activate"))
                            {
                                Console.WriteLine("Here.....");
                                if(count >= 1)
                                {
                                    Console.WriteLine("Activated...");
                                    token.Cancel();
                                    return;
                                    
                                }
                                count++;
                            }
                        }
                    }
                }
            });

            if (count >= 1)
            {
                Console.WriteLine("Escape.......");
                return textTranslation;

            }

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
                            Console.WriteLine("no write more");
                            return;
                        }

                        streamingCall.WriteAsync(
                            new StreamingRecognizeRequest()
                            {
                                AudioContent = Google.Protobuf.ByteString
                                    .CopyFrom(args.Buffer, 0, args.BytesRecorded)
                            }).Wait();
                        Console.WriteLine("after writeAsync");
                    }
                    Console.WriteLine("after writelock");
                };

            waveIn.StartRecording();
            Console.WriteLine("Speak now.");
            
            await Task.Delay(TimeSpan.FromSeconds(seconds), token.Token);
            // Stop recording and shut down.
            waveIn.StopRecording();
            lock (writeLock)
            {
                writeMore = false;
            }

            await streamingCall.WriteCompleteAsync();
            await printResponses;


            Console.WriteLine("Time expired.");
            return textTranslation;
        }




        // [START Listening for a command]
        public async Task<object> Activated(int seconds, object s, EventArgs e)
        {
            List<string> textTranslation = new List<string>();

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
                            Model = "command_and_search",
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
                            //TextOutput.Text += alternative.Transcript + "\n";
                            textTranslation.Add(alternative.Transcript);
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


            Console.WriteLine("Time expired.");
            return textTranslation;
        }


    }
}
