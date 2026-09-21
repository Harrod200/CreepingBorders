# TIControlPoint

*Decompiled from `PavonisInteractive/TerraInvicta/TIControlPoint.cs`.*


## Class `TIControlPoint`

```csharp
public class TIControlPoint : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `isControlPointState` | public override bool |
| `ref_faction` | public override TIFactionState |
| `ref_nation` | public override TINationState |
| `ref_region` | public override TIRegionState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_controlPoint` | public override TIControlPoint |
| `hasMapObject` | public override bool |
| `owned` | public bool |
| `executive` | public bool |
| `description` | public string |
| `nextOpenControlPoint` | public bool |
| `ExecutiveImmunity` | public bool |
| `armies` | public List<TIArmyState> |
| `numArmies` | public int |
| `ideology` | public FactionIdeology |
| `controlPointTypeDisplayName` | public string |
| `BaselineMaintenanceCost` | public float |
| `CurrentMaintenanceCost` | public float |
| `minPriorityValue` | public const int |
| `maxPriorityValue` | public const int |
| `positionInNation` | public int |
| `controlPointPriorities` | public Dictionary<PriorityType, int> |
| `gameStateSubjectCreated` | private bool |
| `gameTime` | private GameTimeManager |
| `diversityBonus` | public Dictionary<PriorityType, float> |
| `priorityDiversityBonus` | public static readonly Dictionary<PriorityType, float> |

### Properties

- `public TINationState nation`
- `public TIFactionState faction`
- `public bool benefitsDisabled`
- `public bool defended`
- `public TIDateTime crackdownExpiration`
- `public TIDateTime defendExpiration`
- `public ControlPointType controlPointType`
- `public int totalWeightsForControlPoint`
- `public int numPrioritiesWithWeight`

### Methods

```csharp
public bool EnemyFactionControlPoint(TIFactionState otherFaction)
```

```csharp
public bool CanBeAttacked(TIFactionState faction)
```

```csharp
public bool CanBeEnthralled()
```

```csharp
public bool CanBeTerrorized()
```

```csharp
public void InitWithNationState(TINationState nation, int position)
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostVisualizerCreationInit_6()
```

```csharp
private void RepairOwnership()
```

```csharp
public void SetFaction(TIFactionState newFaction, bool newCampaign = false)
```

```csharp
public List<TIArmyState> RemoveControlPointFromNation()
```

```csharp
public void SetControlPointType()
```

```csharp
public void SetDisplayName()
```

```csharp
public static TIDateTime FindMissionPhaseAfter(TIDateTime inputDate)
```

```csharp
public TIDateTime ResolveCrackdownEffect(int duration_months, TIFactionState crackingFaction, bool voluntary = false, bool skipLogging = false, float hate = 0f)
```

```csharp
public void ReenableBenefits()
```

```csharp
public void EnableBenefits()
```

```csharp
private void SetCrackdownExpiry(TIDateTime expiry)
```

```csharp
public string ResolveDefendControlPointEffect(int duration_days)
```

```csharp
public void ExpireDefense()
```

```csharp
public void EndControlPointDefense()
```

```csharp
public int GetControlPointPriority(PriorityType priority, bool checkValid)
```

```csharp
public void SyncAllPriorities(TIControlPoint sourceCP)
```

```csharp
public void RecordAndFixControlPointValues(bool alertReset)
```

```csharp
public int SetControlPointPriority(PriorityType priority, int value, bool skipUpdate = false, bool bulkUpdate = false, bool alertReset = false)
```

```csharp
private void ChangeControlPointPriority(PriorityType priority, int delta, bool cycle)
```

```csharp
public void IncrementControlPointPriority(PriorityType priority)
```

```csharp
public void DecrementControlPointPriority(PriorityType priority)
```

```csharp
public string GetIconPath(bool small64)
```

```csharp
public Sprite GetIcon(bool forUI, bool largeUI)
```

```csharp
public string GetIllustrationPath()
```
