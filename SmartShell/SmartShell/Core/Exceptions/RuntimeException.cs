namespace SmartShell.Core.Exceptions;

public class RuntimeException: SmartShellException
{
    internal const string CMD_NOT_FOUNT = "Command not found";
    public RuntimeException(string? message, Exception? innerException = null) :
        base(message, innerException)
    { }
}
