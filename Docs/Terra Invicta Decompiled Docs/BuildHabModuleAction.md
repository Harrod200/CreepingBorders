# BuildHabModuleAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/BuildHabModuleAction.cs`.*


## Class `BuildHabModuleAction`

```csharp
public class BuildHabModuleAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `moduleTemplate` | private TIHabModuleTemplate |
| `sectorID` | private GameStateID |
| `slot` | private int |
| `cost` | private TIResourcesCost |
| `callback` | private Action |

### Methods

```csharp
public BuildHabModuleAction(TIHabModuleTemplate moduleTemplate, TISectorState sector, int slot, TIResourcesCost cost, Action callback = null)
```

```csharp
public override void Execute()
```
