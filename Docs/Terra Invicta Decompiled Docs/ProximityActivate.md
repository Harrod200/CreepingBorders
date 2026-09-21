# ProximityActivate

*Decompiled from `ProximityActivate.cs`.*


## Class `ProximityActivate`

```csharp
public class ProximityActivate : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `distanceActivator` | public Transform |
| `lookAtActivator` | public Transform |
| `distance` | public float |
| `activator` | public Transform |
| `activeState` | public bool |
| `target` | public CanvasGroup |
| `lookAtCamera` | public bool |
| `enableInfoPanel` | public bool |
| `infoIcon` | public GameObject |
| `alpha` | private float |
| `infoPanel` | public CanvasGroup |
| `originRotation` | private Quaternion |
| `targetRotation` | private Quaternion |

### Methods

```csharp
private void Start()
```

```csharp
private bool IsTargetNear()
```

```csharp
private void Update()
```
