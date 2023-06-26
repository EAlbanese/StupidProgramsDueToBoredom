// See https://aka.ms/new-console-template for more information
using Spectre.Console;

Console.WriteLine("Hello, World!");


var fruits = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("What are your [green]favorite fruits[/]?")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
        .MoreChoicesText(
            "[grey](Press [blue]<space>[/] to toggle a fruit, " +
            "[green]<enter>[/] to accept)[/]")
        .AddChoices(new[] {
            "Apple", "Apricot", "Avocado",
            "Banana", "Blackcurrant", "Blueberry",
            "Cherry", "Cloudberry", "Coconut",
        }));

AnsiConsole.WriteLine(fruits);
