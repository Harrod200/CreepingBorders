# FindMissileTargetShipLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/FindMissileTargetShipLeafNode.cs`.*


## Class `FindMissileTargetShipLeafNode`

```csharp
public class FindMissileTargetShipLeafNode : FindTargetShipLeafNode
```

### Fields

| Name | Type |
|---|---|
| `retargetTime` | private TIDateTime |

### Properties

- `private IShipCommand clearTarget = ShipCommandsManager.shipCommands.Find((IShipCommand x) => x is ClearTargetCommand);`

### Methods

```csharp
protected FindMissileTargetShipLeafNode()
```

```csharp
public FindMissileTargetShipLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```

```csharp
private bool TryAssignTarget()
```

```csharp
private void LogMissingTargetCrashData(CombatantController badTarget)
```
