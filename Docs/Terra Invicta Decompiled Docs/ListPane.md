# ListPane

*Decompiled from `PavonisInteractive/TerraInvicta/UI/ListPane.cs`.*


## Class `ListPane`

```csharp
public abstract class ListPane<U> : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Items` | public IEnumerable<U> |
| `ItemControllers` | public IEnumerable<IListPaneItem<U>> |
| `prefab` | public GameObject |
| `itemControllers` | private Dictionary<U, IListPaneItem<U>> |
| `itemGOs` | private Dictionary<U, GameObject> |
| `cachedItemSet` | private HashSet<U> |
| `newItemSet` | private HashSet<U> |

### Methods

```csharp
public void Initialize()
```

```csharp
public void Refresh()
```

```csharp
protected abstract IEnumerable<U> ItemsToDisplay()
```

```csharp
protected virtual void BeforeInitialize(IListPaneItem<U> listItem)
```

```csharp
private void InitializeItems(IEnumerable<U> items)
```
