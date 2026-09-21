# AssessShipCanMoveLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/AssessShipCanMoveLeafNode.cs`.*


## Class `AssessShipCanMoveLeafNode`

```csharp
public class AssessShipCanMoveLeafNode : LeafNode
```

### Properties

- `private IShipCommand disengageCommand = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is DisengageCommand);`

### Methods

```csharp
protected AssessShipCanMoveLeafNode()
```

```csharp
public AssessShipCanMoveLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```
