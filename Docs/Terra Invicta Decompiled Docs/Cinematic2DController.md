# Cinematic2DController

*Decompiled from `Cinematic2DController.cs`.*


## Class `Cinematic2DController`

```csharp
public class Cinematic2DController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `template` | public TI2DCinematicTemplate |
| `generalIntroTemplate` | private TI2DCinematicTemplate |
| `cinemaObject` | public GameObject |
| `cinematicIllustration` | public Image |
| `cinematicText` | public TMP_Text |
| `cineCanvasGroup` | private CanvasGroup |
| `textboxCanvasGroup` | public CanvasGroup |
| `continueButton` | public Button |
| `videoPlayer` | public VideoPlayer |
| `audioPath` | public string |
| `ideologyString` | public string |
| `fadeTimer` | public float |
| `typingSpeed` | public float |
| `cinematicDisplayText` | public string |
| `cinematicPathString` | public string |
| `commonCinematicPathString` | private string |
| `queuedCinematicPathString` | public string |
| `introQueued` | public bool |
| `generalIntroString` | private string |
| `currentTextSequence` | private int |
| `textTimeStamps` | private float[] |
| `textTimeStampsCommon` | private float[] |
| `textTimer` | private float |
| `generalTextStrings` | private int |
| `playingIntroText` | private bool |
| `playingIntroCinematic` | private bool |
| `active` | private bool |
| `hasBeenPrepared` | private bool |

### Methods

```csharp
public IEnumerator BeginWhenPrepared(bool playAudio = true, bool intro = false)
```

```csharp
public void Begin(bool playAudio = true, bool intro = false)
```

```csharp
public void Init()
```

```csharp
public void ShowTestCinematic()
```

```csharp
private void Update()
```

```csharp
private void GetTextTimeStamps()
```

```csharp
public void OnClickCloseCinematic()
```

```csharp
public void StartQueuedCinematic()
```

```csharp
private void OnEnable()
```
