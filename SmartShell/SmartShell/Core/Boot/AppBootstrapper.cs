using Microsoft.Extensions.DependencyInjection;
using SmartShell.Core.Runtime;

namespace SmartShell.Core.Boot;

internal class AppBootstrapper : Bootstrapper
{
    public override void Register()
    {
        AppServiceProvider.Services.AddSingleton<RuntimeController>();
        AppServiceProvider.Services.AddSingleton<IStateLoader, DefaultStateLoader>();
    }
}
