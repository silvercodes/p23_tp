namespace SmartShell.Core.Build;

internal class TitleBuilder : IBuilder<string>
{
    public string? Build(string signature)
    {
        Console.WriteLine(signature);

        return "";
    }
}
