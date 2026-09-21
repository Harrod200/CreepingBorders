# UpdateWithdrawTrajectoryLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/UpdateWithdrawTrajectoryLeafNode.cs`.*


## Class `UpdateWithdrawTrajectoryLeafNode`

```csharp
public class UpdateWithdrawTrajectoryLeafNode : LeafNode
```

### Fields

| Name | Type |
|---|---|
| `trajectoryValidUntilTime` | private TIDateTime |

### Methods

```csharp
protected UpdateWithdrawTrajectoryLeafNode()
```

```csharp
public UpdateWithdrawTrajectoryLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```

```csharp
private bool TryAssignWithdrawPosition(float remainingDeltaV)
```

```csharp
private bool TryAssignPathToPosition(Vector3 startPosition, Vector3 endPosition, float scaledCombatRange)
```
