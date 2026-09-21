# BattleLogController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/UI/BattleLogController.cs`.*


## Class `BattleLogController`

```csharp
public class BattleLogController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `battleLogInstance` | public GameObject |
| `logWindow` | public GameObject |
| `battleLogWindowTitle` | public TMP_Text |
| `battleLogHeader` | public TMP_Text |
| `filterDropdown` | public TMP_Dropdown |
| `battleLogListAdapter` | public BattleLogListAdapter |
| `battleLogListModels` | public List<BattleLogListItemModel> |
| `shipsOutOfDV` | private HashSet<TISpaceShipState> |
| `filterType` | private BattleLogController.BattleLogType |
| `eventListenersCleanedUp` | private bool |
| `sortMostRecentLogsFirst` | private bool |
| `includeAllDamage` | private bool |
| `BattleLogType` | public enum |

### Methods

```csharp
public void Init()
```

```csharp
private void OnDestroy()
```

```csharp
public void PostCombatCleanup()
```

```csharp
private void InitFilter()
```

```csharp
public void OnBattleLogFilterChanged()
```

```csharp
public void OnTimeSortButtonPressed()
```

```csharp
private void AddLog(string message, BattleLogController.BattleLogType type)
```

```csharp
public void SortBattleLogEntries()
```

```csharp
private void UpdateBattleLogData()
```

```csharp
public void AddDestroyLog(ShipDestroyed destroyedEvent)
```

```csharp
public void AddDestroyHabLog(HabModuleDestroyedInCombat e)
```

```csharp
private void AddBattleGroupReinforcemntLog(BattleGroupReinforcementArrived e)
```

```csharp
private void AddShipReinforcementLog(ReinforcementArrived e)
```

```csharp
private void AddDisengageLog(ShipRetreatsFromCombat e)
```

```csharp
private void AddShipWeaponOutOfAmmo(ShipWeaponOutOfAmmo e)
```

```csharp
private void AddShipOutOfDVLog(ShipDeltaVChange e)
```

```csharp
private void AddShipOfficerKilledLog(ShipOfficerKilled e)
```

```csharp
private void AddShipPartDestroyedLog(ShipPartDamageChange e)
```

```csharp
private void AddAllShipWeaponsDisabled(TISpaceShipState shipState)
```

```csharp
private void AddShipSystemDamageUpdateLog(ShipSystemDamageChange e)
```

```csharp
private void AddShipDamagedLog(ShipArmorFacingStruckInCombat e)
```

```csharp
private void AddHabDamagedLog(HabModuleDamagedInCombat e)
```
