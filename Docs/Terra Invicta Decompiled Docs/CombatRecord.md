# CombatRecord

*Decompiled from `PavonisInteractive/TerraInvicta/CombatRecord.cs`.*


## Struct `CombatRecord`

```csharp
public struct CombatRecord
```

### Fields

| Name | Type |
|---|---|
| `Hab` | public TIHabState |
| `combatName` | public string |
| `faction1` | public TIFactionState |
| `faction2` | public TIFactionState |
| `fleet1Name` | public string |
| `fleet2Name` | public string |
| `habName` | public string |
| `winnerSalvage` | public TIResourcesCost |
| `singleAssetRecords` | public List<CombatRecord.SingleAssetCombatRecord> |
| `SingleAssetCombatRecord` | public struct |
| `faction` | public TIFactionState |
| `assetName` | public string |
| `outcome` | public SingleAssetCombatOutcome |
| `asset` | public TIGameState |
| `fled` | public bool |
| `assetSummary` | public string |
| `killer` | public TIGameState |
| `killerWeaponTemplateName` | public string |

### Methods

```csharp
public void AddAssetSurvivedRecord(TIGameState asset, bool fled = false, SingleAssetCombatOutcome overrideOutcome = SingleAssetCombatOutcome.None)
```

```csharp
public void AddAssetDestroyedRecord(TISpaceShipState ship, TIGameState killer, TIShipWeaponTemplate killerWeapon)
```

```csharp
public CombatRecord Copy()
```
