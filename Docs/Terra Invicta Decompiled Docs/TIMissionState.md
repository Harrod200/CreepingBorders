# TIMissionState

*Decompiled from `PavonisInteractive/TerraInvicta/TIMissionState.cs`.*


## Class `TIMissionState`

```csharp
public class TIMissionState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `ref_faction` | public override TIFactionState |
| `ref_hab` | public override TIHabState |
| `ref_nation` | public override TINationState |
| `ref_region` | public override TIRegionState |
| `ref_fleet` | public override TISpaceFleetState |
| `ref_orbit` | public override TIOrbitState |
| `ref_controlPoint` | public override TIControlPoint |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_councilor` | public override TICouncilorState |
| `getMissionEventName` | public string |
| `getDetectEventName` | public string |
| `missionTemplate` | public TIMissionTemplate |
| `getResolutionOrder` | public float |
| `targetLocation` | public TIGameState |
| `resources` | public float |
| `resolveTimeAssigned` | public bool |
| `startTime` | public TIDateTime |
| `resolveTime` | public TIDateTime |
| `target` | public TIGameState |
| `councilor` | public TICouncilorState |
| `missionOutcome` | public TIMissionOutcome |
| `_missionTemplate` | protected TIMissionTemplate |
| `detectionScaling` | private const float |
| `failureChanceAtBalance` | private const float |
| `AbortReason` | public enum |

### Methods

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public new TIMissionTemplate GetMyTemplate()
```

```csharp
public TIGameState GetInitialMissionLocation()
```

```csharp
public void ListenForResolutionTime()
```

```csharp
public void MissionResolved()
```

```csharp
public void ResolveMissionOrder(TimeEventStart e)
```

```csharp
public float GetSuccessChance()
```

```csharp
public static string DumpModifiers(TIMissionTemplate missionTemplate, TICouncilorState councilor, TIGameState target, float resources, string missionTemplateName = "")
```

```csharp
public MissionResult ResolveMission(TIMissionState.AbortReason abortReason = TIMissionState.AbortReason.None, string abortReasonDetail = "")
```

```csharp
public float MissionNoise(TIMissionOutcome outcome)
```

```csharp
private void DetectionPhase(TICouncilorState thisMissionCouncilor, MissionResult result, TICouncilorState missionTargetCouncilor, TIFactionState missionTargetFaction)
```

```csharp
public void DetectCouncilor(TIFactionState detectingFaction, TICouncilorState detectedCouncilor, float roll, float chance, MissionResult result)
```
