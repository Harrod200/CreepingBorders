# VisibilityControl

*Decompiled from `Vectrosity/VisibilityControl.cs`.*


## Class `VisibilityControl`

```csharp
public class VisibilityControl : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `objectNumber` | public RefInt |
| `m_objectNumber` | private RefInt |
| `m_vectorLine` | private VectorLine |
| `m_destroyed` | private bool |
| `m_dontDestroyLine` | private bool |

### Methods

```csharp
public void Setup(VectorLine line, bool makeBounds)
```

```csharp
private IEnumerator VisibilityTest()
```

```csharp
private IEnumerator OnBecameVisible()
```

```csharp
private IEnumerator OnBecameInvisible()
```

```csharp
private void OnDestroy()
```

```csharp
public void DontDestroyLine()
```
