# RootNode

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/AI/RootNode.cs`.*


## Class `RootNode`

```csharp
public class RootNode : ITreeNode
```

### Fields

| Name | Type |
|---|---|
| `_childNodes` | protected ITreeNode[] |
| `_sharedData` | protected CombatShipBehaviourTree.SharedBehaviourData |
| `_localData` | protected CombatShipBehaviourTree.LocalBehaviourData |

### Methods

```csharp
protected RootNode()
```

```csharp
public RootNode(CombatShipBehaviourTree.SharedBehaviourData shared, CombatShipBehaviourTree.LocalBehaviourData local, params ITreeNode[] children)
```

```csharp
public virtual void SetParent(ITreeNode parent)
```

```csharp
public virtual CombatShipBehaviourTree.ConditionResponse Execute()
```
