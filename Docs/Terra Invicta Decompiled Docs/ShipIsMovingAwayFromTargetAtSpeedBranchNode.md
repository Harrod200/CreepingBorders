# ShipIsMovingAwayFromTargetAtSpeedBranchNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/ShipIsMovingAwayFromTargetAtSpeedBranchNode.cs`.*


## Class `ShipIsMovingAwayFromTargetAtSpeedBranchNode`

```csharp
public class ShipIsMovingAwayFromTargetAtSpeedBranchNode : BranchNode
```

### Methods

```csharp
protected ShipIsMovingAwayFromTargetAtSpeedBranchNode()
```

```csharp
public ShipIsMovingAwayFromTargetAtSpeedBranchNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local, params ITreeNode[] children)
```

```csharp
public override CombatShipBehaviourTree.ConditionResponse Execute()
```

```csharp
protected virtual bool IsMovingAwayFromTarget(CombatantController target)
```
