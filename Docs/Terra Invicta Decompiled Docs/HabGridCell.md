# HabGridCell

*Decompiled from `PavonisInteractive/TerraInvicta/HabGridCell.cs`.*


## Class `HabGridCell`

```csharp
public abstract class HabGridCell : DragDestination
```

### Fields

| Name | Type |
|---|---|
| `isEmpty` | public bool |
| `sector` | public int |
| `module` | public int |
| `Previewer` | public IHabitatsPreviewer |
| `habType` | protected HabType |
| `gridLayoutGroup` | protected GridLayoutGroup |
| `cellButton` | protected Button |
| `cellImage` | protected Image |
| `moduleCellRectTransform` | protected RectTransform |
| `moduleImage` | protected Image |
| `moduleCellConnectorImage` | protected Image |
| `tier` | protected int |
| `sectorEnabled` | protected bool |
| `sectorIsPlayerControlled` | protected bool |
| `underConstruction` | protected bool |
| `factionIcon` | protected Image |
| `powerIcon` | protected Image |
| `N2` | protected Image |
| `N1` | protected Image |
| `W2` | protected Image |
| `W1` | protected Image |
| `E2` | protected Image |
| `E1` | protected Image |
| `S2` | protected Image |
| `S1` | protected Image |
| `connectionSectorOnly` | public bool |
| `hasInit` | private bool |
| `habitatsController` | private HabitatsScreenController |
| `visibleColor` | protected Color |
| `hiddenColor` | protected Color |
| `tooltip` | public TooltipTrigger |

### Properties

- `public TIHabModuleState habModule`

### Methods

```csharp
public abstract void SetPreviewer(IHabitatsPreviewer previewer)
```

```csharp
protected abstract void CacheComponents()
```

```csharp
protected abstract void AddListeners()
```

```csharp
public abstract void SetModule(string imageName, bool playerControlled, bool alien, TIHabModuleState module, TIHabState hab)
```

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
private void Init()
```

```csharp
protected string SetTooltip()
```

```csharp
protected void CommonCacheComponents()
```

```csharp
public virtual void SetInteractable(bool interactable)
```

```csharp
protected void OnSelected()
```

```csharp
public virtual void SetGridCellSize(Vector2 size)
```

```csharp
protected int GetTier(string imageName)
```

```csharp
public void SetConnectionSprite(Image connectionImage, bool alien)
```

```csharp
public void SetAllConnectionSprites(bool alien)
```

```csharp
public void UpdateConnections(bool hide = false)
```

```csharp
public void Show()
```

```csharp
public void SetDecommissioningVisuals()
```

```csharp
public void Hide()
```

```csharp
public void SetPowerIcon(bool forceOff)
```

```csharp
public override void SetControllerBase(CanvasControllerBase canvasControllerBase)
```

```csharp
public override void OnDrop(PointerEventData eventData)
```

```csharp
public override void OnPointerEnter(PointerEventData eventData)
```

```csharp
public override void OnPointerExit(PointerEventData eventData)
```

```csharp
protected override bool CanDropItemHere()
```

```csharp
protected void OnDestroy()
```

```csharp
protected void RemoveListeners()
```
