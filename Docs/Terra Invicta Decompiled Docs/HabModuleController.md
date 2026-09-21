# HabModuleController

*Decompiled from `PavonisInteractive/TerraInvicta/HabModuleController.cs`.*


## Class `HabModuleController`

```csharp
public class HabModuleController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `ExodusConstructionID` | private string |
| `habModule` | public TIHabModuleState |
| `CombatHabModuleController` | public CombatHabModuleController |
| `sector` | public int |
| `moduleNum` | public int |
| `highlighted` | public bool |
| `_habModuleState` | private TIHabModuleState |
| `initializedModuleTemplate` | private TIHabModuleTemplate |
| `ExodusShipRootObject` | public Transform |
| `shipContructionRootObject` | public Transform[] |
| `shipPrefab` | public GameObject |
| `shipyard` | private bool |
| `projectExodusStarted` | private bool |
| `shipVisObject` | private GameObject |
| `shipConstructionVisController` | private ShipConstructionVisController |
| `gameTime` | private GameTimeManager |
| `exodusConstructionTimeEvent` | private TIDateTime |

### Properties

- `public TIHabState hab`
- `public List<MeshRenderer> renderers`
- `public HabModelController habModelController`
- `public HabModuleUIElementController UIController`
- `public bool fullVisualization`

### Methods

```csharp
public void Initialize(bool includingUIControllers)
```

```csharp
public void SetHighlightColor(MeshRenderer rend)
```

```csharp
public void SetNormalColor(MeshRenderer rend)
```

```csharp
public void SetModuleValue(TIHabState hab, HabModelController habModelController, bool fullVisualization)
```

```csharp
private void OnHabModuleUpdated(HabModuleConstructionStatusChange e)
```

```csharp
public void CreateShipConstructionVisControllerObject()
```

```csharp
public void UpdateModuleData()
```

```csharp
public void DuplicateMaterialsForUIDisplay()
```

```csharp
private void AddListeners()
```

```csharp
private void RemoveListeners()
```

```csharp
private void ShipConstructionCompleted(ShipConstructionCompleted e)
```

```csharp
private void UpdateShipConstructionAssets(TimeEventStart e)
```

```csharp
private void UpdateShipConstructionAssets(ShipConstructionUpdated e)
```

```csharp
public void DestroyHabModule(TIFactionState destroyer)
```

```csharp
private IEnumerator DestroyModuleDelayed(TIFactionState destroyer, float delay)
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
public void OnDestroy()
```
