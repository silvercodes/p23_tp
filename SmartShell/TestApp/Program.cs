using SmartShell;
using SmartShell.Core.Exceptions;

try
{
	Application app = new Application();
	app.Commands.Add(new CleanCommand());
	//
	//
	app.Run();
}
catch (SmartShellException ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}


class CleanCommand: Command
{
    public override string Signature => @"clean {path=C:\My docs\11.txt} {--R|report=`report.txt`-->Make report}";

    public override void Execute()
    {
        Console.WriteLine("CleanCommand Executed....");
    }
}


