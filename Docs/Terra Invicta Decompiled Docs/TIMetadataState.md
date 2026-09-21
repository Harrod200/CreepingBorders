# TIMetadataState

*Decompiled from `PavonisInteractive/TerraInvicta/TIMetadataState.cs`.*


## Class `TIMetadataState`

```csharp
public class TIMetadataState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `playerFactionName` | public string |
| `gameTimeString` | public string |
| `difficulty` | public string |
| `requiredDLC` | public List<string> |
| `playedWithMods` | public bool |
| `customDifficulty` | public bool |
| `selectedFactionsForScenario` | public List<string> |
| `researchSpeedMultiplier` | public string |
| `controlPointMaintenanceFreebieBonus` | public string |
| `controlPointMaintenanceFreebieBonusAI` | public string |
| `missionControlBonus` | public string |
| `missionControlBonusAI` | public string |
| `alienProgressionSpeed` | public string |
| `miningProductivityMultiplier` | public string |
| `nationalIPMultiplier` | public string |
| `averageMonthlyEvents` | public string |
| `playerFactionIconPath` | public string |
| `playerFactionGradientPath` | public string |
| `lastCompletedObjectiveArtPath` | public string |
| `lastCompletedObjectiveName` | public string |
| `dataStrings` | private static List<string> |

### Methods

```csharp
public void SetValues()
```

```csharp
public string GetFirstFallbackObjectiveIllustration()
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public static TIMetadataState LoadMetaData(string filePath, out bool valid, bool allowLongSearch = false)
```

```csharp
private static void FindMetadataFromSave(string filePath, bool longSearch)
```

```csharp
private static bool GetBoolValueFromKey(string key, bool defaultValue)
```

```csharp
private static List<string> GetListFromKey(string searchKey)
```

```csharp
private static string GetValue(string searchKey)
```
