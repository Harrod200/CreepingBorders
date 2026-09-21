# FoundHabOperation

*Decompiled from `FoundHabOperation.cs`.*


## Class `FoundHabOperation`

```csharp
public abstract class FoundHabOperation : TISpaceBodyOperationTemplate
```

### Fields

| Name | Type |
|---|---|
| `deliveryDuration_days` | protected float |

### Methods

```csharp
public override OperationTiming GetOperationTiming()
```

```csharp
public abstract int GetTier()
```

```csharp
public abstract Context GetRequiredConstructionTechEffectContext()
```

```csharp
public abstract string CoreModuleDataName(bool alien)
```

```csharp
public override float GetDuration_days(TIGameState actorState, TIGameState target, Trajectory trajectory = null)
```

```csharp
public TIHabModuleTemplate CoreModule(bool alien)
```

```csharp
public void FoundHab(TIFactionState faction, TIGameState location, int tier)
```

```csharp
public override bool ActorCanPerformOperation(TIGameState actorState, TIGameState target)
```

```csharp
public override string GetDescription(TIGameState actorState = null, TIGameState target = null)
```

```csharp
public override bool HasResourceCost()
```

```csharp
public override List<TIResourcesCost> ResourceCostOptions(TIFactionState faction, TIGameState target, TIGameState actor, bool checkCanAfford = true)
```

```csharp
public static TIResourcesCost GetCostFromSpace(TIGameState location, TIFactionState faction, bool substituteBoost = true)
```

```csharp
public static TIResourcesCost GetCostFromEarth(TIGameState location, TIFactionState faction, bool substituteBoost = true)
```
