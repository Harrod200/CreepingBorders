# BaseGridCell

*Decompiled from `PavonisInteractive/TerraInvicta/BaseGridCell.cs`.*


## Class `BaseGridCell`

```csharp
public class BaseGridCell : HabGridCell
```

### Fields

| Name | Type |
|---|---|
| `moduleCellRotation` | private float |

### Methods

```csharp
protected override void CacheComponents()
```

```csharp
protected override void AddListeners()
```

```csharp
public override void SetPreviewer(IHabitatsPreviewer previewer)
```

```csharp
public override void SetInteractable(bool interactable)
```

```csharp
public override void SetModule(string imageName, bool playerControlled, bool alien, TIHabModuleState moduleState, TIHabState hab)
```

```csharp
public override void SetGridCellSize(Vector2 size)
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
