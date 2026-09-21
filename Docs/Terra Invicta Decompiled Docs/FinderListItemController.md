# FinderListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/FinderListItemController.cs`.*


## Class `FinderListItemController`

```csharp
public class FinderListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `itemIcon` | public Image |
| `itemBackground` | public Image |
| `itemName` | public TMP_Text |
| `itemLocation` | public Image |
| `statusIcon` | public Image |
| `finderButton` | public Button |
| `editModeCanvas` | public GameObject |
| `itemType` | private FinderListItemType |
| `controller` | private GeneralControlsController |
| `gamestate` | private TIGameState |
| `army` | private TIArmyState |
| `councilor` | private TICouncilorState |
| `fleet` | private TISpaceFleetState |
| `hab` | private TIHabState |

### Methods

```csharp
public void Initialize(TIGameState item, GeneralControlsController controller)
```

```csharp
public void AddCouncilorListeners()
```

```csharp
public void RemoveCouncilorListeners(bool noNullCheck = true)
```

```csharp
private void UpdateCouncilorListItem(CouncilorPositionUpdated e)
```

```csharp
private void UpdateCouncilorListItem(CouncilorMissionUpdated e)
```

```csharp
private void UpdateCouncilorListItem(CouncilorVisibilityChanged e)
```

```csharp
private void UpdateCouncilorListItem(CouncilorValuesChanged e)
```

```csharp
public void AddArmyListeners()
```

```csharp
public void RemoveArmyListeners(bool noNullCheck = true)
```

```csharp
private void UpdateArmyListItem(ArmyStatusUpdate e)
```

```csharp
private void UpdateArmyListItem(StartArmyOperation e)
```

```csharp
private void UpdateArmyListItem(OperationExecuted e)
```

```csharp
private void OnGameStateArchived(GameStateArchived e)
```

```csharp
public void AddHabListeners()
```

```csharp
public void RemoveHabListeners(bool noNullCheck = true)
```

```csharp
public void AddFleetListeners()
```

```csharp
public void RemoveFleetListeners(bool noNullCheck = true)
```

```csharp
private void UpdateFleetListItem(FleetArrivesAtDestination e)
```

```csharp
private void UpdateFleetListItem(StartFleetOperation e)
```

```csharp
private void UpdateFleetListItem(FleetAvailabilityChange e)
```

```csharp
private void UpdateFleetListItem(OperationExecuted e)
```

```csharp
private void UpdateFleetListItem(FleetUndocks e)
```

```csharp
public void RemoveListeners(bool noNullCheck)
```

```csharp
public void SelectFinderObject()
```

```csharp
public void UpdateListItem(FinderListItem_Data data)
```

```csharp
private void UpdateListItem(TIArmyState army)
```

```csharp
private void UpdateListItem(TICouncilorState councilor, bool forceUpdate = false)
```

```csharp
private void OnHabModuleConstructionStatusChange(HabModuleConstructionStatusChange e)
```

```csharp
private void OnSectorAssignedToFaction(SectorAssignedToFaction e)
```

```csharp
private void OnBeginBombardment(BeginBombardment e)
```

```csharp
private void OnEndBombardment(EndBombardment e)
```

```csharp
private void OnBeginAssault(BeginHabAssault e)
```

```csharp
private void OnEndAssault(EndHabAssault e)
```

```csharp
private void UpdateListItem(TIHabState hab)
```

```csharp
public void ForceHighlight(bool highlight = true)
```

```csharp
private void UpdateListItem(TISpaceFleetState fleet)
```

```csharp
public void OnClickChangeSortValue(int value)
```

```csharp
public void OnClickSetMaxSortValue()
```

```csharp
public void OnClickSetMinSortValue()
```

```csharp
public void SwapSortIndex(int originalIndex)
```

```csharp
public void PushSortIndex(bool up, int originalIndex)
```

```csharp
public int SetToMaxSortIndex(int originalValue)
```

```csharp
private void OnDestroy()
```
