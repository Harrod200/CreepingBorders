# AbortMission

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/AbortMission.cs`.*


## Class `AbortMission`

```csharp
public class AbortMission : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `councilorID` | private GameStateID |
| `missionID` | private GameStateID |
| `postProcessAbort` | private bool |
| `reason` | private TIMissionState.AbortReason |
| `abortDetail` | private string |

### Methods

```csharp
public AbortMission(TICouncilorState councilor, bool postProcessAbort, TIMissionState.AbortReason reason, TIMissionState mission = null, string abortDetail = "")
```

```csharp
public override void Execute()
```
