# RadiatorVisController

*Decompiled from `PavonisInteractive/TerraInvicta/RadiatorVisController.cs`.*


## Class `RadiatorVisController`

```csharp
public class RadiatorVisController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `intactRadiatorModel` | public GameObject |
| `destroyedRadiatorModel` | public GameObject |
| `explosionPrefab` | public GameObject |
| `showDestroyedRetractedRadiator` | public bool |
| `explosionParticles` | private ParticleSystem |
| `explosionScale` | private float |

### Methods

```csharp
public void OnRadiatorRepaired()
```

```csharp
public void OnRadiatorDestroyed(bool radiatorsRetracted)
```

```csharp
public void OnPlay()
```

```csharp
public void OnPause()
```
