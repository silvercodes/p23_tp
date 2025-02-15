using Microsoft.Extensions.DependencyInjection;

namespace SmartShell.Core;

internal static class AppServiceProvider
{
    public static IServiceCollection Services { get; set; }
    private static IServiceProvider Provider { get; set; } = null!;

    static AppServiceProvider()
    {
        Services = new ServiceCollection();
    }
    public static void BuildProvider()
    {
        Provider = Services.BuildServiceProvider();
    }
    public static T? GetService<T>()
    {
        return Provider.GetService<T>();
    }
    public static T GetRequiredService<T>()
        where T : notnull
    {
        return Provider.GetRequiredService<T>();
    }
}
