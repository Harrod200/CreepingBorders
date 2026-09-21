# TINaturalSpaceObjectState

*Decompiled from `PavonisInteractive/TerraInvicta/TINaturalSpaceObjectState.cs`.*


## Class `TINaturalSpaceObjectState`

```csharp
public abstract class TINaturalSpaceObjectState : TISpaceObjectState
```

### Fields

| Name | Type |
|---|---|
| `naturalObjectTemplate` | public TINaturalSpaceObjectTemplate |
| `supportsAerocapture` | public virtual bool |
| `isNaturalSpaceObjectState` | public override bool |
| `searchable` | public override Searchable |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `population` | public virtual ulong |
| `orbitalPeriod_s` | public override double |
| `GetSunOrbitingRelatedObject` | public override TISpaceObjectState |
| `habsInSystem` | public virtual List<TIHabState> |
| `habs` | public virtual List<TIHabState> |
| `stationsInOrbit` | public List<TIHabState> |
| `fleetsInOrbit` | public List<TISpaceFleetState> |
| `fleetsInSystem` | public virtual List<TISpaceFleetState> |
| `orbits` | public List<TIOrbitState> |
| `HohmannDates` | public Dictionary<TINaturalSpaceObjectState, TIDateTime> |
| `_orbitalPeriod_s` | protected double |
| `_sunOrbitingRelatedObject` | protected TINaturalSpaceObjectState |
| `maxMaxHabTier` | public const int |

### Properties

- `public int maxHabTier`
- `public double sphereOfInfluence_m`
- `public float localBarycenterGravity_kps2`
- `public double hillRadius_m`

### Methods

```csharp
public TIEffectTemplate GetStandardEffectToExplore()
```

```csharp
public IEnumerable<TIEffectTemplate> GetExplorationEffectOptions()
```

```csharp
public virtual bool Colonized()
```

```csharp
public virtual bool Populous()
```

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
protected void CreateOrbitStates()
```

```csharp
public override void PostCanvasManagerCreateInit_3()
```

```csharp
public override void PostAllStartUpInit_5()
```

```csharp
public override void PostEverythingSaveRepair_8()
```

```csharp
public TIOrbitState GetClosestMatchingLegalOrbitState(OrbitalElementsState orbitalElementsToMatch)
```

```csharp
public List<TIOrbitState> NearbyOrbits()
```

```csharp
public void SetHillRadius_m()
```

```csharp
public double localAccelerationDueToGravity_ms2(double radius_m)
```

```csharp
public double localEscapeVelocity_mps(double radius_m)
```

```csharp
public string GetMaxTierIconPath()
```

```csharp
public static TIDateTime GetNextHohmannLaunchWindowDate(TIFactionState faction, TINaturalSpaceObjectState origin, TINaturalSpaceObjectState destination, TIDateTime time, out double synodicPeriod_s)
```

```csharp
public static List<TINaturalSpaceObjectState> GetFilteredSolarSystemGroupObjects(TISpaceBodyState Filter, bool includeSatellites)
```

```csharp
public string SummaryTooltip(TIFactionState faction)
```

```csharp
public string SolarInsolationIconPath(bool inline = false)
```

```csharp
public string SolarTip()
```
