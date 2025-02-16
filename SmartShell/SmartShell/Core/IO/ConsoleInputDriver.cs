namespace SmartShell.Core.IO;

internal class ConsoleInputDriver : IInputDriver
{
    public string? Receive()
    {
        // TODO: mock!
        Console.Write("> ");

        return Console.ReadLine();
    }
}
