# TIMapRegionTemplate

*Decompiled from `TIMapRegionTemplate.cs`.*


## Class `TIMapRegionTemplate`

```csharp
public class TIMapRegionTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `smallRegion` | public bool |
| `displayName` | public override string |
| `terrain` | public TerrainType |
| `supraRegion` | public SupraRegion |
| `coast` | public CoastRegion |
| `island` | public bool |
| `latitude` | public float |
| `longitude` | public float |
| `boostLatitude` | public float |
| `solarBody` | public string |
| `verticalRegion` | public bool |
| `area_km2` | public float |
| `visualId` | public int |
| `parent` | public string |
| `oilId` | public int |
| `_defaultSeaTravelModifiers` | private static readonly Dictionary<CoastRegion, Dictionary<CoastRegion, float>> |
| `ClosedSuezDelay` | public const float |
| `ClosedPanamaDelay` | public const float |

### Methods

```csharp
public static float GetSeaTravelMultiplier(CoastRegion region1, CoastRegion region2, bool SuezAccess, bool PanamaAccess, bool arcticOpen = false)
```

```csharp
public static bool TurkishStraitRoute(CoastRegion region1, CoastRegion region2)
```

```csharp
public static bool SuezRoute(CoastRegion region1, CoastRegion region2, bool arcticOpen)
```

```csharp
public static bool PanamaRoute(CoastRegion region1, CoastRegion region2, bool arcticOpen)
```
