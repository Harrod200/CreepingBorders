# TIDirtyResourcesTracker

*Decompiled from `PavonisInteractive/TerraInvicta/TIDirtyResourcesTracker.cs`.*


## Class `TIDirtyResourcesTracker`

```csharp
public class TIDirtyResourcesTracker
```

### Fields

| Name | Type |
|---|---|
| `resourceIncomeDirty` | private Dictionary<FactionResource, bool> |
| `resourceRevenueDirty` | private Dictionary<FactionResource, bool> |

### Methods

```csharp
public bool IsResourceRevenueDirty(FactionResource factionResource)
```

```csharp
public bool IsResourceIncomeDirty(FactionResource factionResource)
```

```csharp
public void SetResourceDirty(FactionResource factionResource)
```

```csharp
public void MarkResourceIncomeUpdated(FactionResource factionResource)
```

```csharp
public void MarkResourceRevenueUpdated(FactionResource factionResource)
```

```csharp
public void SetAllResourcesDirty()
```
