# TIFormationTemplate

*Decompiled from `TIFormationTemplate.cs`.*


## Class `TIFormationTemplate`

```csharp
public class TIFormationTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `filteredPositions` | private List<Vector3d> |
| `clampXpos` | public bool |
| `clampYpos` | public bool |
| `useZoffset` | public bool |
| `patternShift` | public bool |
| `Zoffset` | public float |
| `resetIdx` | public int |
| `pos` | public Vector3[] |
| `AICombatBaseWeight` | public float |
| `AIMaximumAllowedShips` | public int |
| `RoleAssignmentOrderForFormations` | private static readonly List<ShipRole> |
| `relativeShipPositionsCache` | private TIFormationTemplate.RelativeShipPositionsCache |
| `RelativeShipPositionsCache` | private struct |
| `ShipsInFormation` | public List<TISpaceShipState> |
| `Formation` | public Formation |
| `NumberOfPositions` | public int |
| `InvertZForCombat` | public bool |
| `RelativeShipPositions` | public Dictionary<TISpaceShipState, Vector3d> |

### Methods

```csharp
public static Vector3d[] GetSpacingOffset_km(bool isCombatSetup = false, bool forStratLayer = false)
```

```csharp
public double radius_km(FormationSpacing spacing, int ships)
```

```csharp
public Dictionary<TISpaceShipState, Vector3d> RelativeShipPositions_Units(List<TISpaceShipState> shipsInFormation, Formation formation, int numberOfPositions, bool invertZForCombat = false)
```
