# PurchaseOrgAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/PurchaseOrgAction.cs`.*


## Class `PurchaseOrgAction`

```csharp
public class PurchaseOrgAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `factionID` | private GameStateID |
| `councilorID` | private GameStateID |
| `orgID` | private GameStateID |
| `straightToPool` | private bool |

### Methods

```csharp
public PurchaseOrgAction(TIOrgState org, TIFactionState faction, TICouncilorState councilor)
```

```csharp
public override void Execute()
```

```csharp
public TIOrgState GetOrg()
```

```csharp
public bool HasAssignment()
```

```csharp
public TICouncilorState GetCouncilorAssignment()
```
