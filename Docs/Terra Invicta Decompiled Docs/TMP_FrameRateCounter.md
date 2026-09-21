# TMP_FrameRateCounter

*Decompiled from `TMPro/Examples/TMP_FrameRateCounter.cs`.*


## Class `TMP_FrameRateCounter`

```csharp
public class TMP_FrameRateCounter : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `UpdateInterval` | public float |
| `m_LastInterval` | private float |
| `m_Frames` | private int |
| `AnchorPosition` | public TMP_FrameRateCounter.FpsCounterAnchorPositions |
| `htmlColorTag` | private string |
| `m_TextMeshPro` | private TextMeshPro |
| `m_frameCounter_transform` | private Transform |
| `m_camera` | private Camera |
| `last_AnchorPosition` | private TMP_FrameRateCounter.FpsCounterAnchorPositions |
| `FpsCounterAnchorPositions` | public enum |

### Properties

- `private const string fpsLabel = "`

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
private void Update()
```

```csharp
public void Clear()
```

```csharp
private void Set_FrameCounter_Position(TMP_FrameRateCounter.FpsCounterAnchorPositions anchor_position)
```
