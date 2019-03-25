using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.TextToSpeech.V1;

namespace LanguageProject
{
    class Get_Text_2_Speech
    {
        //will get text 2 speech from database for specified parameter 
        // will take only conditoin name parameter 

        public void speech_test()
        {

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\Ryan\\Downloads\\SQL Database-7634c32e98e1.json");

            // Instantiate a client
            TextToSpeechClient client = TextToSpeechClient.Create();

            // Set the text input to be synthesized.
            SynthesisInput input = new SynthesisInput
            {
                Text = "Hello, World! My Name is Ryan Burrett"
            };

            // Build the voice request, select the language code ("en-US"),
            // and the SSML voice gender ("neutral").
            VoiceSelectionParams voice = new VoiceSelectionParams
            {
                LanguageCode = "en-US",
                SsmlGender = SsmlVoiceGender.Neutral
            };

            // Select the type of audio file you want returned.
            AudioConfig config = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Mp3
            };

            // Perform the Text-to-Speech request, passing the text input
            // with the selected voice parameters and audio file type
            var response = client.SynthesizeSpeech(new SynthesizeSpeechRequest
            {
                Input = input,
                Voice = voice,
                AudioConfig = config
            });

            // Write the binary AudioContent of the response to an MP3 file.
            using (Stream output = File.Create("sample.mp3"))
            {
                response.AudioContent.WriteTo(output);
                Console.WriteLine($"Audio content written to file 'sample.mp3'");
            }
        



    }
    }
}
