# VisibilityControlStatic

*Decompiled from `Vectrosity/VisibilityControlStatic.cs`.*


## Class `VisibilityControlStatic`

```csharp
public class VisibilityControlStatic : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `objectNumber` | public RefInt |
| `m_objectNumber` | private RefInt |
| `m_vectorLine` | private VectorLine |
| `m_destroyed` | private bool |
| `m_dontDestroyLine` | private bool |
| `m_originalMatrix` | private Matrix4x4 |

### Methods

```csharp
public void Setup(VectorLine line, bool makeBounds)
```

```csharp
private IEnumerator WaitCheck()
```

```csharp
private void OnBecameVisible()
```

```csharp
private void OnBecameInvisible()
```

```csharp
private void OnDestroy()
```

```csharp
public void DontDestroyLine()
```

```csharp
public Matrix4x4 GetMatrix()
```
