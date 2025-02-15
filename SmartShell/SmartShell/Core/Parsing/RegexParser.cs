using System.Text.RegularExpressions;

namespace SmartShell.Core.Parsing;

internal class RegexParser : IParser
{
    public string ExtractMatch(string input, string pattern)
    {
        Regex regex = new Regex(pattern);

        return regex.Match(input).Value;
    }
}
