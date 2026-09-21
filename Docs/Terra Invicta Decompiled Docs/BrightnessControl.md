# BrightnessControl

*Decompiled from `Vectrosity/BrightnessControl.cs`.*


## Class `BrightnessControl`

```csharp
public class BrightnessControl : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `objectNumber` | public RefInt |
| `m_objectNumber` | private RefInt |
| `m_vectorLine` | private VectorLine |
| `m_useLine` | private bool |
| `m_destroyed` | private bool |

### Methods

```csharp
public void Setup(VectorLine line, bool m_useLine)
```

```csharp
public void SetUseLine(bool useLine)
```

```csharp
private void OnBecameVisible()
```

```csharp
public void OnBecameInvisible()
```

```csharp
private void OnDestroy()
```
