using System.IO;
using System.Reflection;

namespace Astrolune.UI;

public static class FrontendResourceProvider
{
    private static readonly Assembly Assembly = typeof(FrontendResourceProvider).Assembly;

    public static Stream? GetResourceStream(string resourceName)
    {
        var fullName = $"Astrolune.UI.Resources.{resourceName}";
        return Assembly.GetManifestResourceStream(fullName);
    }
}
