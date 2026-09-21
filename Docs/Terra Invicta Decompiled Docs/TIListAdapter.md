# TIListAdapter

*Decompiled from `PavonisInteractive/TerraInvicta/TIListAdapter.cs`.*


## Class `TIListAdapter`

```csharp
public class TIListAdapter : OSA<BaseParamsWithPrefab, TIListItemViewsHolder>
```

### Properties

- `public SimpleDataHelper<TIListItemModel> Data`

### Methods

```csharp
protected override void Start()
```

```csharp
protected override TIListItemViewsHolder CreateViewsHolder(int itemIndex)
```

```csharp
protected override void UpdateViewsHolder(TIListItemViewsHolder newOrRecycled)
```

```csharp
public void AddItemsAt(int index, IList<TIListItemModel> items)
```

```csharp
public void RemoveItemsFrom(int index, int count)
```

```csharp
public void SetItems(IList<TIListItemModel> items)
```

```csharp
public override void ChangeItemsCount(ItemCountChangeMode changeMode, int itemsCount, int indexIfInsertingOrRemoving = -1, bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
```
