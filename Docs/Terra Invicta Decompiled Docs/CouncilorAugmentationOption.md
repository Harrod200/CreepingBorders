# CouncilorAugmentationOption

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilorAugmentationOption.cs`.*


## Struct `CouncilorAugmentationOption`

```csharp
public struct CouncilorAugmentationOption
```

### Properties

- `public CouncilorAttribute stat`
- `public int statValue`
- `public TITraitTemplate traitToGain`
- `public TITraitTemplate traitToLose`
- `public TIResourcesCost resourceCost`
- `public int XPCost`

### Methods

```csharp
public void SetAugmentationStrings(out string description1, out string description2, out string tooltipDescription, out string costString)
```

```csharp
public CouncilorAugmentationOption(CouncilorAttribute stat, TITraitTemplate trait, float addTraitCostMultiplier, float addTraitMoneyCostMultiplier, float councilorXPModifier)
```

```csharp
public bool CouncilorEligibleForAugmentation(TICouncilorState councilor)
```

```csharp
public bool CouncilorCanAfford(TICouncilorState councilor)
```
