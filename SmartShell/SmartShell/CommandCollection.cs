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
}
