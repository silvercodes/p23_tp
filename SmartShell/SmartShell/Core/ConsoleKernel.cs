﻿using SmartShell.Core.Boot;

namespace SmartShell.Core;

internal class ConsoleKernel : Kernel
{
    public ConsoleKernel(CommandCollection commands) 
        : base(commands)
    {
    }

    protected override void SetupBootstrappers()
    {
        Bootstrappers.Add(new AppBootstrapper());
        Bootstrappers.Add(new BuildBootstrapper(Commands));
        Bootstrappers.Add(new ParsingBootstrapper());
        //
        Bootstrappers.Add(new ConsoleBootstrapper());
    }
}
