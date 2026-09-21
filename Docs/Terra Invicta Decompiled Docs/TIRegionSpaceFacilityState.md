# TIRegionSpaceFacilityState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionSpaceFacilityState.cs`.*


## Class `TIRegionSpaceFacilityState`

```csharp
public abstract class TIRegionSpaceFacilityState : TIRegionEntityState
```

### Fields

| Name | Type |
|---|---|
| `isRegionSpaceFacility` | public override bool |
| `ref_faction` | public override TIFactionState |
| `ref_factions` | public override List<TIFactionState> |
| `ref_regionSpaceFacility` | public override TIRegionSpaceFacilityState |
| `template` | public TIRegionTemplate |
| `FacilityMarkerController` | public FacilityMarkerController |

### Properties

- `public SpaceFacilityType spaceFacilityType`

### Methods

```csharp
public abstract float GetAIValuation()
```

```csharp
public void InitWithRegionState(SpaceFacilityType facilityType, TIRegionState regionState)
```

```csharp
public abstract int GetSize()
```

```csharp
public bool UnderArmyAssault()
```
