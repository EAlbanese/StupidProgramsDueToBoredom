using ChatGPT.Net;

// ChatGPT Official API
var bot = new ChatGpt("<API_KEY>");

var response = await bot.Ask("What is the weather like today?");
Console.WriteLine(response);