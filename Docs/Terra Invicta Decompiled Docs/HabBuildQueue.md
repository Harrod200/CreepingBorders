# HabBuildQueue

*Decompiled from `HabBuildQueue.cs`.*


## Class `HabBuildQueue`

```csharp
public class HabBuildQueue
```

### Fields

| Name | Type |
|---|---|
| `orderedBuildList` | public List<TIHabModuleTemplate> |

### Methods

```csharp
public void AddItemToList(TIHabModuleTemplate module, int position)
```

```csharp
public void RemoveItemFromList(int position)
```

```csharp
public bool RepositionItemInList(int position, bool up)
```

```csharp
public void ApplyQueueToHab(TIHabState hab)
```
