# LineManager

*Decompiled from `Vectrosity/LineManager.cs`.*


## Class `LineManager`

```csharp
public class LineManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `lines` | private static List<VectorLine> |
| `transforms` | private static List<Transform> |
| `lineCount` | private static int |
| `destroyed` | private bool |

### Methods

```csharp
private void Awake()
```

```csharp
private void Initialize()
```

```csharp
public void AddLine(VectorLine vectorLine, Transform thisTransform, float time)
```

```csharp
public void DisableLine(VectorLine vectorLine, float time)
```

```csharp
private IEnumerator DisableLine(VectorLine vectorLine, float time, bool remove)
```

```csharp
private void LateUpdate()
```

```csharp
private void RemoveLine(int i)
```

```csharp
public void RemoveLine(VectorLine vectorLine)
```

```csharp
public void DisableIfUnused()
```

```csharp
public void EnableIfUsed()
```

```csharp
public void StartCheckDistance()
```

```csharp
private void CheckDistance()
```

```csharp
private void OnDestroy()
```
