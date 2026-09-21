# SellOrgAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SellOrgAction.cs`.*


## Class `SellOrgAction`

```csharp
public class SellOrgAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `councilID` | private GameStateID |
| `councilorID` | private GameStateID |
| `orgID` | private GameStateID |
| `poolSell` | private bool |

### Methods

```csharp
public SellOrgAction(TIOrgState org, TIFactionState council, TICouncilorState councilor = null)
```

```csharp
public override void Execute()
```

```csharp
public TIOrgState GetOrg()
```
