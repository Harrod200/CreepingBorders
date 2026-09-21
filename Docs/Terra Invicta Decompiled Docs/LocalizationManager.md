# LocalizationManager

*Decompiled from `PavonisInteractive/TerraInvicta/LocalizationManager.cs`.*


## Class `LocalizationManager`

```csharp
public class LocalizationManager
```

### Fields

| Name | Type |
|---|---|
| `currentLanguageKey` | public string |
| `currentFontKey` | public string |
| `languageHeaderFont` | private TMP_FontAsset |
| `languageBodyFont` | private TMP_FontAsset |
| `languages` | private readonly IDictionary<string, IDictionary<string, string>> |
| `currentLanguage` | private IDictionary<string, string> |
| `logInvalidEntryError` | private bool |
| `logInvalidEntryWarning` | private bool |
| `testArgs` | private List<string> |
| `locs` | private Dictionary<string, string> |
| `badStringErrors` | private StringBuilder |
| `badStringWarnings` | private StringBuilder |

### Properties

- `public TILocalizationTemplate currentLocalizationTemplate`
- `public TILocalizationTemplate priorLocalizationTemplate`
- `private const string InvalidEntry = "Invalid localization entry (`

### Methods

```csharp
public LocalizationManager()
```

```csharp
private void ProcessLocEntry(string filename, bool moddedLoc = false)
```

```csharp
public void SetLanguage(string name)
```

```csharp
public bool IsLanguageActive(string name)
```

```csharp
public ICollection<string> Languages()
```

```csharp
public string Find(string key)
```

```csharp
public string Find(string key, params object[] args)
```

```csharp
public string Find_Fallback(string key, string fallbackKey)
```

```csharp
public string Find_Fallback(string key, string fallbackKey, params object[] args)
```

```csharp
public string Test(string value, params object[] args)
```

```csharp
public List<string> FindAllKeys(string substring)
```

```csharp
public TMP_FontAsset GetHeaderFontAsset()
```

```csharp
public TMP_FontAsset GetBodyFontAsset()
```

```csharp
public void LoadRequiredLanguageFonts(string name)
```

```csharp
private void LogInvalidEntry(string filename, int lineNumber, string line, int errorCode, bool error = false)
```

```csharp
private string GetKeyValue(string key)
```
