# ModelAnimatorController

*Decompiled from `PavonisInteractive/TerraInvicta/Animations/ModelAnimatorController.cs`.*


## Class `ModelAnimatorController`

```csharp
public class ModelAnimatorController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `canAnimate` | private bool |
| `loadedModelName` | private string |
| `GetAnimationState` | public ModelAnimatorController.AnimationState |
| `IDLE` | private const string |
| `MOVE` | private const string |
| `TURN_LEFT` | private const string |
| `TURN_RIGHT` | private const string |
| `DESTROYED` | private const string |
| `DAMAGED` | private const string |
| `ATTACK_1` | private const string |
| `ATTACK_2` | private const string |
| `ATTACK_3` | private const string |
| `ATTACK_TYPE_COUNT` | private const string |
| `canIdle` | private bool |
| `canDamaged` | private bool |
| `currentState` | private ModelAnimatorController.AnimationState |
| `AnimationState` | public enum |

### Properties

- `public TerrestrialUnitModel unitModel`

### Methods

```csharp
private void OnEnable()
```

```csharp
public void PlayAnimationState(ModelAnimatorController.AnimationState state)
```

```csharp
public void UpdateAnimatorController(GameObject prefab)
```

```csharp
public void PlayIdle(bool force)
```

```csharp
public void PlayMove(bool force)
```

```csharp
public void PlayDamaged(bool force)
```

```csharp
public void PlayDestroyed(bool force)
```

```csharp
public void PlayTurnLeft(bool force)
```

```csharp
public void PlayTurnRight(bool force)
```

```csharp
public void PlayAttack(bool force)
```
