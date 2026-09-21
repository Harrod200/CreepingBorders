# TIVFXManager

*Decompiled from `PavonisInteractive/TerraInvicta/TIVFXManager.cs`.*


## Class `TIVFXManager`

```csharp
public class TIVFXManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static TIVFXManager |
| `AlienGlowGO` | public GameObject |
| `BigExplosionGO` | public GameObject |
| `RocketTrailGO` | public GameObject |
| `TinyFlamesGO` | public GameObject |
| `ArtilleryFlashesGO` | public GameObject |
| `NukeLaunchGO` | public GameObject |
| `NukeStrikeGO` | public GameObject |
| `LinearFlamesGO` | public GameObject |
| `AlienMobileLightsGO` | public GameObject |
| `ReentryFlamesGO` | public GameObject |
| `freeVFXPrefabs` | private Dictionary<string, Dictionary<int, GameObject>> |
| `init` | private bool |
| `_instance` | private static TIVFXManager |
| `EarthMarkerVFX` | public static class |
| `AlienGlow` | public const string |
| `BigExplosion` | public const string |
| `RocketTrail` | public const string |
| `TinyFlames` | public const string |
| `ArtilleryFlashes` | public const string |
| `NukeLaunch` | public const string |
| `NukeStrike` | public const string |
| `LinearFlames` | public const string |
| `AlienMobileLights` | public const string |
| `ReentryFlames` | public const string |

### Methods

```csharp
private void Awake()
```

```csharp
public void CreateCombatVFXBuffer(List<CombatShipController> shipsInCombat)
```

```csharp
public void CachePrefabs()
```

```csharp
private void AddObjectToPool(string poolKey, GameObject objectToAdd)
```

```csharp
private int GetPoolCount(string poolKey)
```

```csharp
public static GameObject GetVFX(string name, Transform parent = null)
```

```csharp
public static void ReturnVFX(string name, GameObject obj)
```
