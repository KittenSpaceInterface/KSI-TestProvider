# KSI Test Provider

A deliberately minimal, independent StarMap mod used to validate KSI-Core's
provider boundary. It draws one labelled ImGui window and uses no KSI2 code,
assets, settings, or KSA layout. It is a development fixture, not a release mod.

Build after packing `KSI.Core.Api` 0.2.1 in the sibling `KSI-Core` repository:

```powershell
dotnet restore -p:KsaReferencePath="C:\path\to\Kitten Space Agency"
dotnet build --configuration Release --no-restore -p:KsaReferencePath="C:\path\to\Kitten Space Agency"
```

For an isolated in-game test, install `KSI.TestProvider.dll`, its `.deps.json`,
`mod.toml`, and `KSI.TestProvider.ksi-provider.json` under a
`KSI-TestProvider` mod folder. Enable that mod together with KSI-Core in KSA's
manifest. KSI2 can be enabled at the same time to test switching.
