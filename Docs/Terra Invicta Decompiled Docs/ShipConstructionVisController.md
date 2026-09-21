# ShipConstructionVisController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipConstructionVisController.cs`.*


## Class `ShipConstructionVisController`

```csharp
public class ShipConstructionVisController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `currentBuildStep` | private int |
| `daysToCompletion` | private double |
| `lastCheckedPercentage` | private double |
| `startDate` | private TIDateTime |
| `modelShip` | private GameObject |
| `shipModelController` | private ShipModelController |
| `constructionSparkParticleInstances` | private List<GameObject> |
| `projectExodusShipPrefabs` | private GameObject[] |
| `instantiatedshipPhase` | private int |
| `visRootObject` | private Transform |
| `shipVisController` | private ShipVisController |
| `humanConstructionSparkParticlePrefab` | private GameObject |
| `alienConstructionSparkParticlePrefab` | private GameObject |
| `yOffset` | private float |
| `isExodusProjectModule` | private bool |
| `constructionProgress` | private double |
| `modelPending` | public bool |

### Properties

- `public ShipConstructionQueueItem shipItem`
- `public TISpaceShipTemplate shipTemplate`
- `public bool showingShipBuilding`

### Methods

```csharp
public void TrackExodusShipConstruction(Transform root, TIDateTime startDate, double daysToCompletion)
```

```csharp
public void SetNewShipConstruction(ShipConstructionQueueItem item, float yOffset)
```

```csharp
private IEnumerator InitializeShipModelWithDelay()
```

```csharp
private void InitializeShipModel()
```

```csharp
public void EndShipConstruction()
```

```csharp
public double UpdateShipProgress()
```

```csharp
private void InstantiateParticleEffects(Transform modelInstance, bool isAlien = false)
```

```csharp
private void DestroyParticleEffects()
```
