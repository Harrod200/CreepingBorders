# ShipModuleListItem

*Decompiled from `PavonisInteractive/TerraInvicta/UI/Canvas_Prefabs/FleetsScreen/ShipModuleListItem.cs`.*


## Class `ShipModuleListItem`

```csharp
public class ShipModuleListItem : DragItem
```

### Fields

| Name | Type |
|---|---|
| `table` | public ShipModuleTable |
| `entries` | public IEnumerable<ShipModuleListItemEntry> |
| `ModuleSlotType` | public ShipModuleSlotType |
| `controller` | public FleetsScreenController |
| `addModuleButton` | public Button |
| `moduleIcon` | public Image |
| `obsoleteIcon` | public Image |
| `obsoleteToggle` | public Toggle |
| `hasInit` | private bool |
| `moduleTemplate` | private TIShipPartTemplate |
| `isRow` | public bool |
| `layout` | public HorizontalLayoutGroup |
| `tooltip` | public TooltipTrigger |
| `obsoleteToggleTooltip` | public TooltipTrigger |
| `obsolete_on` | public Sprite |
| `obsolete_off` | public Sprite |
| `entryPrefab` | public ShipModuleListItemEntry |

### Methods

```csharp
protected override void Awake()
```

```csharp
private void Start()
```

```csharp
private void Init()
```

```csharp
public override void OnBeginDrag(PointerEventData eventData)
```

```csharp
public override void OnDrag(PointerEventData eventData)
```

```csharp
public void SetController(FleetsScreenController controller)
```

```csharp
public void OnEnable()
```

```csharp
public void OnDisable()
```

```csharp
public void SetModuleTemplate(TIShipPartTemplate moduleTemplate)
```

```csharp
public string ModuleTTString(TIShipPartTemplate module)
```

```csharp
public TIShipPartTemplate GetModuleTemplate()
```

```csharp
private void UpdateItem()
```

```csharp
private void GenerateEntries()
```

```csharp
private void AddEntry(string labelLocalizationKey, string text = "", object value = null, bool sanitizeText = true)
```

```csharp
public void SetTooltipText(string text)
```

```csharp
public void SetAlpha(bool fullyVisible)
```

```csharp
public void OnClickItem()
```

```csharp
public void OnRightClickItem()
```

```csharp
public void OnObsoleteToggle()
```

```csharp
public void UpdateIcon()
```

```csharp
public void UpdateToggle(TIFactionState faction)
```
