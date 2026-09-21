# TradeAI

*Decompiled from `TradeAI.cs`.*


## Class `TradeAI`

```csharp
public static class TradeAI
```

### Fields

| Name | Type |
|---|---|
| `cachedResourceTradeData` | private static Dictionary<TIFactionState, Dictionary<FactionResource, TradeAI.ResourceTradeData>> |
| `tradeDataCachedFrame` | private static int |
| `CategoryType` | private enum |
| `ResourceTradeData` | private struct |
| `RevenuePerDay` | public float |
| `CostPerDay` | public float |
| `StorageDays` | public float |
| `CategoryScoreType` | private enum |

### Methods

```csharp
public static TradeOffer.TradeAgreement CreateTradeAgreement(TIFactionState agreementCreator, TIFactionState agreementRecipient)
```

```csharp
public static void PrepareCachesForTrading(TIFactionState faction, TIFactionState otherFaction)
```

```csharp
private static TradeOffer MakeDemands(TradeAI.CategoryType category, TIFactionState demandMaker, TIFactionState demandRecipient)
```

```csharp
private static IEnumerable<T> FilterTradeCandidatesForEfficiency<T>(IEnumerable<T> tradeCandidates, Func<T, float> GetEfficiency, int minimumCount = 1)
```

```csharp
private static float GetTradeEfficiency(float valueToGiver, float valueToRecipient)
```

```csharp
private static TradeAI.ResourceTradeData GetResourceTradeData(TIFactionState faction, FactionResource resource)
```

```csharp
private static float GetMiscResourceModifier(TIFactionState faction, FactionResource resource)
```

```csharp
public static float GetResourceStorageModifier(TIFactionState faction, FactionResource resource, float hypotheticalAdditionalStoredQuantity)
```

```csharp
private static float GetTradeValue_Segment(TIFactionState faction, FactionResource resource, float quantity, float hypotheticalAdditionalStoredQuantity)
```

```csharp
public static float GetTradeValue(TIFactionState faction, FactionResource resource, float quantity, float hypotheticalAdditionalStoredQuantity = 0f)
```

```csharp
public static float GetTradeEfficiency(FactionResource resource, float quantity, TIFactionState giver, TIFactionState recipient)
```

```csharp
public static float GetTradeValue(TIOrgState org, TIFactionState faction)
```

```csharp
public static float GetTradeEfficiency(TIOrgState org, TIFactionState giver, TIFactionState recipient)
```

```csharp
public static float GetTradeValue(TIProjectTemplate project, TIFactionState faction)
```

```csharp
public static float GetTradeEfficiency(TIProjectTemplate project, TIFactionState giver, TIFactionState recipient)
```

```csharp
private static bool IsValidTradeItem(TIHabState hab, TIFactionState givingFaction, TIFactionState receivingFaction)
```

```csharp
public static float GetTradeValue(TIHabState hab, TIFactionState faction)
```

```csharp
public static float GetMissionControlChangeTradeValue(TIFactionState faction, int netMC)
```

```csharp
public static float GetTradeEfficiency(TIHabState hab, TIFactionState giver, TIFactionState recipient)
```

```csharp
public static float GetTradeValue(TradeOffer.TreatyType treatyType, TIFactionState faction, TIFactionState otherFaction)
```

```csharp
public static float GetAgreementFavorability(TradeOffer.TradeAgreement agreement, TIFactionState assessingFaction, TIFactionState otherFaction)
```

```csharp
public static float GetMinimumAgreementFavorability(TIFactionState faction, TIFactionState otherFaction)
```

```csharp
public static bool IsAgreementAcceptable(TradeOffer.TradeAgreement agreement, TIFactionState assessingFaction, TIFactionState otherFaction, out float favorability)
```

```csharp
public static bool IsAgreementAcceptable(TradeOffer.TradeAgreement agreement, TIFactionState assessingFaction, TIFactionState otherFaction)
```

```csharp
public static TradeOffer GetCounterOffer(TradeOffer demands, TIFactionState demandMaker, TIFactionState demandCounterer)
```

```csharp
private static bool TryToBalanceCategory<T>(TradeAI.CategoryType category, TradeOffer fixedOffer, TradeOffer dynamicOffer, IEnumerable<T> candidates, [TupleElementNames(new string[]
```

```csharp
public static float GetMaximumTradeQuantity(TIFactionState faction, FactionResource resource)
```

```csharp
private static float GetDistrust(TIFactionState judge, TIFactionState otherFaction)
```

```csharp
private static float GetCategoryScore(TradeOffer.TradeAgreement agreement, TradeAI.CategoryType category, TIFactionState agreementScorer, TIFactionState otherFaction, TradeAI.CategoryScoreType categoryScoreType = TradeAI.CategoryScoreType.Net)
```

```csharp
private static float GetCategoryScore(TradeOffer offer, TradeAI.CategoryType category, TIFactionState offerScorer, TIFactionState otherFaction)
```

```csharp
public static float ScoreAgreement(TradeOffer.TradeAgreement agreement, TIFactionState scorer)
```
