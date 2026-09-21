# HabModuleListItem

*Decompiled from `PavonisInteractive/TerraInvicta/HabModuleListItem.cs`.*


## Class `HabModuleListItem`

```csharp
public class HabModuleListItem : DragItem
```

### Fields

| Name | Type |
|---|---|
| `Previewer` | public IHabitatsPreviewer |
| `prospective` | public bool |
| `tooltip` | private TooltipTrigger |
| `hasInit` | private bool |
| `group` | private CanvasGroup |
| `moduleIcon` | private Image |
| `moduleTypeIcon` | private Image |
| `moduleTierIcon` | private Image |
| `moduleConstructionIcon` | private Image |
| `moduleDecommissionIcon` | private Image |
| `moduleName` | private TMP_Text |
| `moduleTemplate` | private TIHabModuleTemplate |
| `moduleState` | private TIHabModuleState |
| `dragDestination` | private DragDestination |
| `controller` | public HabitatsScreenController |
| `backgroundImage` | private Image |
| `highlightBackgroundSprite` | public Sprite |
| `defaultBackgroundSprite` | private Sprite |
| `originalSize` | private Vector2 |
| `habGridCell` | public HabGridCell |

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
private void CacheComponents()
```

```csharp
public override void Drop(Transform parent)
```

```csharp
public void SetModule(TIHabModuleState moduleState, HabType habType, bool upgradeLocationAvailable, HabGridCell gridCell = null)
```

```csharp
public void SetModuleTemplate(TIHabModuleTemplate moduleTemplate, HabType habType, bool upgradeLocationAvailable, HabGridCell gridCell = null)
```

```csharp
public TIHabModuleTemplate GetModuleTemplate()
```

```csharp
public TIHabModuleState GetModuleState()
```

```csharp
private void UpdateItem(HabType habType, bool upgradeLocationAvailable)
```

```csharp
private void SetTypeIcon()
```

```csharp
private string SetTooltipText()
```

```csharp
public void AssignTooltipDelegate()
```

```csharp
public void OnClickItem()
```

```csharp
public void OnRightClickItem()
```

```csharp
public void SetHighlight(bool highlight)
```

```csharp
public override void OnBeginDrag(PointerEventData eventData)
```

```csharp
public override void OnDrag(PointerEventData eventData)
```

```csharp
public override void OnEndDrag(PointerEventData eventData)
```
