# NationAI_SetPriority

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/NationAI_SetPriority.cs`.*


## Class `NationAI_SetPriority`

```csharp
public class NationAI_SetPriority : SimulationAction
```

### Fields

| Name | Type |
|---|---|
| `controlPointID` | private GameStateID |
| `priority` | private PriorityType |
| `onlyIfHigher` | private bool |
| `value` | private int |

### Methods

```csharp
public NationAI_SetPriority(TIControlPoint controlPoint, PriorityType priority, int value, bool onlyIfHigher)
```

```csharp
public override void Execute()
```
