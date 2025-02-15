namespace SmartShell.Core.Parsing;

internal interface IParser
{
    public string ExtractMatch(string input, string pattern);
}
