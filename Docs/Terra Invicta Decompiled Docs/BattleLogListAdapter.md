# BattleLogListAdapter

*Decompiled from `PavonisInteractive/TerraInvicta/BattleLogListAdapter.cs`.*


## Class `BattleLogListAdapter`

```csharp
public class BattleLogListAdapter : OSA<BaseParamsWithPrefab, BattleLogListItemViewsHolder>
```

### Properties

- `public SimpleDataHelper<BattleLogListItemModel> Data`

### Methods

```csharp
protected override void Start()
```

```csharp
protected override BattleLogListItemViewsHolder CreateViewsHolder(int itemIndex)
```

```csharp
protected override void UpdateViewsHolder(BattleLogListItemViewsHolder newOrRecycled)
```

```csharp
public void SetItems(IList<BattleLogListItemModel> items)
```
