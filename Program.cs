using System;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Grpc.Auth;

namespace Google.Cloud.Speech.V1.SIGSEGV
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var speechClientBuilder = new SpeechClientBuilder
            {
                ChannelCredentials = GoogleCredential.FromFile("GoogleCredentials.json")
                    .CreateScoped(SpeechClient.DefaultScopes)
                    .ToChannelCredentials()
            };

            var speechClient = await speechClientBuilder.BuildAsync();

            var audio = RecognitionAudio.FromFile("sample.wav");

            Console.WriteLine("You can see this line.");

            var response = await speechClient.LongRunningRecognizeAsync(
                new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                    SampleRateHertz = 44100,
                    LanguageCode = "en-US",
                    DiarizationConfig = new SpeakerDiarizationConfig { EnableSpeakerDiarization = true },
                    Model = "phone_call"
                },
                audio
            );

            Console.WriteLine("But you can't see this one.");
        }
    }
}
