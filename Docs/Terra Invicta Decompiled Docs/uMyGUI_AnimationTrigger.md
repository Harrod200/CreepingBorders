# uMyGUI_AnimationTrigger

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_AnimationTrigger.cs`.*


## Class `uMyGUI_AnimationTrigger`

```csharp
public class uMyGUI_AnimationTrigger : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `m_animation` | private Animation |
| `m_clipName` | private string |
| `m_condition` | private uMyGUI_AnimationTrigger.ETriggerMode |
| `m_isActivateOnAnimStart` | private bool |
| `m_isDeactivateOnAnimEnd` | private bool |
| `m_alternativeCoroutineWorker` | private MonoBehaviour |
| `m_redirectDestination` | private GameObject |
| `ETriggerMode` | public enum |

### Methods

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void uMyGUI_OnActivateTab()
```

```csharp
private void uMyGUI_OnDeactivateTab()
```

```csharp
private void Play()
```

```csharp
private IEnumerator DeactivateAfterDelay(GameObject p_object, float p_delay)
```
