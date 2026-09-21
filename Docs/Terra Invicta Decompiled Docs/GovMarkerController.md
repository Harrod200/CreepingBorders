# GovMarkerController

*Decompiled from `PavonisInteractive/TerraInvicta/GovMarkerController.cs`.*


## Class `GovMarkerController`

```csharp
public class GovMarkerController : SingleMarkerController
```

### Fields

| Name | Type |
|---|---|
| `capitalRegion` | private bool |
| `regionStatusMarker` | public MarkerController |
| `capitalStatusMarker` | public MarkerController |
| `occupationMarker` | public MarkerController |
| `targetingCouncilor` | private TICouncilorState |
| `missionTemplate` | private TIMissionTemplate |
| `regionDataDirty` | private bool |
| `capitalMarkerDataDirty` | private bool |
| `designatedAnimationMarker` | private MarkerController |
| `animationsDataDirty` | private bool |

### Methods

```csharp
public override void InitializeWithRegion(RegionController regionController, MarkerContainerController container)
```

```csharp
private void UpdateCapitalMarker(RegionDataUpdated e)
```

```csharp
private void UpdateCapitalMarker(NationControlPointOwnerChanged e)
```

```csharp
private void UpdateCapitalMarker(ControlPointDataUpdated e)
```

```csharp
private void TryUpdateCapitalMarker()
```

```csharp
private void UpdateMarker(MajorRegionStatusChange e)
```

```csharp
private void UpdateMarker(OccupationStatusChange e)
```

```csharp
private void ResetAnimations(MapActivationChangedEvent e)
```

```csharp
private void TurnOffAllTargetingAnimations()
```

```csharp
private void TurnOffAllTargeting()
```

```csharp
private void UpdateMarkerNext()
```

```csharp
public void Update()
```

```csharp
public void OnNewTargetSelected(MissionTargettedEvent e)
```

```csharp
public int GetToHitPosition(MarkerController marker)
```

```csharp
public void ActivateControlPointButtons(TargetControlPoints e)
```

```csharp
public void DeactivateControlPointButtons(DeTargetControlPoints e)
```

```csharp
public void ActivateGovToHitValues(TargetGov e)
```

```csharp
public void DeactivateGovToHitValues(DeTargetGov e)
```

```csharp
public void ActivateRegionTargeting(TargetRegions e)
```

```csharp
public void DeactivateRegionTargeting(DeTargetRegions e)
```

```csharp
public void OnNuclearLaunch(NuclearLaunch e)
```

```csharp
public void OnNuclearStrike(NuclearStrike e)
```

```csharp
public void OnOccupationUnderway(RegionOccupationValueChange e)
```

```csharp
public MarkerController GetLiveMarkerForAnimations()
```

```csharp
public void OnRegionDamaged(RegionDamaged e)
```

```csharp
public override void UpdateMarker()
```

```csharp
public void TargetingAnimation()
```

```csharp
public void UpdateOccupationMarker(bool forceCreation = false)
```

```csharp
public void UpdateRegionStatusMarker()
```

```csharp
public void UpdateNationSuccessChanceString()
```

```csharp
public void UpdateCPSuccessChanceString(TIControlPoint controlPoint)
```

```csharp
public void UpdateRegionSuccessChanceString()
```

```csharp
private string GetOccupationString(TINationState leader, List<TINationState> leadAlliance, float leadOccupationValue)
```

```csharp
public void ShowOccupationProgress(MarkerController marker)
```

```csharp
public static string CapitalTooltip(TINationState nation)
```

```csharp
private void OnTotalControlIconPressed(MarkerController controller)
```

```csharp
public void UpdateCapitalMarker()
```
