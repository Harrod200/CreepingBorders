# SimpleCharacterMotor

*Decompiled from `SimpleCharacterMotor.cs`.*


## Class `SimpleCharacterMotor`

```csharp
public class SimpleCharacterMotor : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `cursorLockMode` | public CursorLockMode |
| `cursorVisible` | public bool |
| `walkSpeed` | public float |
| `runSpeed` | public float |
| `gravity` | public float |
| `cameraPivot` | public Transform |
| `lookSpeed` | public float |
| `invertY` | public bool |
| `movementAcceleration` | public float |
| `controller` | private CharacterController |
| `movement` | private Vector3 |
| `finalMovement` | private Vector3 |
| `speed` | private float |
| `targetRotation` | private Quaternion |
| `targetPivotRotation` | private Quaternion |

### Methods

```csharp
private void Awake()
```

```csharp
private void Update()
```

```csharp
private void UpdateLookRotation()
```

```csharp
private void UpdateTranslation()
```
