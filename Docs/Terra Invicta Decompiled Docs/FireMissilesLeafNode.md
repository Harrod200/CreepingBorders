# FireMissilesLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/FireMissilesLeafNode.cs`.*


## Class `FireMissilesLeafNode`

```csharp
public class FireMissilesLeafNode : LeafNode
```

### Properties

- `private IShipCommand selectTarget = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is SelectSalvoTargetCommand);`
- `private IShipCommand clearTarget = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is ClearTargetCommand);`

### Methods

```csharp
protected FireMissilesLeafNode()
```

```csharp
public FireMissilesLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```
