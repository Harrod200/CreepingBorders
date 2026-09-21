# FacilityMarkerController

*Decompiled from `PavonisInteractive/TerraInvicta/FacilityMarkerController.cs`.*


## Class `FacilityMarkerController`

```csharp
public class FacilityMarkerController : SingleMarkerController
```

### Fields

| Name | Type |
|---|---|
| `boostMarker` | public MarkerController |
| `missionControlMarker` | public MarkerController |
| `laserMarker` | public MarkerController |
| `launchState` | public TIRegionSpaceFacilityState |
| `missionControlState` | public TIRegionSpaceFacilityState |
| `laserState` | public TIRegionSpaceFacilityState |
| `targetingCouncilor` | private TICouncilorState |
| `missionTemplate` | private TIMissionTemplate |
| `eventInstance` | private EventInstance |
| `weaponController` | private BeamWeaponController |
| `weapon` | private BeamWeapon |
| `modelController` | private SpaceBodyController |
| `launchDataDirty` | private bool |
| `missionControlDataDirty` | private bool |
| `spaceDefensesDataDirty` | private bool |
| `RevertBoostMarkerStr` | private const string |

### Methods

```csharp
public override void InitializeWithRegion(RegionController regionController, MarkerContainerController container)
```

```csharp
private void Update()
```

```csharp
private void UpdateMarker(RegionDataUpdated e)
```

```csharp
private void UpdateMarker(MapActivationChangedEvent e)
```

```csharp
public void AttemptUpdateMarker()
```

```csharp
public override void UpdateMarker()
```

```csharp
public void OnLaunchDataUpdated(RegionEntityUpdated e)
```

```csharp
public void OnMCDataUpdated(RegionEntityUpdated e)
```

```csharp
public void OnSpaceDefenseDataUpdated(RegionEntityUpdated e)
```

```csharp
public void OnLaunchFacilityDamaged(SpaceFacilityTakesDamage e)
```

```csharp
public void OnMCFacilityDamaged(SpaceFacilityTakesDamage e)
```

```csharp
public void OnSpaceDefensesDamaged(SpaceFacilityTakesDamage e)
```

```csharp
private void RevertBoostMarker()
```

```csharp
public void LaunchRocket(TimeEventStart e)
```

```csharp
public void LaunchRocket(LaunchRocketEvent e)
```

```csharp
public void LaunchRocket()
```

```csharp
public void OnNewTargetSelected(MissionTargettedEvent e)
```

```csharp
public void ShutDownTargetingAnimations()
```

```csharp
public void ActivateFacilityButtons(CouncilorTargetSpaceFacilities e)
```

```csharp
public void ActivateFacilityButtonsForArmy(ArmyTargetSpaceFacilities e)
```

```csharp
public void DeactivateFacilityButtons(DeTargetSpaceFacilities e)
```

```csharp
private string LaunchSiteTooltip()
```

```csharp
public void UpdateBoostMarker()
```

```csharp
public void UpdateMissionControlMarker()
```

```csharp
public void UpdateLaserMarker()
```

```csharp
public void ShowSpaceFacilityMarker(MarkerController marker, TIRegionSpaceFacilityState facility)
```

```csharp
public void UpdateFacilitySuccessChanceString(MarkerController marker, TIGameState target)
```

```csharp
private bool InTargetingFacilityMode()
```

```csharp
private void OnMarkerClicked(MarkerController controller)
```

```csharp
public Vector3 BombardmentTargetPosition_Display(TISpaceFleetState fleet)
```

```csharp
public void DisplaySTOBeam(TISpaceShipState target, TIDateTime shotTime)
```

```csharp
public void CeaseDisplayingSTOBeam()
```

```csharp
public void OnCombatBegins(CombatStarts e)
```

```csharp
public void Facility3DModelHandler(string assetPath, TIRegionSpaceFacilityState facility)
```
