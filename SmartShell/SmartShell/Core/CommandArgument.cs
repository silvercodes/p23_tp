namespace SmartShell.Core;

public class CommandArgument
{
    public string? Title { get; internal set; } = null;
    public bool IsRequired { get; internal set; } = true;
    public string? DefaultValue { get; internal set; } = null;

}
