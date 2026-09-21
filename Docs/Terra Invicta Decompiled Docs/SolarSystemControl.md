# SolarSystemControl

*Decompiled from `PavonisInteractive/TerraInvicta/SolarSystemControl.cs`.*


## Class `SolarSystemControl`

```csharp
public class SolarSystemControl : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `container` | private GameObjectDictionary<string> |
| `orbitTrailContainer` | private GameObjectDictionary<string> |
| `_container` | private GameObjectDictionary<string> |
| `_orbitTrailContainer` | private GameObjectDictionary<string> |
| `storedMask` | private int |
| `shuttingDown` | private bool |
| `isEnabled` | private bool |
| `showDistantSymbols` | public bool |
| `showProspectData` | public bool |
| `showAllColonizedNames` | public bool |
| `mainCamera` | public Camera |

### Methods

```csharp
public void Awake()
```

```csharp
public void AddObject(GameObject newObject, bool worldPositionStays = true)
```

```csharp
public void DestroySolarSystem()
```

```csharp
public void AddOrbitTrailToContainer(GameObject orbitTrail)
```

```csharp
public void TurnOffOrbitTrails()
```

```csharp
public void TurnOnOrbitTrails()
```

```csharp
public void ToggleOrbitTrails()
```

```csharp
public void ToggleDistantSymbols()
```

```csharp
public void ToggleProspectData()
```

```csharp
public void ToggleShowAllColonizedBodyNames()
```

```csharp
public Transform FindObject(string name)
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
public void DisableSolarSystem()
```

```csharp
public void DisableSolarSystemObjectsForSkirmishMode(IScenario scenario)
```

```csharp
private void OnDestroy()
```
