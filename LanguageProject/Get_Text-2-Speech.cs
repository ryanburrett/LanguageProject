using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.TextToSpeech.V1;
using Grpc.Auth;

namespace LanguageProject
{
    class Get_Text_2_Speech
    {
        //will get text 2 speech from database for specified parameter 
        // will take only conditoin name parameter 

        public byte[] send_api_speech_request(string text_2_send)
        {

            


            var credential = GoogleCredential.FromFile("SQLDatabase-7634c32e98e1.json").CreateScoped(TextToSpeechClient.DefaultScopes);
            var channel = new Grpc.Core.Channel(TextToSpeechClient.DefaultEndpoint.ToString(),credential.ToChannelCredentials());


            // Instantiate a client
            TextToSpeechClient client = TextToSpeechClient.Create(channel);

            

            // Set the text input to be synthesized.
            SynthesisInput input = new SynthesisInput
            {
                Text = text_2_send
            };

            // Build the voice request, select the language code ("en-US"),
            // and the SSML voice gender ("neutral").
            VoiceSelectionParams voice = new VoiceSelectionParams
            {
                LanguageCode = "en-US",
                SsmlGender = SsmlVoiceGender.Female
            };

            // Select the type of audio file you want returned.
            AudioConfig config = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Linear16
            };

            // Perform the Text-to-Speech request, passing the text input
            // with the selected voice parameters and audio file type
            var response = client.SynthesizeSpeech(new SynthesizeSpeechRequest
            {
                Input = input,
                Voice = voice,
                AudioConfig = config
            });

          

            byte[] sounds = response.AudioContent.ToByteArray();
            return sounds;

    }
    }
}
