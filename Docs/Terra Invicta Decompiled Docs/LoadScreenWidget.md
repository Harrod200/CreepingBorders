# LoadScreenWidget

*Decompiled from `LoadScreenWidget.cs`.*


## Class `LoadScreenWidget`

```csharp
public class LoadScreenWidget : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `flavorText` | public TextMeshProUGUI |
| `progressText` | public TextMeshProUGUI |
| `cycleText` | public TextMeshProUGUI |
| `fillBarImage` | public Image |
| `loadingIllustration` | public Image |
| `textChangeInterval` | private float |
| `imageChangeInterval` | private float |
| `textShowTime` | private float |
| `imageShowTime` | private float |
| `randomPick` | private int |
| `dotInterval` | private float |
| `dotShowTime` | private float |
| `firstImageLoaded` | private bool |

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
public void InitLoadWidget()
```

```csharp
public void LoadIllustration()
```

```csharp
public void LoadNextTip()
```

```csharp
private void Update()
```

```csharp
public void SetBar(float value, bool close = false)
```

```csharp
public IEnumerator CloseLoadScreen()
```

```csharp
public void HideWidget()
```
