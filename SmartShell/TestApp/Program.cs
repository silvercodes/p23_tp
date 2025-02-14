using SmartShell;

Application app = new Application();
app.Commands.Add(new CleanCommand());
//
//
app.Run();


class CleanCommand: Command
{

}


