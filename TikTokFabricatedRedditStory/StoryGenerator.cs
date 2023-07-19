using ChatGPT.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Reflection.PortableExecutable;

namespace TikTokFabricatedRedditStory
{
    internal class StoryGenerator
    {
        public static async Task<string> GetStory(string subject) {
            var bot = new ChatGpt(Configs.ChatGpt_APIKey);

            var response = await bot.Ask(@"
            Write me a short Story to the Question in the First Person perspective like some one tells a Story to a friend.  With details what happend and so on. In 3 pharagrsphs

            Question: ""{subject}""
            ");
            return response;
        }

        #pragma warning disable CA1416 // Validate platform compatibility
        public static MemoryStream AudioGenerator(string ConvertToAudio) {   
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            synthesizer.Volume = 100;  // (0 - 100)
            synthesizer.Rate = 0;     // (-10 - 10)

            MemoryStream ms = new MemoryStream();
            synthesizer.SetOutputToWaveStream(ms);
            synthesizer.SetOutputToWaveFile(@"C:\MyWavFile.wav");

            synthesizer.Speak(ConvertToAudio);

            return ms;
        }
        #pragma warning restore CA1416 // Validate platform compatibility

    }
}
