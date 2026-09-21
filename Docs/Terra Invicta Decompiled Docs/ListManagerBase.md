# ListManagerBase

*Decompiled from `PavonisInteractive/TerraInvicta/ListManagerBase.cs`.*


## Class `ListManagerBase`

```csharp
public class ListManagerBase : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `size` | public int |
| `listItemInstance` | private Transform |
| `_size` | private int |
| `_typeList` | private dynamic |

### Methods

```csharp
private void InitListItem()
```

```csharp
public void SetListSize<T>(int newSize, bool inactive = false, bool toggleGameobjectActiveState = false)
```

```csharp
private void MakeChildListSize<T>(int newSize, bool inactive)
```

```csharp
public IEnumerator<dynamic> GetEnumerator()
```
