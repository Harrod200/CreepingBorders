# TMP_TextSelector_A

*Decompiled from `TMPro/Examples/TMP_TextSelector_A.cs`.*


## Class `TMP_TextSelector_A`

```csharp
public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `m_TextMeshPro` | private TextMeshPro |
| `m_Camera` | private Camera |
| `m_isHoveringObject` | private bool |
| `m_selectedLink` | private int |
| `m_lastCharIndex` | private int |
| `m_lastWordIndex` | private int |

### Methods

```csharp
private void Awake()
```

```csharp
private void LateUpdate()
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```
