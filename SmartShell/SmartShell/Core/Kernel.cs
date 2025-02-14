using SmartShell.Core.Boot;

namespace SmartShell.Core;

internal abstract class Kernel
{
    protected List<Bootstrapper> Bootstrappers { get; set; }
    protected CommandCollection Commands { get; set; }
    public Kernel(CommandCollection commands)
    {
        commands = new CommandCollection();

        Bootstrappers = new List<Bootstrapper>();

        SetupBootstrappers();

        Bootstrap();

    }

    protected abstract void SetupBootstrappers();

    private void Bootstrap()
    {
        Bootstrappers.ForEach(bootstrapper => bootstrapper.Register());

        AppServiceProvider.BuildProvider();

        Bootstrappers.ForEach(bootstrapper => bootstrapper.Boot());
    }


    public void Handle()
    {

    }
}
