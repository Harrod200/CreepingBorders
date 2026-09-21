# VOController

*Decompiled from `PavonisInteractive/TerraInvicta/Audio/VOController.cs`.*


## Class `VOController`

```csharp
public class VOController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static VOController |
| `eventInstanceList` | private List<EventInstance> |
| `radioProcessingEarth` | private EventInstance |
| `radioProcessingSpace` | private EventInstance |
| `VOQueue` | private Coroutine |
| `_instance` | private static VOController |
| `instanceToRelease` | private EventInstance |

### Methods

```csharp
private void Awake()
```

```csharp
public void AddVOToQueue(EventInstance eventInstance, bool onEarth)
```

```csharp
public void AddVOToQueue(string eventPath, bool onEarth)
```

```csharp
private IEnumerator AddToQueue(EventInstance eventInstance, bool onEarth)
```
