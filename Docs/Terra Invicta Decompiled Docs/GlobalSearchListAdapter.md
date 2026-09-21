# GlobalSearchListAdapter

*Decompiled from `PavonisInteractive/TerraInvicta/GlobalSearchListAdapter.cs`.*


## Class `GlobalSearchListAdapter`

```csharp
public class GlobalSearchListAdapter : OSA<BaseParamsWithPrefab, GlobalSearchListItemViewsHolder>
```

### Properties

- `public SimpleDataHelper<GlobalSearchListItemModel> Data`

### Methods

```csharp
protected override void Start()
```

```csharp
protected override GlobalSearchListItemViewsHolder CreateViewsHolder(int itemIndex)
```

```csharp
protected override void UpdateViewsHolder(GlobalSearchListItemViewsHolder newOrRecycled)
```

```csharp
public void SetItems(IList<GlobalSearchListItemModel> items)
```
