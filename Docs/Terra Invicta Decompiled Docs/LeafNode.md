# LeafNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/LeafNode.cs`.*


## Class `LeafNode`

```csharp
public class LeafNode : ITreeNode
```

### Fields

| Name | Type |
|---|---|
| `_parentNode` | protected ITreeNode |
| `_sharedData` | protected CombatShipBehaviourTree.SharedBehaviourData |
| `_localData` | protected CombatShipBehaviourTree.LocalBehaviourData |

### Methods

```csharp
protected LeafNode()
```

```csharp
public LeafNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local)
```

```csharp
public virtual void SetParent(ITreeNode parent)
```

```csharp
public virtual CombatShipBehaviourTree.ConditionResponse Execute()
```
