namespace SmartShell.Core.Runtime;

internal interface IStateLoader
{
    public void LoadState(Command cmd, string input);
}
