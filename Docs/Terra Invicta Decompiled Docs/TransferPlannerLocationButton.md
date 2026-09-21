# TransferPlannerLocationButton

*Decompiled from `PavonisInteractive/TerraInvicta/TransferPlannerLocationButton.cs`.*


## Class `TransferPlannerLocationButton`

```csharp
public class TransferPlannerLocationButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `isDestination` | public bool |
| `TransferPlanner` | public TransferPlanner |
| `SelectedLocation` | public ITransferTarget |
| `SelectedGameState` | public TIGameState |
| `SelectedFleet` | public TISpaceFleetState |
| `SelectionIsFleet` | public bool |
| `SelectedHab` | public TIHabState |
| `SelectionIsHab` | public bool |
| `SelectedOrbit` | public TIOrbitState |
| `SelectionIsOrbit` | public bool |
| `IsSelected` | public bool |
| `isHovered` | private bool |
| `isOrigin` | public bool |
| `targetSelectionTool` | public TargetSelectionTool |
| `text` | public TMP_Text |
| `BackgroundImage` | public Image |
| `RestColor` | public Color |
| `HoveredColor` | public Color |
| `SelectedColor` | public Color |
| `selectedLocation` | private ITransferTarget |

### Properties

- `public static TransferPlannerLocationButton SelectedLocationButton`

### Methods

```csharp
private void Start()
```

```csharp
private void Update()
```

```csharp
public void Select()
```

```csharp
private void UpdateText()
```

```csharp
public void OnLocationSelected(TIGameState gameState)
```

```csharp
public void OnPointerClick(PointerEventData eventData)
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```
