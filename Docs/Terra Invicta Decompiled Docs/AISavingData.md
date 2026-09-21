# AISavingData

*Decompiled from `AISavingData.cs`.*


## Class `AISavingData`

```csharp
public class AISavingData
```

### Fields

| Name | Type |
|---|---|
| `importance` | public int |
| `desiredPurchase` | public TIDataTemplate |
| `CanSaveFor` | public bool |
| `faction` | public TIFactionState |
| `desiredPurchaseDataName` | public string |
| `location` | public TIGameState |
| `relatedGoal` | public TIFactionGoalState |
| `bankingPercentage` | public float |
| `bankedResources` | public Dictionary<FactionResource, float> |
| `yesterdaysResources` | public Dictionary<FactionResource, float> |
| `active` | public bool |
| `_desiredPurchase` | private TIDataTemplate |

### Methods

```csharp
public void ClearPurchaseData()
```

```csharp
public AISavingData(TIFactionState faction, TIDataTemplate desiredPurchase, TIGameState location, TIFactionGoalState relatedGoal, float bankingPercentage)
```

```csharp
public static float GetBankingPercentage(TIFactionGoalState goal)
```

```csharp
public void DailySavingUpdate()
```

```csharp
public float GetBankedQuantity(FactionResource resource)
```

```csharp
public TIResourcesCost GetResourcesToSave()
```

```csharp
public void LogSavingData()
```
