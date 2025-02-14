namespace SmartShell.Core.Boot;

internal abstract class Bootstrapper
{
    public abstract void Register();
    public virtual void Boot()
    { }
}
