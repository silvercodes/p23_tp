using SmartShell;

Application app = new Application();
app.Commands.Add(new CleanCommand());
//
//
app.Run();


class CleanCommand: Command
{
    public override string Signature => @"clean {path} {--R|report=`report.txt`-->Make report}";

    public override void Execute()
    {
        Console.WriteLine("CleanCommand Executed....");
    }
}


