using System.Text.RegularExpressions;

namespace SmartShell.Core.Parsing;

internal class RegexParser : IParser
{
    public bool Check(string input, string pattern)
    {
        Regex regex = new Regex(pattern);

        return regex.IsMatch(input);
    }
    public string ExtractMatch(string input, string pattern)
    {
        Regex regex = new Regex(pattern);

        return regex.Match(input).Value;
    }

    public string ExtractFirstGroupValue(string input, string pattern)
    {
        Regex regex = new Regex(pattern);

        return regex.Match(input).Groups[1].Value;
    }
}
