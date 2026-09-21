# TISpaceFleetTemplate

*Decompiled from `TISpaceFleetTemplate.cs`.*


## Class `TISpaceFleetTemplate`

```csharp
public class TISpaceFleetTemplate : TISpaceAssetTemplate
```

### Fields

| Name | Type |
|---|---|
| `factionTemplate` | public TIFactionTemplate |
| `defaultFormation` | public Formation |
| `filteredShipsInFleet` | public List<TISpaceFleetTemplate.ShipFleetDefinition> |
| `shipsInFleet` | public List<TISpaceFleetTemplate.ShipFleetDefinition> |
| `factionName` | public string |
| `formationSpacing` | public FormationSpacing |
| `formationName` | public string |
| `formationConcentration` | public FormationConcentration |
| `formationFocus` | public FormationFocus |
| `ShipFleetDefinition` | public struct |
| `shipTemplateName` | public string |

### Methods

```csharp
public override TIGameState CreateGameState()
```

```csharp
public TISpaceFleetTemplate(string dataNameToSet)
```

```csharp
public ShipFleetDefinition(string shipTemplateName)
```
