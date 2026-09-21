# FleetScreenFleetListAdapter

*Decompiled from `PavonisInteractive/TerraInvicta/FleetScreenFleetListAdapter.cs`.*


## Class `FleetScreenFleetListAdapter`

```csharp
public class FleetScreenFleetListAdapter : OSA<BaseParamsWithPrefab, FleetScreenFleetListItemViewsHolder>
```

### Fields

| Name | Type |
|---|---|
| `idToBringToView` | public GameStateID |
| `idToBringIsGroup` | public bool |
| `thisRT` | private RectTransform |

### Properties

- `public SimpleDataHelper<FleetScreenFleetListItemModel> Data`

### Methods

```csharp
protected override void Start()
```

```csharp
protected override FleetScreenFleetListItemViewsHolder CreateViewsHolder(int itemIndex)
```

```csharp
protected override void UpdateViewsHolder(FleetScreenFleetListItemViewsHolder newOrRecycled)
```

```csharp
protected override void OnItemHeightChangedPreTwinPass(FleetScreenFleetListItemViewsHolder vh)
```

```csharp
protected override void RebuildLayoutDueToScrollViewSizeChange()
```

```csharp
public override void ChangeItemsCount(ItemCountChangeMode changeMode, int itemsCount, int indexIfInsertingOrRemoving = -1, bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
```

```csharp
private void SetAllModelsHavePendingSizeChange()
```

```csharp
public void SetItems(IList<FleetScreenFleetListItemModel> items)
```
