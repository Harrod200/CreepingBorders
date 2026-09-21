# BasicListAdapter

*Decompiled from `PavonisInteractive/TerraInvicta/BasicListAdapter.cs`.*


## Class `BasicListAdapter`

```csharp
public class BasicListAdapter : OSA<BaseParamsWithPrefab, MyListItemViewsHolder>
```

### Properties

- `public SimpleDataHelper<MyListItemModel> Data`

### Methods

```csharp
protected override void Start()
```

```csharp
protected override MyListItemViewsHolder CreateViewsHolder(int itemIndex)
```

```csharp
protected override void UpdateViewsHolder(MyListItemViewsHolder newOrRecycled)
```

```csharp
public void AddItemsAt(int index, IList<MyListItemModel> items)
```

```csharp
public void RemoveItemsFrom(int index, int count)
```

```csharp
public void SetItems(IList<MyListItemModel> items)
```

```csharp
private void RetrieveDataAndUpdate(int count)
```

```csharp
private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
```

```csharp
private void FetchMoreItemsFromDataSourceAndUpdate2(int count)
```

```csharp
private void OnDataRetrieved(MyListItemModel[] newItems)
```

```csharp
public override void ChangeItemsCount(ItemCountChangeMode changeMode, int itemsCount, int indexIfInsertingOrRemoving = -1, bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
```
