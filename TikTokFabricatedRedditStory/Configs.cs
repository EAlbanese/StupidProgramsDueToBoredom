using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokFabricatedRedditStory
{
    internal class Configs
    {
        public static readonly string ChatGpt_APIKey = "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";
        public static readonly string TempFolder = Path.Combine(Directory.GetCurrentDirectory(), "Temp");

        public static void ClearTemp()
        {
            var toDeleteFiles = Directory.GetFiles(TempFolder);

            foreach (var item in toDeleteFiles)
            {
                Directory.Delete(item);
            }
        }

    }
}
