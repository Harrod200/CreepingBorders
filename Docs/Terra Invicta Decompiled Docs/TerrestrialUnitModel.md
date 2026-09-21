# TerrestrialUnitModel

*Decompiled from `PavonisInteractive/TerraInvicta/TerrestrialUnitModel.cs`.*


## Class `TerrestrialUnitModel`

```csharp
public class TerrestrialUnitModel : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Animator` | public Animator |
| `animator` | private Animator |
| `animatorInitialized` | private bool |
| `FirePosition` | public Transform |
| `FireEffectPrefab` | public GameObject |
| `OnFire` | private TerrestrialUnitModel.OnFireDelegate |

### Methods

```csharp
private void Start()
```

```csharp
public void AnimationEvent_Fire()
```

```csharp
public delegate void OnFireDelegate()
```
