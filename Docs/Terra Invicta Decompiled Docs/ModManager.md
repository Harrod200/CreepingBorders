# ModManager

*Decompiled from `PavonisInteractive/TerraInvicta/Modding/ModManager.cs`.*


## Class `ModManager`

```csharp
public class ModManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `jsonController` | private JsonController |
| `modMenuController` | private ModMenuController |
| `modMapper` | private ModMapper |
| `jsonMods` | public List<JsonMod> |
| `conflictingMods` | private HashSet<Mod> |
| `localizationPath` | private string |
| `disabledModFiles` | private List<string> |
| `ModDirectories` | public static List<string> |
| `DisabledModDirectories` | public static List<string> |
| `ModAssetBundles` | public static List<string> |
| `ModAssetBundleManifestFiles` | public static List<string> |
| `ModNames` | public static List<string> |
| `DisabledModNames` | public static List<string> |
| `checkedForModUpdates` | public static bool |
| `dlcDirectories` | public static List<string> |
| `dlcAssetbundles` | public static List<string> |
| `dlcAssetbundleManifestFiles` | public static List<string> |
| `dlcNames` | public static List<string> |
| `hitFailure` | private bool |

### Properties

- `public static readonly string[] WorkshopTags = new string[]`

### Methods

```csharp
private void Start()
```

```csharp
public List<string> GetDisabledModFiles()
```

```csharp
public List<string> GetEnabledModFiles()
```

```csharp
public void DisableMod(string mod)
```

```csharp
public void EnableMod(string mod)
```

```csharp
public void DeleteMod(string mod)
```

```csharp
public static void TryRemoveMod(string mod)
```

```csharp
private void ResetOldMods()
```

```csharp
public void LoadJsonMods()
```

```csharp
public List<JsonMod> GetModsForTemplate(string fileName)
```

```csharp
private void ActivateMods()
```

```csharp
private void ActivateJsonMods()
```

```csharp
private void GetModsConflict(ModType modType)
```
