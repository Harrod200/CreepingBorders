# AlienMarkerController

*Decompiled from `PavonisInteractive/TerraInvicta/AlienMarkerController.cs`.*


## Class `AlienMarkerController`

```csharp
public class AlienMarkerController : SingleMarkerController
```

### Fields

| Name | Type |
|---|---|
| `Targeting` | private bool |
| `alienFacilityMarker` | public MarkerController |
| `alienFacility` | private TIRegionAlienFacilityState |
| `alienActivityMarker` | public MarkerController |
| `alienActivity` | private TIRegionAlienActivityState |
| `alienLandingMarker` | public MarkerController |
| `alienLanding` | private TIRegionUFOLandingState |
| `alienCrashdownMarker` | public MarkerController |
| `alienCrashdown` | private TIRegionUFOCrashdownState |
| `xenoformingMarker` | public MarkerController |
| `xenoforming` | private TIRegionXenoformingState |
| `councilorTargetingAlienSurfaceAssetMode` | private bool |
| `councilorTargetingAlienActivity` | private bool |
| `armyTargetingAlienSurfaceAssetMode` | private bool |
| `targetingCouncilor` | private TICouncilorState |
| `missionTemplate` | private TIMissionTemplate |
| `currentTargetList` | private List<TIGameState> |
| `targetingArmy` | private TIArmyState |
| `operationTemplate` | private IOperation |
| `gameTime` | private GameTimeManager |
| `markerDataDirty` | private bool |
| `crashdownVisualizationFired` | public bool |

### Methods

```csharp
public override void InitializeWithRegion(RegionController regionController, MarkerContainerController container)
```

```csharp
public void Update()
```

```csharp
public void AttemptUpdateMarker()
```

```csharp
public override void UpdateMarker()
```

```csharp
public void UpdateAllMarkersForActivityEvent(AlienRegionEntityUpdated e)
```

```csharp
public void UpdateForCrashdown(AlienCrashdownInRegion e)
```

```csharp
public void UpdateAllMarkersForMapActivation(MapActivationChangedEvent e)
```

```csharp
public void UpdateAllMarkers()
```

```csharp
public void ActivateAssetTargetsForCouncilor(CouncilorTargetAlienAsset e)
```

```csharp
public void ActivateAssetTargetsForArmy(ArmyTargetAlienAsset e)
```

```csharp
public void ActivateActivityTargetsForCouncilor(CouncilorTargetAlienActivity e)
```

```csharp
public void DeactivateActivityTargets(DeTargetAlienActivity e)
```

```csharp
public void DeactivateAssetTargets(DeTargetAlienAssets e)
```

```csharp
private void OnAlienFacilityDamaged(AlienFacilityDamaged e)
```

```csharp
private void OnAlienLandingDamaged(AlienLandingDamaged e)
```

```csharp
private void OnXenoformingDamaged(XenoformingDamaged e)
```

```csharp
private void OnXenoformingDestroyed(XenoformingDestroyed e)
```

```csharp
private void OnXenoformingAttacking(TIGameStateAttacking e)
```

```csharp
public void OnNewTargetSelected(MissionTargettedEvent e)
```

```csharp
public void UpdateXenoformingMarker(RegionXenoformingIntelUpdate e)
```

```csharp
public void ShutdownAllTargetingAnimations()
```

```csharp
private void AlertAnimation(MarkerController marker)
```

```csharp
private void TargetingAnimation(MarkerController marker)
```

```csharp
private void SetAnimationOnMarker(MarkerController marker)
```

```csharp
public void UpdateAlienMarker(MarkerController marker, TIRegionAlienEntityState alienEntity)
```

```csharp
public void UpdateAlienActivityMarker()
```

```csharp
private void UpdateAlienLandingMarker()
```

```csharp
private void UpdateAlienCrashdownMarker()
```

```csharp
private void UpdateAlienFacilityMarker()
```

```csharp
private void UpdateXenoformingMarker()
```

```csharp
private bool SetCouncilorTargeting(MarkerController marker)
```

```csharp
private bool SetArmyTargeting(MarkerController marker)
```

```csharp
private bool TargetingButInvalidTarget(MarkerController marker)
```

```csharp
private void TriggerUIEffects(MarkerController controller)
```

```csharp
private void OnAlienFacilityClicked(MarkerController controller)
```

```csharp
private void OnAlienActivityClicked(MarkerController controller)
```

```csharp
private void OnAlienLandingClicked(MarkerController controller)
```

```csharp
private void OnAlienCrashdownClicked(MarkerController controller)
```

```csharp
private void OnXenoformingMarkerClicked(MarkerController controller)
```
