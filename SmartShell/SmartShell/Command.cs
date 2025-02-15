using SmartShell.Core;

namespace SmartShell;

public abstract class Command
{
    public abstract string Signature { get; }
    public string? Title { get; internal set; } = null;
    public CommandArgument? Argument { get; internal set; } = null;
    public List<CommandOption>? Options { get; internal set; } = null;

    public abstract void Execute();
}
