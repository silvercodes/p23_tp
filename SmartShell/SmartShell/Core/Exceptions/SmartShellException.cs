namespace SmartShell.Core.Exceptions;

public class SmartShellException: Exception
{
    public SmartShellException(string? message, Exception? innerException = null) :
        base(message, innerException)
    { }
}
