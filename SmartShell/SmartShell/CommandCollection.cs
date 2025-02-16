using SmartShell.Core.Exceptions;

namespace SmartShell;

public class CommandCollection
{
    internal List<Command> Commands { get; set; }

    public CommandCollection()
    {
        Commands = new List<Command>();
    }

    public void Add(Command command)
    {
        Commands.Add(command);
    }

    public Command Find(string title)
    {
        Command? cmd = Commands.Find(c => c.Title == title);

        if (cmd is null)
            throw new RuntimeException(RuntimeException.CMD_NOT_FOUNT);

        return cmd;
    }
}
