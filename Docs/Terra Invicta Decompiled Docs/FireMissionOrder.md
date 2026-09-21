# FireMissionOrder

*Decompiled from `PavonisInteractive/TerraInvicta/FireMissionOrder.cs`.*


## Class `FireMissionOrder`

```csharp
public class FireMissionOrder : GameEvent
```

### Fields

| Name | Type |
|---|---|
| `ship` | public TISpaceShipState |
| `target` | public TIGameState |
| `moduleData` | public ModuleDataEntry |
| `targetDisplayPosition` | public Vector3 |
| `targetLongitude` | public float |
| `targetLatitude` | public float |
| `parentSpaceBody` | public Transform |
| `parentCollider` | public SphereCollider |
| `time` | public TIDateTime |
| `doNotVisualize` | public bool |

### Methods

```csharp
public FireMissionOrder(TISpaceShipState ship, TIGameState target, ModuleDataEntry moduleData, Vector3 targetDisplayPosition, float targetLongitude, float targetLatitude, Transform parentSpaceBody, TIDateTime time, bool doNotVisualize = false)
```
