# UpdateShipTrajectoryLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/UpdateShipTrajectoryLeafNode.cs`.*


## Class `UpdateShipTrajectoryLeafNode`

```csharp
public class UpdateShipTrajectoryLeafNode : LeafNode
```

### Fields

| Name | Type |
|---|---|
| `trajectoryValidUntilTime` | private TIDateTime |

### Methods

```csharp
protected UpdateShipTrajectoryLeafNode()
```

```csharp
public UpdateShipTrajectoryLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```

```csharp
private bool TryAssignDefensivePosition(List<ProjectileController> threateningProjectiles)
```

```csharp
private bool AssignOffensivePosition()
```

```csharp
private bool TryAssignPathToTarget(Vector3 position, Vector3 velocity, float scaledCombatRange)
```

```csharp
private bool TryAssignPathToPosition(Vector3 startPosition, Vector3 endPosition, float scaledCombatRange)
```
