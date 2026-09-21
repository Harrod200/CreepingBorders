# TIMetaTemplate

*Decompiled from `TIMetaTemplate.cs`.*


## Class `TIMetaTemplate`

```csharp
public class TIMetaTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `templateType` | public Type |
| `templateNames` | public List<string> |
| `requiredDLC` | public List<string> |
| `listPriority` | public int |
| `optionPriority` | public int |
| `isNewCampaignOption` | public bool |
| `tutorialAllowed` | public bool |
| `newCampaignOptionCategory` | public string |
| `templatesToUseDefaultLocalization` | public List<string> |
| `scenarioLocalizationPostfix` | public string |

### Methods

```csharp
public TIMetaTemplate()
```

```csharp
public TIMetaTemplate(string templateName)
```

```csharp
public static void LoadMetaTemplates(IEnumerable<string> names)
```

```csharp
public static List<TIDataTemplate> GetTemplatesOfTypeFromMeta(string metaTemplateName, Type t)
```

```csharp
private static void LoadMetaTemplate(string metaTemplateName)
```

```csharp
public static void PostLoadMetaTemplates()
```

```csharp
private static bool ValidateFaction(TIDataTemplate template, Type templateType)
```

```csharp
private static bool ValidateFleet(TIDataTemplate template, Type templateType)
```

```csharp
private static bool ValidateHab(TIDataTemplate template, Type templateType)
```
