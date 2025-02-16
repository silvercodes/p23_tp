namespace SmartShell.Core.Exceptions;

public class BuildException: SmartShellException
{
    internal const string BUILD_CMD_INVALID_TITLE = "Command title is invalid or not found";
    internal const string BUILD_ARG_INVALID_SYNTAX = "Command argument signature syntax is invalid";
    public BuildException(string? message, Exception? innerException = null) :
        base(message, innerException)
    { }
}
