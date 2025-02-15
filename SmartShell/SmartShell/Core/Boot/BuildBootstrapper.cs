using Microsoft.Extensions.DependencyInjection;
using SmartShell.Core.Build;

namespace SmartShell.Core.Boot;

internal class BuildBootstrapper : Bootstrapper
{
    public CommandCollection CommandCollection { get; set; }
    public BuildBootstrapper(CommandCollection commandCollection)
    {
        CommandCollection = commandCollection;
    }

    public override void Register()
    {
        AppServiceProvider.Services.AddSingleton<IBuilder<string>, TitleBuilder>();
        AppServiceProvider.Services.AddSingleton<IBuilder<CommandArgument?>, ArgumentBuilder>();
        AppServiceProvider.Services.AddSingleton<IBuilder<List<CommandOption>?>, OptionsBuilder>();

        AppServiceProvider.Services.AddSingleton<CommandInitializer>();
    }

    public override void Boot()
    {
        CommandInitializer ci = AppServiceProvider.GetRequiredService<CommandInitializer>();

        CommandCollection.Commands.ForEach(cmd => ci.Build(cmd));
    }
}
