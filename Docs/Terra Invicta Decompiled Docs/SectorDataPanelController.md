# SectorDataPanelController

*Decompiled from `PavonisInteractive/TerraInvicta/SectorDataPanelController.cs`.*


## Class `SectorDataPanelController`

```csharp
public class SectorDataPanelController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `primaryCanvas` | public Canvas |
| `factionIcon` | public Image |
| `primaryButton` | public Button |
| `sectorFactionName` | public TMP_Text |
| `habName` | public TMP_Text |
| `cameraManager` | private CameraManager |
| `sector` | private TISectorState |
| `habModelController` | private HabModelController |
| `spaceObjectSelection` | private SpaceObjectSelection |
| `defendedIcon` | public GameObject |
| `tooltip` | public TooltipTrigger |

### Methods

```csharp
public void Awake()
```

```csharp
public void Initialize(TISectorState sector, HabModelController modelController)
```

```csharp
private void DisableData(HabEntersCombat e)
```

```csharp
private void SetSectorData(SectorAssignedToFaction e)
```

```csharp
public void SetSectorData()
```

```csharp
public void TurnOffSectorData()
```

```csharp
public void TurnOnSectorData()
```

```csharp
public void OnClicked()
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```

```csharp
public void OnHabDefendInterestsUpdated(HabDefendInterestsUpdated e)
```

```csharp
public void Update()
```

```csharp
public void OnDestroy()
```
