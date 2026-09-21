# TMP_UiFrameRateCounter

*Decompiled from `TMPro/Examples/TMP_UiFrameRateCounter.cs`.*


## Class `TMP_UiFrameRateCounter`

```csharp
public class TMP_UiFrameRateCounter : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `UpdateInterval` | public float |
| `m_LastInterval` | private float |
| `m_Frames` | private int |
| `AnchorPosition` | public TMP_UiFrameRateCounter.FpsCounterAnchorPositions |
| `htmlColorTag` | private string |
| `m_TextMeshPro` | private TextMeshProUGUI |
| `m_frameCounter_transform` | private RectTransform |
| `last_AnchorPosition` | private TMP_UiFrameRateCounter.FpsCounterAnchorPositions |
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
private void Set_FrameCounter_Position(TMP_UiFrameRateCounter.FpsCounterAnchorPositions anchor_position)
```
