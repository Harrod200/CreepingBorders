# ThrustProfileTool

*Decompiled from `PavonisInteractive/TerraInvicta/ThrustProfileTool.cs`.*


## Class `ThrustProfileTool`

```csharp
public class ThrustProfileTool : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `LowestDVFound_kps` | public double |
| `CurrentTrajectory` | public Trajectory |
| `CanReachTarget` | public bool |
| `Actor` | public IMobileAsset |
| `Fleet` | private TISpaceFleetState |
| `isActorAFleet` | private bool |
| `Target` | public TIGameState |
| `thrustProfileSelectionPanel` | public GameObject |
| `thrustProfileImpossiblePanel` | public GameObject |
| `thrustProfilePanelHeader` | public TMP_Text |
| `thrustProfileImpossibleReportText` | public TMP_Text |
| `DVSlider` | public Slider |
| `accelerationText` | public TMP_Text |
| `DVText` | public TMP_Text |
| `tripDurationText` | public TMP_Text |
| `loiterDurationText` | public TMP_Text |
| `launchDateText` | public TMP_Text |
| `arrivalDateText` | public TMP_Text |
| `interceptionWarningObject` | public GameObject |
| `interceptionWarning` | public TMP_Text |
| `fleetFollowWarningObject` | public GameObject |
| `fleetFollowWarning` | public TMP_Text |
| `thrustPanelSortByLaunchDateToggle` | public Toggle |
| `thrustPanelSortByArrivalDateToggle` | public Toggle |
| `thrustPanelSortByDeltaVCostToggle` | public Toggle |
| `thrustPanelAllowAerocaptureToggle` | public Toggle |
| `thrustPanelFlyByToggle` | public Toggle |
| `thrustPanelRepairandResupplyGameObject` | public GameObject |
| `thrustPanelRepairandResupplyToggle` | public Toggle |
| `thrustPanelSortByHeaderText` | public TMP_Text |
| `thrustPanelSortByLaunchDateText` | public TMP_Text |
| `thrustPanelSortByArrivalDateText` | public TMP_Text |
| `thrustPanelSortByDeltaVCostText` | public TMP_Text |
| `thrustPanelSpecialManeuverText` | public TMP_Text |
| `thrustProfilePanelAeroCaptureText` | public TMP_Text |
| `thrustProfilePanelFlyByText` | public TMP_Text |
| `thurstProfileRepairandResupplyText` | public TMP_Text |
| `currentTrajectory` | private Trajectory |
| `candidateTrajectories` | private Trajectory[] |
| `availDV` | private double |
| `availDVstr` | private string |
| `lowestDVFound_kps` | private double |
| `isChangeTrajectory` | public bool |
| `actor` | private IMobileAsset |
| `target` | private TIGameState |
| `GetHeaderString` | public Func<ThrustProfileTool, string> |
| `onCandidateTrajectoriesComputed` | public ThrustProfileTool.OnCandidateTrajectoriesComputed |
| `transferComputationError` | public bool |

### Properties

- `public TransferResult transferResult`

### Methods

```csharp
public void UpdateTargetWithoutComputingNewTrajectories(TIGameState newTarget)
```

```csharp
private void Awake()
```

```csharp
public void UpdateUI()
```

```csharp
public void UpdateDVDetails()
```

```csharp
public void ComputeCandidateTrajectories()
```

```csharp
private void GenerateCandidateTrajectories()
```

```csharp
private void SortTrajectories()
```

```csharp
public void DisplayFailureReport(string errorReport)
```

```csharp
public void Open(IMobileAsset mobileSpaceAsset, TIGameState target, Trajectory[] precomputedTrajectories = null)
```

```csharp
public void Open()
```

```csharp
public void Close()
```

```csharp
public void OnDVSliderChangedValue()
```

```csharp
public void SortByStartDate()
```

```csharp
public void SortByArrival()
```

```csharp
public void SortByDeltaV()
```

```csharp
public void OnSortByStartDateSelected(bool value)
```

```csharp
public void OnSortByArrivalDateSelected(bool value)
```

```csharp
public void OnSortByDeltaVSelected(bool value)
```

```csharp
public void OnAerocaptureSelected()
```

```csharp
public void OnFlyBySelected()
```

```csharp
public void OnRepairAndResupplySelected()
```

```csharp
public static string DigestibleTimeStr(TimeSpan duration)
```

```csharp
public delegate void OnCandidateTrajectoriesComputed()
```
