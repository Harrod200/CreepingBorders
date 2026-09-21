# TIRegionAlienActivityState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionAlienActivityState.cs`.*


## Class `TIRegionAlienActivityState`

```csharp
public class TIRegionAlienActivityState : TIRegionAlienEntityState
```

### Fields

| Name | Type |
|---|---|
| `ref_regionAlienActivity` | public override TIRegionAlienActivityState |
| `isRegionAlienActivity` | public override bool |
| `alienMissionsDetected` | protected Dictionary<TIFactionState, List<string>> |

### Methods

```csharp
public void InitWithRegionState(TIRegionState region)
```

```csharp
public override void PostAllStartUpInit_5()
```

```csharp
public override bool Extant()
```

```csharp
public override string GetIconResourcePath(TIFactionState faction)
```

```csharp
public override string GetIllustrationPath(TIFactionState faction)
```

```csharp
private string timeEventName(TIFactionState faction, string mission)
```

```csharp
public void ActivitySightedByFaction(TIFactionState faction, TIMissionTemplate missionTemplate, TICouncilorState targetCouncilor, TIFactionState targetFaction, TIMissionState mission = null)
```

```csharp
public void ScheduledActivityExpiration(TimeEventStart e)
```

```csharp
public void RemoveMissionFromActivity(TIFactionState faction, string mission)
```

```csharp
public void RemoveActivity(TIFactionState faction)
```

```csharp
public override bool VisibleToFaction(TIFactionState faction)
```

```csharp
public List<string> GetMissionList(TIFactionState faction)
```

```csharp
public bool MissionDetectedByFaction(TIFactionState faction, string missionDataName)
```
