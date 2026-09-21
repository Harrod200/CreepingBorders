# TIHistoricalData

*Decompiled from `TIHistoricalData.cs`.*


## Class `TIHistoricalData`

```csharp
public class TIHistoricalData : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `Singleton` | public static TIHistoricalData |
| `States` | public static IEnumerable<TIGameState> |
| `Data` | private Dictionary<TIGameState, Dictionary<string, List<KeyValuePair<TIDateTime, float>>>> |
| `singleton` | private static TIHistoricalData |
| `RecordDebugData` | public static bool |
| `cachedValueRange` | private static ValueTuple<float, float> |
| `valueRangeCachedState` | private static TIGameState |
| `valueRangeCachedAttribute` | private static string |
| `cachedValueRangeIsTight` | private static bool |
| `EstimateType` | public enum |

### Methods

```csharp
public static void ClearStaticData()
```

```csharp
public static IEnumerable<string> GetAttributes(TIGameState state)
```

```csharp
public static ValueTuple<TIDateTime, TIDateTime> GetDateRange(TIGameState state, string attribute)
```

```csharp
public static ValueTuple<float, float> GetValueRange(TIGameState state, string attribute)
```

```csharp
public static ValueTuple<float, float> GetValueRange_Tight(TIGameState state, string attribute)
```

```csharp
public static float GetHighestValue(TIGameState state, string attribute)
```

```csharp
public static TIDateTime GetLerpDate(TIGameState state, string attribute, float lerp)
```

```csharp
public static void Record(TIGameState state, string attribute, Func<float> GetValue, float resolutionInDays, bool sum, bool isDebugData)
```

```csharp
public static void Record(TIGameState state, string attribute, float value, float resolutionInDays = 0f, bool isDebugData = true)
```

```csharp
public static void Record_Sum(TIGameState state, string attribute, float value, float resolutionInDays, bool isDebugData = true)
```

```csharp
public static void Clear(TIGameState state, string attribute)
```

```csharp
public static float Sample(TIGameState state, string attribute, TIDateTime date)
```

```csharp
public static float Sample(TIGameState state, string attribute, float lerp)
```

```csharp
public static float GuessNextReading(TIGameState state, string attribute, float windowSize_days, float windowSetback_days, int sampleCount, out bool windowWasTruncated, TIHistoricalData.EstimateType estimateType = TIHistoricalData.EstimateType.Standard)
```

```csharp
public static void ExportFactionCSV(HashSet<string> allowedAttributes = null)
```

```csharp
public int Compare(KeyValuePair<TIDateTime, float> x, KeyValuePair<TIDateTime, float> y)
```
