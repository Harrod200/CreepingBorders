# TIHabDistrictState

*Decompiled from `PavonisInteractive/TerraInvicta/TIHabDistrictState.cs`.*


## Class `TIHabDistrictState`

```csharp
public class TIHabDistrictState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `ref_faction` | public override TIFactionState |
| `ref_hab` | public override TIHabState |
| `ref_orbit` | public override TIOrbitState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceAsset` | public override TISpaceAssetState |
| `hasMapObject` | public override bool |
| `inSpace` | public override bool |
| `defended` | public bool |
| `gameStateSubjectCreated` | private bool |
| `createdFromTemplate` | private bool |

### Properties

- `public TIHabState hab`
- `public TIFactionState faction`
- `public TIDateTime defendExpiration`
