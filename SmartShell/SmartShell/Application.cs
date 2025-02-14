using SmartShell.Core;

namespace SmartShell;

public class Application
{
    private Kernel kernel = null!;
    public CommandCollection Commands { get; set; }
    public Application()
    {
        Commands = new CommandCollection();
    }
    public void Run()
    {
        // TODO: Create specific kernel by condition
        kernel = new ConsoleKernel(Commands);

        kernel.Handle();
    }
}
