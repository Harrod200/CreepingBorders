# ModTemplateManager

*Decompiled from `PavonisInteractive/TerraInvicta/ModTemplateManager.cs`.*


## Class `ModTemplateManager`

```csharp
public class ModTemplateManager
```

### Fields

| Name | Type |
|---|---|
| `jsonMods` | public static List<JsonMod> |
| `jsonDLCs` | public static List<JsonMod> |
| `jsonController` | private static JsonController |
| `disabledModFiles` | private static List<string> |
| `nameListModPaths` | public static List<string> |
| `FMODBankModPaths` | public static List<string> |
| `NameListModInfo` | public class |
| `path` | public string |
| `loadOrder` | public int |
| `FmodBankModInfo` | public class |
| `path` | public string |
| `loadOrder` | public int |

### Methods

```csharp
public static void LoadJsonFromDLC()
```

```csharp
public static void LoadJsonMods()
```

```csharp
public static void LoadNameListMods()
```

```csharp
public static void LoadFMODBankMods()
```

```csharp
public static List<JsonMod> GetModsForTemplate(string fileName)
```

```csharp
public static List<JsonMod> GetDLCForTemplate(string fileName)
```

```csharp
public static List<string> GetDLCContent(bool logging = true)
```

```csharp
public static List<string> GetEnabledModFiles(bool logging = true)
```
