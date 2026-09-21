# TIResourcesCost

*Decompiled from `PavonisInteractive/TerraInvicta/TIResourcesCost.cs`.*


## Class `TIResourcesCost`

```csharp
public class TIResourcesCost
```

### Fields

| Name | Type |
|---|---|
| `anyDebit` | public bool |
| `anyCredit` | public bool |
| `spaceResources` | public static readonly HashSet<FactionResource> |
| `basicSpaceResources` | public static readonly HashSet<FactionResource> |
| `basicSpaceResourcesSansFissiles` | public static readonly HashSet<FactionResource> |
| `replaceableSpaceResources` | public static readonly HashSet<FactionResource> |
| `irreplaceableSpaceResources` | public static readonly HashSet<FactionResource> |
| `unTradeableResources` | public static readonly HashSet<FactionResource> |
| `tradeableResources` | public static readonly HashSet<FactionResource> |
| `unAccumulatableResources` | public static readonly HashSet<FactionResource> |
| `accumulatableResources` | public static readonly HashSet<FactionResource> |
| `habResources` | public static readonly HashSet<FactionResource> |
| `farmResources` | public static readonly HashSet<FactionResource> |

### Properties

- `public List<ResourceValue> resourceCosts`
- `public float completionTime_days`
- `public static readonly HashSet<FactionResource> resourcesAllowedToGoNegative = new HashSet<FactionResource>`

### Methods

```csharp
public TIResourcesCost()
```

```csharp
public TIResourcesCost(FactionResource resource, float value)
```

```csharp
public TIResourcesCost(List<ResourceValue> resources)
```

```csharp
public TIResourcesCost(TIResourcesCost costToCopy)
```

```csharp
public void SetCompletionTime_Days(float value)
```

```csharp
public void AddToCompletionTime_Days(float value)
```

```csharp
public void ConstructCost(params ResourceValue[] resourceCostArray)
```

```csharp
public float GetSingleCostValue(FactionResource resource)
```

```csharp
public TIResourcesCost CreateSingleCost(FactionResource resource)
```

```csharp
public void AddCost(FactionResource resourceToAdd, float resourceAmount, bool allowNegative = true)
```

```csharp
public void RemoveCost(FactionResource resourceToRemove)
```

```csharp
public void SumCosts_NoDuration(TIResourcesCost costToAdd)
```

```csharp
public void SumCostsWithDuration(TIResourcesCost costToAdd)
```

```csharp
public void SubtractRefitDiscountCost(TIResourcesCost costToDiscount)
```

```csharp
public TIResourcesCost GetBoostSubstitutedCost(TIFactionState faction, TIGameState location, bool ignoreTime = false, List<ResourceValue> availableResources = null)
```

```csharp
public void SubtractRefitPropellantCost(TIResourcesCost costToDiscount)
```

```csharp
public void GetRefundCost(out TIResourcesCost refundCost)
```

```csharp
public bool CanAfford(TIFactionState faction, float maxFractionCanSpend = 1f, List<FactionResource> resourcesToPreserve = null, float maxDays = float.PositiveInfinity)
```

```csharp
public static bool ShouldTapSavings(TIFactionState faction, TIDataTemplate desiredPurchase = null, TIGameState purchaseLocation = null, int importance = 1)
```

```csharp
public TIResourcesCost GetShortfall(TIFactionState faction, TIDataTemplate desiredPurchase = null, TIGameState purchaseLocation = null, int importance = 1, bool tapSavings = false)
```

```csharp
public bool CanAfford_AI(TIFactionState faction, TIDataTemplate desiredPurchase = null, TIGameState purchaseLocation = null, int importance = 1, bool isPlanned = false, bool tapSavings = false, float maxFractionCanSpend = 1f, List<FactionResource> resourcesToPreserve = null, float maxDays = float.PositiveInfinity)
```

```csharp
public bool CanPayInFuture(TIFactionState faction, int daysInTheFuture = 180)
```

```csharp
public int CanAfford_Count(TIFactionState faction, Dictionary<FactionResource, float> resourcesAvailable = null)
```

```csharp
public List<ResourceValue> LackingResources(TIFactionState faction)
```

```csharp
public void PayCost(TIFactionState faction, string label = null)
```

```csharp
public void RefundCost(TIFactionState faction, string label = null)
```

```csharp
public string GetString(string format, bool includeCostStr, bool includeCompletionTime, bool completionTimeOnly, int relevantCap = 7, bool costsOnly = false, bool gainsOnly = false, TIFactionState faction = null, bool iconsOnly = false, FactionResource resourceForZero = FactionResource.None)
```

```csharp
public TIResourcesCost MultiplyCost(float modifier)
```

```csharp
public string ToString(string format = "Relevant", bool gainsOnly = false, bool costsOnly = false, TIFactionState faction = null, bool iconsOnly = false, FactionResource resourceIconForAllZero = FactionResource.None)
```
