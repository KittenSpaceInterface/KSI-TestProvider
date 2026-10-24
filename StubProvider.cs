using Brutal.ImGuiApi;
using Brutal.Numerics;
using KSI.Core.Api.Providers;

namespace KSI.TestProvider;

[KsiUiProvider]
public sealed class StubProvider : IKsiUiProvider
{
    private bool _active;

    public string Id => "KSI-TestProvider";
    public string DisplayName => "Test Interface";

    public void Initialize(IKsiUiContext context) { }
    public void Activate() => _active = true;
    public void Deactivate() => _active = false;

    public void Draw(double deltaTime)
    {
        if (!_active) return;
        ImGui.SetNextWindowPos(ImGui.GetMainViewport().Pos + new float2(24f, 140f), ImGuiCond.FirstUseEver);
        if (ImGui.Begin("KSI Test Interface", ImGuiWindowFlags.AlwaysAutoResize |
            ImGuiWindowFlags.NoSavedSettings))
            ImGui.Text("Independent KSI provider is active.");
        ImGui.End();
    }

    public void DrawOptions() => ImGui.TextWrapped("This provider has no assets, layout, or settings.");
    public void OnKsaLayoutChanged(KsiLayoutSelection? selection) { }
    public void Dispose() => _active = false;
}
