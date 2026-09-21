# Loc

*Decompiled from `PavonisInteractive/TerraInvicta/Loc.cs`.*


## Class `Loc`

```csharp
public static class Loc
```

### Fields

| Name | Type |
|---|---|
| `OnLanguageChangedEvent` | public static event Action |
| `CurrentLanguage` | public static string |
| `currentLocalizationTemplate` | public static TILocalizationTemplate |
| `priorLocalizationTemplate` | public static TILocalizationTemplate |
| `CurrentHeaderFont` | public static TMP_FontAsset |
| `CurrentBodyFont` | public static TMP_FontAsset |
| `localizationManager` | private static readonly LocalizationManager |

### Methods

```csharp
public static string T(string key)
```

```csharp
public static string T(string key, params object[] args)
```

```csharp
public static string T_Scenario(string key)
```

```csharp
public static string T_Scenario(string key, params object[] args)
```

```csharp
public static ICollection<string> Languages()
```

```csharp
public static List<string> FindAllKeys(string substring)
```

```csharp
public static void SetLanguage(string name)
```

```csharp
public static string defaultLanguage()
```

```csharp
public static string GetDefaultLanguageKey()
```

```csharp
public static void SwapFonts(GameObject gameObject)
```
