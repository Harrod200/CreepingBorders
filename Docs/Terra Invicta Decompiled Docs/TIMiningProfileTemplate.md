# TIMiningProfileTemplate

*Decompiled from `TIMiningProfileTemplate.cs`.*


## Class `TIMiningProfileTemplate`

```csharp
public class TIMiningProfileTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `description` | public string |
| `modifyBySize` | public bool |
| `modelValue` | public int |
| `water_mean` | public float |
| `water_width` | public float |
| `water_min` | public float |
| `water_jump` | public float |
| `volatiles_mean` | public float |
| `volatiles_width` | public float |
| `volatiles_min` | public float |
| `volatiles_jump` | public float |
| `metals_mean` | public float |
| `metals_width` | public float |
| `metals_min` | public float |
| `metals_jump` | public float |
| `nobles_mean` | public float |
| `nobles_width` | public float |
| `nobles_min` | public float |
| `nobles_jump` | public float |
| `fissiles_mean` | public float |
| `fissiles_width` | public float |
| `fissiles_min` | public float |
| `fissiles_jump` | public float |

### Methods

```csharp
public bool ZeroInBaseRange(FactionResource resource)
```

```csharp
public static SiteProfileRating GetSiteProfileRating(float mean, float width, float min, float globalCap, bool prospected)
```

```csharp
public string GetProfileRatingIconPath(FactionResource resource, bool inline, bool prospected)
```
