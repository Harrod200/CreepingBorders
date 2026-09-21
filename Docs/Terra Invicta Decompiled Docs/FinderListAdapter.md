# FinderListAdapter

*Decompiled from `PavonisInteractive/TerraInvicta/FinderListAdapter.cs`.*


## Class `FinderListAdapter`

```csharp
public class FinderListAdapter : OSA<BaseParamsWithPrefab, FinderListItemViewsHolder>
```

### Properties

- `public SimpleDataHelper<FinderListItemModel> Data`

### Methods

```csharp
protected override void Start()
```

```csharp
protected override FinderListItemViewsHolder CreateViewsHolder(int itemIndex)
```

```csharp
protected override void UpdateViewsHolder(FinderListItemViewsHolder newOrRecycled)
```

```csharp
public void SetItems(IList<FinderListItemModel> items)
```
