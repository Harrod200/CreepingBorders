# UpdateHabModulePowerStatus

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/UpdateHabModulePowerStatus.cs`.*


## Class `UpdateHabModulePowerStatus`

```csharp
public class UpdateHabModulePowerStatus : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `moduleID` | private GameStateID |
| `status` | private bool |
| `callback` | private Action |

### Methods

```csharp
public UpdateHabModulePowerStatus(TIHabModuleState module, bool status, Action callback)
```

```csharp
public override void Execute()
```
