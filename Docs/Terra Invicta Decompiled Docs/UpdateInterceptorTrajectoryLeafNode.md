# UpdateInterceptorTrajectoryLeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/UpdateInterceptorTrajectoryLeafNode.cs`.*


## Class `UpdateInterceptorTrajectoryLeafNode`

```csharp
public class UpdateInterceptorTrajectoryLeafNode : LeafNode
```

### Fields

| Name | Type |
|---|---|
| `trajectoryValidUntilTime` | private TIDateTime |

### Methods

```csharp
protected UpdateInterceptorTrajectoryLeafNode()
```

```csharp
public UpdateInterceptorTrajectoryLeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```

```csharp
private bool AssignOffensivePosition(float remainingDeltaV)
```

```csharp
private bool TryAssignPathToTarget(Vector3 position, Vector3 velocity, float scaledCombatRange)
```

```csharp
private void FilterForImminentImpactThreats(ref List<ProjectileController> projectiles)
```
