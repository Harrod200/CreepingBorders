# LedgerListAdapter

*Decompiled from `PavonisInteractive/TerraInvicta/LedgerListAdapter.cs`.*


## Class `LedgerListAdapter`

```csharp
public class LedgerListAdapter : OSA<BaseParamsWithPrefab, LedgerListItemViewsHolder>
```

### Properties

- `public SimpleDataHelper<LedgerListItemModel> Data`

### Methods

```csharp
protected override void Start()
```

```csharp
protected override LedgerListItemViewsHolder CreateViewsHolder(int itemIndex)
```

```csharp
protected override void UpdateViewsHolder(LedgerListItemViewsHolder newOrRecycled)
```

```csharp
public void SetItems(IList<LedgerListItemModel> items)
```
