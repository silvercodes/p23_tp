namespace SmartShell.Core.Build;

internal interface IBuilder<T>
{
    public T? Build(string signature);
}
