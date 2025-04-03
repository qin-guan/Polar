[assembly: Retry(3)]
[assembly: System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]

namespace Polar.OpenAPI.Tests;

public class GlobalHooks
{
    [Before(TestSession)]
    public static async Task SetUp()
    {
    }

    [After(TestSession)]
    public static void CleanUp()
    {
        Console.WriteLine("...and after!");
    }
}