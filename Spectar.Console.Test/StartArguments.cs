using Spectre.Console.Cli;

namespace Spectar.Console.Test
{
    public class StartArguments : CommandSettings
    {
        [CommandOption("--debug")]
        public bool? Debug { get; set; }

        [CommandArgument("-p <name>")]
        public string? Name { get; set; }

        [CommandArgument(0, "[name]")]
        public string? Password { get; set; }

    }
}
