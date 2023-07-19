using ChatGPT.Net;
using TikTokFabricatedRedditStory;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Pls Give a Subject:");
        //var subject = Console.ReadLine();
        var subject = "People who cut off their family, what did they to you?";

        var stroy = StoryGenerator.GetStory(subject).Result;
        Console.WriteLine("Created Story");
        var audioStream = StoryGenerator.AudioGenerator(stroy);
        Console.WriteLine("Created Audio");



        var backgroudnVideos = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "BackgroundVideo"));
    }
}