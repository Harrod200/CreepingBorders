# TIOfficerState

*Decompiled from `PavonisInteractive/TerraInvicta/TIOfficerState.cs`.*


## Class `TIOfficerState`

```csharp
public class TIOfficerState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `isOfficerState` | public override bool |
| `ref_officer` | public override TIOfficerState |
| `ref_faction` | public override TIFactionState |
| `ref_fleet` | public override TISpaceFleetState |
| `ref_ship` | public override TISpaceShipState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_orbit` | public override TIOrbitState |
| `ref_hab` | public override TIHabState |
| `ref_habSite` | public override TIHabSiteState |
| `ref_spaceAsset` | public override TISpaceAssetState |
| `inSpace` | public override bool |
| `DisplayNameAndShipAndJob` | public string |
| `DisplayNameAndJob` | public string |
| `FullDescription` | public string |
| `template` | public TIOfficerTemplate |
| `OfficerCarrier` | public OfficerCarrierState |
| `location` | public OfficerCarrierState |
| `priorShips` | public List<TISpaceShipState> |

### Properties

- `public string officerName`
- `public int rank`
- `public int maxRank`
- `public TISpaceShipState ship`
- `public TIHabState hab`
- `public TIOfficerTemplate _template`
- `public TIDateTime creationDate`
- `public TIDateTime retirementDate`
- `public bool isDummy`

### Methods

```csharp
public override void PostCanvasManagerCreateInit_3()
```

```csharp
public void SetDisplayName()
```

```csharp
public string GetIconPath()
```

```csharp
public static TIOfficerState CreateOfficer(string templateName, TISpaceShipState ship)
```

```csharp
public bool OfficerAllowedForShip(TISpaceShipState candidateShip, bool swap, int additionalProposedTransfersToShip)
```

```csharp
public List<OfficerRequirement> OfficerAllowedForShipFail(TISpaceShipState candidateShip, bool swap, int additionalProposedTransfersToShip)
```

```csharp
public bool ProposedTransferIsSwap(OfficerCarrierState other, List<TIOfficerState> proposedNewOfficersOnOther)
```

```csharp
public TIOfficerState ProposedOfficerSwap(TISpaceShipState otherShip, List<TIOfficerState> proposedNewOfficersOnOther)
```

```csharp
public bool CanTransferOfficer(OfficerCarrierState currentLocation, OfficerCarrierState candidateLocation, bool overrideLocation, bool swap, int additionalProposedTransfersToCandidate)
```

```csharp
public bool CanTransferOfficerBetweenShips(TISpaceShipState currentShip, TISpaceShipState candidateShip, bool overrideLocation, bool swap, int additionalProposedTransfersToShip)
```

```csharp
public bool CanTransferOfficerFromHab(TIHabState hab, TISpaceShipState candidateShip, bool overrideLocation, bool swap, int additionalProposedTransfersToShip)
```

```csharp
public bool CanTransferOfficerToHab(TIHabState hab, bool overrideLocation, bool swap, int additionalProposedTransfersToHab)
```

```csharp
public bool CanTransferOfficersBetweenHabs(TIHabState destination, bool overrideLocation, int additionalProposedTransfersToHab)
```

```csharp
public TIResourcesCost CostToTransfer(OfficerCarrierState destination)
```

```csharp
public bool AnyEligibleTransfers(bool allowSwapsAndBigfoots)
```

```csharp
public List<OfficerCarrierState> GetEligibleTransfers(bool allowSwapsAndBigfoots)
```

```csharp
public bool Promote()
```

```csharp
public void RetireOfficer()
```

```csharp
public void DeleteOfficer(bool KIA)
```

```csharp
public bool TransferOfficerBetweenShips(TISpaceShipState newShip, bool refitTransfer, bool swap, bool overrideChecks = false)
```

```csharp
public bool TransferOfficer_FromHabToShip(TISpaceShipState newShip, bool swap, bool skipValidation = false)
```

```csharp
public bool TransferOfficer_ToHab(TIHabState hab, bool overrideLocation, bool swap, bool skipValidation = false)
```

```csharp
public bool TransferOfficerBetweenHabs(TIHabState destination)
```

```csharp
public bool ValidEscapeHab(TIHabState destination)
```

```csharp
public bool Escape(bool allowToSameFleet, bool forceToDockedHab)
```

```csharp
public void OnOfficerChange()
```

```csharp
public float SumOfficerEffects(OfficerEffectType effectType, float baseValue)
```

```csharp
public static string RankStarsInline(int rank)
```

```csharp
public TIOfficerState CreateDummy(TISpaceShipState ship)
```
