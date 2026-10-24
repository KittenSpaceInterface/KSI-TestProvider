using StarMap.API;

namespace KSI.TestProvider;

[StarMapMod]
public sealed class StubMod
{
    [StarMapBeforeMain]
    public void OnBeforeMain() => Console.WriteLine("KSI-TestProvider loaded.");
}
