using SmartShell.Core.IO;
using SmartShell.Core.Parsing;

namespace SmartShell.Core.Runtime;

internal class RuntimeController
{
    private const string TITLE_PATTERN = @"^[a-z]+";
    private IInputDriver inputDriver;
    private IParser parser;
    private IStateLoader stateLoader;
    public RuntimeController
    (
        IInputDriver inputDriver,
        IParser parser,
        IStateLoader stateLoader
    )
    {
        this.inputDriver = inputDriver;
        this.parser = parser;
        this.stateLoader = stateLoader;
    }
    public void StartProcessing(CommandCollection commands)
    {
        while (true)
        {
            // get input
            string? input = inputDriver.Receive();

            if (string.IsNullOrEmpty(input))
                continue;

            input = input.Trim();

            // find command
            Command cmd = DetectCommand(commands, input);

            // load command state
            stateLoader.LoadState(cmd, input);

            // call command
            cmd.Execute();
        }
    }

    private Command DetectCommand(CommandCollection commands, string input)
    {
        string title = parser.ExtractMatch(input, TITLE_PATTERN);

        return commands.Find(title);
    }
}
