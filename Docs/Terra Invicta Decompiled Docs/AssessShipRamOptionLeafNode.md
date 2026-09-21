# AssessShipRamOptionLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/AssessShipRamOptionLeafNode.cs`.*


## Class `AssessShipRamOptionLeafNode`

```csharp
public class AssessShipRamOptionLeafNode : LeafNode
```

### Properties

- `private IShipCommand rammingCommand = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is RammingSpeedCommand);`

### Methods

```csharp
protected AssessShipRamOptionLeafNode()
```

```csharp
public AssessShipRamOptionLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```
