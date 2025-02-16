using Microsoft.Extensions.DependencyInjection;
using SmartShell.Core.IO;

namespace SmartShell.Core.Boot;

internal class ConsoleBootstrapper : Bootstrapper
{
    public override void Register()
    {
        AppServiceProvider.Services.AddSingleton<IInputDriver, ConsoleInputDriver>();
    }
}
