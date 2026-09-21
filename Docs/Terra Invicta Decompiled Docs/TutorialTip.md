# TutorialTip

*Decompiled from `TutorialTip.cs`.*


## Class `TutorialTip`

```csharp
public class TutorialTip : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static TutorialTip |
| `InstanceNull` | public static bool |
| `TipVisible` | public static bool |
| `tutorialTitleText` | public TMP_Text |
| `tutorialDescriptionText` | public TMP_Text |
| `tutorialImage` | public Image |
| `tutorialPointerContainer` | public RectTransform |
| `tutorialPointer2DContainer` | public RectTransform |
| `haloRect` | public RectTransform |
| `animatedPointerContainer` | public RectTransform |
| `animatedPointerRect` | public RectTransform |
| `arrowRect3D` | public RectTransform |
| `haloRect3D` | public RectTransform |
| `centerHighlightBlocker` | public GameObject |
| `previousTipButton` | public Button |
| `nextTipButton` | public Button |
| `closeTipButton` | public Button |
| `hideTipButton` | public Button |
| `dontShowThisAgainButtonObject` | public GameObject |
| `uiTutorialTipList` | public List<UITutorial> |
| `parentController` | public UITutorialController |
| `currentTipIndex` | public int |
| `Target3D` | public GameObject |
| `tipSpacing` | public Vector2 |
| `tipEdgeBuffer` | public float |
| `mainCamera` | private Camera |
| `rectTransform` | private RectTransform |
| `tipCanvas` | private Canvas |
| `tipCanvasRT` | private RectTransform |
| `rootRT` | private RectTransform |
| `rootCanvasScaler` | private CanvasScaler |
| `currentRTChangeListener` | private RectTransformChangeListener |
| `hasSeenWholeTutorial` | private bool |
| `_instance` | private static TutorialTip |
| `ArrowDirection` | public enum |

### Methods

```csharp
private void Awake()
```

```csharp
private void Update()
```

```csharp
public void SetupTip(string locName, string locDesc, GameObject targetObject, UITutorialActionType tutorialAction, bool disableHighlightBlocker, bool nextFrame = false, TutorialTip.ArrowDirection arrowDirOverride = TutorialTip.ArrowDirection.None, GameObject fallbackTargetObject = null, Sprite tutorialImage = null, List<int> controlIDs = null, GameObject targetObject3D = null)
```

```csharp
private IEnumerator SetupTipWithDelay(string locName, string locDesc, GameObject targetObject, UITutorialActionType tutorialAction, bool disableHighlightBlocker, bool nextFrame = false, TutorialTip.ArrowDirection arrowDirOverride = TutorialTip.ArrowDirection.None, GameObject fallbackTargetObject = null, Sprite tutorialImage = null, List<int> controlIDs = null, GameObject targetObject3D = null)
```

```csharp
private void SetTipTextAndImage(string locName, string locDesc, Sprite image = null, List<int> controlIDs = null)
```

```csharp
public void FinishedTutorial(bool dontShowAgain = false)
```

```csharp
private void SetTipPosition(GameObject targetObject, TutorialTip.ArrowDirection arrowDirOverride = TutorialTip.ArrowDirection.None, bool oneFrameDelay = false)
```

```csharp
private void Position2DPointer(GameObject targetObject, RectTransform targetRT, TutorialTip.ArrowDirection arrowDirection = TutorialTip.ArrowDirection.Right, bool oneFrameDelay = false)
```

```csharp
private IEnumerator Position2DPointerWithDelay(GameObject targetObject, RectTransform targetRT, TutorialTip.ArrowDirection arrowDirection, bool oneFrameDelay = false)
```

```csharp
private void ResetTipPosition()
```

```csharp
private void SetArrowOrientation(Vector2 parentSize, TutorialTip.ArrowDirection arrowDirection = TutorialTip.ArrowDirection.Right)
```

```csharp
public void ClickedConfirm()
```

```csharp
public void ClickedBack()
```

```csharp
public void ClickedSkipTutorial()
```

```csharp
public void ClickedDontShowAgain()
```

```csharp
public void SetCanvasScaling()
```

```csharp
private void OnUIScaleChanged(UIScaleSettingChange e)
```

```csharp
private void UpdateUIScaling()
```

```csharp
private void OnDestroy()
```
