namespace SmartShell.Core.Parsing;

internal interface IParser
{
    public bool Check(string input, string pattern);
    public string ExtractMatch(string input, string pattern);
    public string ExtractFirstGroupValue(string input, string pattern);
}
