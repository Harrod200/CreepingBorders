# AssessDisengageOptionLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/AssessDisengageOptionLeafNode.cs`.*


## Class `AssessDisengageOptionLeafNode`

```csharp
public class AssessDisengageOptionLeafNode : LeafNode
```

### Fields

| Name | Type |
|---|---|
| `extremeDistance_scale_sqrMag` | private float |
| `disengagementDistance_scale_sqrMag` | private float |

### Properties

- `private IShipCommand disengageCommand = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is DisengageCommand);`

### Methods

```csharp
protected AssessDisengageOptionLeafNode()
```

```csharp
public AssessDisengageOptionLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```
