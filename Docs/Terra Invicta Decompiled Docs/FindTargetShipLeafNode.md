# FindTargetShipLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/FindTargetShipLeafNode.cs`.*


## Class `FindTargetShipLeafNode`

```csharp
public class FindTargetShipLeafNode : LeafNode
```

### Properties

- `private IShipCommand selectTarget = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is SelectTargetCommand);`
- `private IShipCommand clearTarget = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is ClearTargetCommand);`

### Methods

```csharp
protected FindTargetShipLeafNode()
```

```csharp
public FindTargetShipLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```

```csharp
protected virtual bool TryAssignTargetShip()
```

```csharp
protected virtual bool TryAssignTargetModule()
```
