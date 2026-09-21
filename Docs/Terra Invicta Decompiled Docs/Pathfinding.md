# Pathfinding

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/PathFinding/Pathfinding.cs`.*


## Class `Pathfinding`

```csharp
public class Pathfinding
```

### Fields

| Name | Type |
|---|---|
| `_navVolume` | private OcTree |

### Methods

```csharp
public Pathfinding(OcTree navVol)
```

```csharp
public void FindPath(Vector3 startPosition, Vector3 startHeading, Vector3 endPosition, CombatFleetController agents, ref Vector3[] positions)
```

```csharp
private void GetNeighbourNode(Vector3 point, out OcTreeNode node)
```

```csharp
private float EvaluateScoreForNode(OcTreeNode node, Vector3 target, CombatFleetController agents)
```
