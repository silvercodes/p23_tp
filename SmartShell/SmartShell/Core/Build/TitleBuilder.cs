using SmartShell.Core.Parsing;

namespace SmartShell.Core.Build;

internal class TitleBuilder : IBuilder<string>
{
    private const string TITLE_PATTERN = @"^[a-z]+";
    private IParser parser;
    public TitleBuilder(IParser parser)
    {
        this.parser = parser;
    }
    public string? Build(string signature)
    {
        string title = parser.ExtractMatch(signature, TITLE_PATTERN);

        // TODO: throw App Exception

        return title;
    }
}
