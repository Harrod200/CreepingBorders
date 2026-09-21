# TIMissionPhaseState

*Decompiled from `PavonisInteractive/TerraInvicta/TIMissionPhaseState.cs`.*


## Class `TIMissionPhaseState`

```csharp
public class TIMissionPhaseState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `nextMissionPhase` | public static TIDateTime |
| `timeToNextMissionPhase_d` | public static double |
| `newCampaignStart` | public bool |
| `promptQueue` | private TIPromptQueueState |
| `factionsSignallingComplete` | public List<TIFactionState> |
| `currentlyResolvingMissions` | public List<TIMissionState> |

### Properties

- `public bool phaseActive`
- `public static float phasesPerMonth`
- `public int resolutionSegmentsPerPhase`
- `public TIDateTime skipTime`
- `public static List<TIMissionTemplate> baseHumanMissions`

### Methods

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostVisualizerCreationInit_6()
```

```csharp
private void StartNewMissionPhase(TimeEventStart e)
```

```csharp
private void ContinueNewMissionPhase(MissionPhasePrepComplete e)
```

```csharp
public void SetMissionPhaseInactive()
```

```csharp
public static bool InMissionPhase()
```

```csharp
private void StartofTurnBookkeeping()
```

```csharp
private void CancelOutstandingMissions()
```

```csharp
public static TIGameState CouncilorLastKnownLocation(TIFactionState inspectingFaction, TICouncilorState councilorState)
```

```csharp
public static List<TICouncilorState> GetVisibleCouncilorsAtLocation(TIFactionState lookingFaction, TIGameState inputLocation, float minimumIntel, float maximumIntel = 1f, bool skipMine = false)
```

```csharp
public bool AllFactionsHaveAssignedMissions()
```

```csharp
public static void UpdatePerMonthTurnFrequency()
```
