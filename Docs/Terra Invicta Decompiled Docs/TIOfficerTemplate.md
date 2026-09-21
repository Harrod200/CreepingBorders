# TIOfficerTemplate

*Decompiled from `TIOfficerTemplate.cs`.*


## Class `TIOfficerTemplate`

```csharp
public class TIOfficerTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `description` | public string |
| `MaxOfficerLevel` | public const int |
| `spawnEventType` | public OfficerSpawnEventType |
| `spawnChance` | public float |
| `baseIconPath` | public string |
| `requirements` | public List<OfficerRequirement> |
| `effects` | public List<OfficerEffect> |
| `location` | public ShipSystem |
| `sortOrder` | public int |
| `_cachedEffectsByLevel` | private Dictionary<int, List<OfficerEffect>> |
| `OfficerEffectOperation` | public static readonly Dictionary<OfficerEffectType, StatModSetOperation> |

### Methods

```csharp
public override TIGameState CreateGameState()
```

```csharp
public List<OfficerEffect> GetOfficerEffectsByLevel(int level)
```

```csharp
public bool OfficerTypeAllowedForShip(TISpaceShipState candidateShip, bool swap, int additionalProposedTransfersToShip)
```

```csharp
public int MaxOfficersofTypeAllowedForShip()
```

```csharp
public List<OfficerRequirement> OfficerTypeAllowedForShipFailReasons(TISpaceShipState candidateShip, bool swap, int additionalProposedTransfersToShip)
```

```csharp
public List<OfficerEffect> GetOfficerEffects(OfficerEffectType officerEffectType, int level)
```

```csharp
public string GetRankString(int rank)
```

```csharp
public string GetIconPath(int rank)
```

```csharp
public string flagOfficerAndRank(int rank)
```

```csharp
public static string RequirementText(OfficerRequirement req, TIShipHullTemplate hull)
```

```csharp
public string FullDescriptionAtRank(int rank, TIShipHullTemplate hull = null, bool alwaysShowRequirements = false, List<OfficerRequirementType> failReasons = null)
```

```csharp
public string EffectsAtRankString(int rank)
```

```csharp
public static string BuildOfficerPromotionReport(List<TIOfficerState> promotions, TIFactionState forFaction)
```

```csharp
public static string BuildOfficerDeathsReport(List<TIOfficerState> deaths, TIFactionState forFaction)
```
