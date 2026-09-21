# ViewControl

*Decompiled from `ViewControl.cs`.*


## Class `ViewControl`

```csharp
public class ViewControl : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `currentView` | public ViewType |
| `selection` | private SpaceObjectSelection |
| `eventManager` | private EventManager |
| `solarSystem` | private SolarSystemControl |
| `spaceCombat` | private SpaceCombatManager |
| `globalRegionEffectRenderer` | private RegionEffectRenderer |
| `naturalSpaceSymbolTooltips` | public static List<TooltipTrigger> |
| `strategyLayerComponentsActive` | private bool |
| `assigned` | private bool |

### Properties

- `public GameObject earthObject`

### Methods

```csharp
public void Awake()
```

```csharp
public void StartSession()
```

```csharp
public void Initialize()
```

```csharp
public void SetEarthObject(SpaceObjectController container)
```

```csharp
public void SetAllStrategyLayerECSComponents(bool enable)
```

```csharp
private void SetNaturalSpaceSymbolTooltips(bool enable)
```

```csharp
public static void SetEnableAllStrategyShipModels(bool enable)
```

```csharp
private void MapChanged(MapActivationChangedEvent e)
```

```csharp
public void GotoView(ViewType newView)
```

```csharp
public void ClearGameData(bool loadGame = false)
```

```csharp
private IEnumerator CleanupData()
```

```csharp
private void CleanupTextures()
```

```csharp
private void ClearAllEntities()
```

```csharp
public void DisableSolarSystemForSkirmishMode(IScenario scenario)
```
