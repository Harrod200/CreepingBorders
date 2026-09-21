# ShipModuleDragDestination

*Decompiled from `PavonisInteractive/TerraInvicta/UI/ShipModuleDragDestination.cs`.*


## Class `ShipModuleDragDestination`

```csharp
public class ShipModuleDragDestination : DragDestination
```

### Fields

| Name | Type |
|---|---|
| `IsArmor` | public bool |
| `SlotCoordinates` | public Vector2Int |
| `hasSpinner` | public bool |
| `FleetsScreenController` | public FleetsScreenController |
| `shipModuleSlotType` | public ShipModuleSlotType |
| `tooltip` | public TooltipTrigger |
| `spinnerPanel` | public GameObject |
| `spinnerValueText` | public TMP_Text |
| `spinnerValueInput` | public TMP_InputField |
| `cornerIcon` | public Image |
| `slotImage` | private Image |
| `slotCoordinates` | private Vector2Int |
| `fleetsController` | private FleetsScreenController |
| `defaultPosition` | public Vector3 |
| `currentPart` | public TIShipPartTemplate |
| `iconSize` | public int |

### Properties

- `public bool empty`
- `public bool blocked`

### Methods

```csharp
private void Awake()
```

```csharp
public override void SetControllerBase(CanvasControllerBase canvasControllerBase)
```

```csharp
public static string EmptySlotIconName(ShipModuleSlotType shipModuleSlotType)
```

```csharp
public static string HighlightSlotIconName(ShipModuleSlotType shipModuleSlotType)
```

```csharp
public void OnIncreasePressed()
```

```csharp
public void OnDecreasePressed()
```

```csharp
public void OnAmountChanged()
```

```csharp
public void OnClickDestination()
```

```csharp
public void OnRightClickDestination()
```

```csharp
public override void OnPointerEnter(PointerEventData eventData)
```

```csharp
public override void OnPointerExit(PointerEventData eventData)
```

```csharp
private void SetEmptyTooltipValue()
```

```csharp
public void EnableDestination(ShipModuleSlotType slotType, Vector2Int slotCoordinates)
```

```csharp
public void UpdateSpinnerValue(int value)
```

```csharp
public void HighlightDestination()
```

```csharp
public void DeHiglightDestination()
```

```csharp
public void DisableDestination()
```

```csharp
public void BlockDestination()
```

```csharp
public void UnBlockDestination()
```

```csharp
public void SetEmpty()
```

```csharp
public void SetFilled()
```

```csharp
public void SetImage(string iconPath, Mount mount = Mount.Standard)
```

```csharp
public void SetLayoutOffset(float xOffset, float yOffset)
```

```csharp
public override void OnDrop(PointerEventData eventData)
```

```csharp
protected override bool CanDropItemHere()
```

```csharp
public bool LegalModuleForSlot(TIShipPartTemplate moduleTemplate, bool allowAlts, out Vector2Int coordinates)
```
