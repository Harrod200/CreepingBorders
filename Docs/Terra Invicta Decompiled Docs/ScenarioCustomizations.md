# ScenarioCustomizations

*Decompiled from `PavonisInteractive/TerraInvicta/ScenarioCustomizations.cs`.*


## Class `ScenarioCustomizations`

```csharp
public class ScenarioCustomizations
```

### Fields

| Name | Type |
|---|---|
| `usingCustomizations` | public bool |
| `customDifficulty` | public bool |
| `customFactionText` | public Dictionary<string, ScenarioCustomizations.CustomFactionText> |
| `customFactionStartingNationGroup` | public Dictionary<string, int> |
| `startingCouncilorProfessions` | public List<TICouncilorTypeTemplate> |
| `usePlayerCountryForStartingCouncilor` | public bool |
| `variableProjectUnlocks` | public bool |
| `showTriggeredProjects` | public bool |
| `addAlienAssaultCarrierFleet` | public bool |
| `otherFactionStartingNations` | public bool |
| `selectedFactionsForScenario` | public List<string> |
| `researchSpeedMultiplier` | public float |
| `controlPointMaintenanceFreebieBonus` | public int |
| `controlPointMaintenanceFreebieBonusAI` | public int |
| `missionControlBonus` | public float |
| `missionControlBonusAI` | public float |
| `alienProgressionSpeed` | public float |
| `miningProductivityMultiplier` | public float |
| `nationalIPMultiplier` | public float |
| `averageMonthlyEvents` | public int |
| `cinematicCombatRealismDV` | public bool |
| `cinematicCombatRealismScale` | public bool |
| `canDisableFactions` | public bool |
| `miningRatePlayer` | public float |
| `miningRateHumanAI` | public float |
| `miningRateAlien` | public float |
| `habConstructionSpeedPlayer` | public float |
| `habConstructionSpeedHumanAI` | public float |
| `habConstructionSpeedAlien` | public float |
| `shipConstructionSpeedPlayer` | public float |
| `shipConstructionSpeedHumanAI` | public float |
| `shipConstructionSpeedAlien` | public float |
| `randomizeMap` | public bool |
| `randomizedMapSeed` | public int |
| `CustomFactionText` | public struct |
| `customDisplayName` | public string |
| `customAdjective` | public string |
| `customLeaderAddress` | public string |
| `customFleetNameBase` | public string |
| `customSmallShipNameListIdx` | public string |
| `customMediumShipNameListIdx` | public string |
| `customLargeShipNameListIdx` | public string |
| `customHabNameListIdx` | public string |

### Properties

- `public List<bool> skipStartingCouncilors = new List<bool>`

### Methods

```csharp
public ScenarioCustomizations Clone()
```

```csharp
public CustomFactionText(string customDisplayName, string customAdjective, string customLeaderAddress, string customFleetNameBase, string customSmallShipNameListIdx, string customMediumShipNameListIdx, string customLargeShipNameListIdx, string customHabNameListIdx)
```
