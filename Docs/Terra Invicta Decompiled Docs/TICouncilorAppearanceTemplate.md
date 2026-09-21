# TICouncilorAppearanceTemplate

*Decompiled from `TICouncilorAppearanceTemplate.cs`.*


## Class `TICouncilorAppearanceTemplate`

```csharp
public class TICouncilorAppearanceTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `allowedJobs` | public List<TICouncilorTypeTemplate> |
| `enable` | public bool |
| `specific_person` | public bool |
| `idleVideoYoung` | public string |
| `idleVideoOld` | public string |
| `portraitYoung` | public string |
| `portraitOld` | public string |
| `iconYoung` | public string |
| `iconOld` | public string |
| `regionalHeadwear` | public bool |
| `year` | public int? |
| `allowedGenders` | public List<CouncilorGender> |
| `allowedAncestries` | public List<CouncilorAncestry> |
| `allowedJobNames` | public List<string> |
| `ageCutPoint` | public static int |

### Methods

```csharp
public string idleVideo(TICouncilorState councilor)
```

```csharp
public string portrait(TICouncilorState councilor)
```

```csharp
public string icon(TICouncilorState councilor)
```

```csharp
public bool ValidForCharacter(TICouncilorState councilorState, int gameYear, bool requireJobAlignment, bool requireAncestryAlignment, bool requireNotDuplicated)
```

```csharp
public static List<string> AppearanceTemplatesInUse()
```
