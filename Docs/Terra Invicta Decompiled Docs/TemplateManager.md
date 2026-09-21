# TemplateManager

*Decompiled from `PavonisInteractive/TerraInvicta/TemplateManager.cs`.*


## Class `TemplateManager`

```csharp
public class TemplateManager
```

### Fields

| Name | Type |
|---|---|
| `Initialized` | public bool |
| `global` | public static TIGlobalConfig |
| `HabModuleTemplates` | public static IEnumerable<TIHabModuleTemplate> |
| `self` | public static readonly TemplateManager |
| `templatesByType` | private readonly IDictionary<Type, Dictionary<string, TIDataTemplate>> |
| `templatesByName` | private readonly IDictionary<string, Dictionary<Type, TIDataTemplate>> |
| `duplicateTemplatesByType` | private readonly IDictionary<Type, Dictionary<string, List<TIDataTemplate>>> |
| `skirmishModeTemplates` | private List<TISpaceShipTemplate> |
| `foundGlobal` | private bool |
| `initialized` | private bool |
| `_global` | private TIGlobalConfig |
| `jController` | private static JsonController |
| `cachedHabModuleTemplates` | private static List<TIHabModuleTemplate> |
| `newTemplateValue` | private int |

### Methods

```csharp
public void LoadMetaOnly(string templatePath)
```

```csharp
public void Initialize(string templatePath)
```

```csharp
public static void InitializeStaticManagers()
```

```csharp
public static void ClearAllTemplates()
```

```csharp
private static void StageModTemplates()
```

```csharp
private void LoadNonVanillaModTemplates()
```

```csharp
public static IEnumerable<T> IterateByClass<T>(bool allowChild = true) where T : TIDataTemplate
```

```csharp
private static IEnumerable<string> GetScenarioTagsCollection(TIDataTemplate template)
```

```csharp
public static void Add<T>(T newTemplate, bool replaceDuplicate = false) where T : TIDataTemplate
```

```csharp
public static void Add(TIDataTemplate newTemplate, Type type, bool replaceDuplicate = false)
```

```csharp
public static void Remove<T>(TIDataTemplate templateToRemove) where T : TIDataTemplate
```

```csharp
public static void Remove(TIDataTemplate templateToRemove, Type type)
```

```csharp
public static void ResolveScenarioTemplates(TIMetaTemplate scenarioTemplate)
```

```csharp
private static void ResolveTaggedTemplates(TIMetaTemplate scenarioTemplate)
```

```csharp
public static void ResolveDuplicateTemplates(TIMetaTemplate scenarioTemplate)
```

```csharp
public static void RegisterEmptyParentTemplates(Type type)
```

```csharp
public static T[] GetAllTemplates<T>(bool allowChild = true) where T : TIDataTemplate
```

```csharp
public static T Find<T>(string templateName, bool allowChild = false) where T : TIDataTemplate
```

```csharp
internal static TIDataTemplate Find(string templateName, Type T, bool allowChild = false)
```

```csharp
private static void ValidateAllTemplates()
```

```csharp
private static void RegisterFileBasedTemplates(string templatePath, bool replaceDuplicates = false)
```

```csharp
private static void RegisterFileBasedTemplate(string templateFile, bool replaceDuplicates = false)
```

```csharp
private static void RegisterClassBasedTemplates()
```

```csharp
private static Type FindDataTemplateType(string templateName, Assembly assembly = null)
```

```csharp
public static string GenerateDataName(string coreString = "generatedDataTemplate")
```

```csharp
public static void AddSkirmishModeTemplate(TISpaceShipTemplate template)
```

```csharp
public static void ClearSkirmishModeTemplates()
```
