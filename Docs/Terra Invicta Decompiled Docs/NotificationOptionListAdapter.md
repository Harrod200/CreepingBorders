# NotificationOptionListAdapter

*Decompiled from `PavonisInteractive/TerraInvicta/NotificationOptionListAdapter.cs`.*


## Class `NotificationOptionListAdapter`

```csharp
public class NotificationOptionListAdapter : OSA<BaseParamsWithPrefab, NotificationOptionListItemViewsHolder>
```

### Properties

- `public SimpleDataHelper<NotificationOptionListItemModel> Data`

### Methods

```csharp
protected override void Start()
```

```csharp
protected override NotificationOptionListItemViewsHolder CreateViewsHolder(int itemIndex)
```

```csharp
protected override void UpdateViewsHolder(NotificationOptionListItemViewsHolder newOrRecycled)
```

```csharp
public void SetItems(IList<NotificationOptionListItemModel> items)
```
