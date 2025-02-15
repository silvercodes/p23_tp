using Microsoft.Extensions.DependencyInjection;
using SmartShell.Core.Parsing;

namespace SmartShell.Core.Boot;

internal class ParsingBootstrapper : Bootstrapper
{
    public override void Register()
    {
        AppServiceProvider.Services.AddSingleton<IParser, RegexParser>();
    }
}
