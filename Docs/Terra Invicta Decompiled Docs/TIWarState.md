# TIWarState

*Decompiled from `PavonisInteractive/TerraInvicta/TIWarState.cs`.*


## Class `TIWarState`

```csharp
public class TIWarState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `attackingAllianceLeader` | public TINationState |
| `defendingAllianceLeader` | public TINationState |
| `allBelligerents` | public List<TINationState> |
| `displayNameWithArticle` | public string |
| `isWarState` | public override bool |
| `ref_war` | public override TIWarState |
| `stalemate` | public bool |
| `stalemateDuration_days` | public float |
| `ref_factions` | public override List<TIFactionState> |
| `attackingAlliance` | public IReadOnlyList<TINationState> |
| `defendingAlliance` | public IReadOnlyList<TINationState> |
| `peaceOfferHistory` | private Dictionary<TINationState, List<TIDateTime>> |
| `_attackingAlliance` | private List<TINationState> |
| `_defendingAlliance` | private List<TINationState> |
| `stalemate_days` | public const float |
| `cohesionGainByNation` | public Dictionary<TINationState, float> |

### Properties

- `public TINationState originalAttacker`
- `public TINationState originalDefender`
- `public TINationState attacker`
- `public TINationState defender`
- `public TIDateTime startDate`
- `public List<TIRegionState> nukedRegions`
- `public List<TIRegionState> annexedRegions`
- `public int defensiveNukes`
- `public TIDateTime dateOfLastFighting`

### Methods

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public void SetWarData(TINationState attacker, TINationState defender, List<TINationState> attackingAlliance, List<TINationState> defendingAlliance, TIDateTime startDate)
```

```csharp
public bool DuplicateWar(TIWarState war)
```

```csharp
public TIWarState AgglomerateDuplicateWars()
```

```csharp
public void JoinAttackers(TINationState nation)
```

```csharp
public void JoinDefenders(TINationState nation)
```

```csharp
public bool LeaveWar(TINationState nation)
```

```csharp
private bool LeaveAttackers(TINationState nation)
```

```csharp
private bool LeaveDefenders(TINationState nation)
```

```csharp
public List<TINationState> WarLeaders()
```

```csharp
public List<TINationState> WarNationsWithNavalFreedom()
```

```csharp
public TINationState AllianceWarLeader(TINationState nation)
```

```csharp
public IReadOnlyList<TINationState> Alliance(TINationState nation)
```

```csharp
public IReadOnlyList<TINationState> ProspectiveAlliance(TINationState nation)
```

```csharp
public TINationState EnemyWarLeader(TINationState nation, bool includeNonWarringAlliances = false)
```

```csharp
public IReadOnlyList<TINationState> EnemyAlliance(TINationState nation)
```

```csharp
public IReadOnlyList<TINationState> ProspectiveEnemyAlliance(TINationState nation)
```

```csharp
public void TallyDefensiveNuke()
```

```csharp
public void AddNukedRegion(TIRegionState region)
```

```csharp
public void LogPeaceOffer(TINationState offerer)
```

```csharp
public IEnumerable<TIDateTime> GetPeaceOffers(TINationState offerer)
```

```csharp
public void FightingOccurs()
```

```csharp
public List<TIRegionState> ActiveOccupations(TINationState allianceMember, bool includeIncompleteOccupations, bool includeLiberations)
```
