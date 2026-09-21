# CheckRadiatorsLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/CheckRadiatorsLeafNode.cs`.*


## Class `CheckRadiatorsLeafNode`

```csharp
public class CheckRadiatorsLeafNode : LeafNode
```

### Properties

- `private IShipCommand retractCommand = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is RetractRadiatorsCommand);`
- `private IShipCommand extendCommand = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is ExtendRadiatorsCommand);`

### Methods

```csharp
protected CheckRadiatorsLeafNode()
```

```csharp
public CheckRadiatorsLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```
