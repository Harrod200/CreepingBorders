# ResourceCostBuilder

*Decompiled from `PavonisInteractive/TerraInvicta/ResourceCostBuilder.cs`.*


## Struct `ResourceCostBuilder`

```csharp
public struct ResourceCostBuilder
```

### Fields

| Name | Type |
|---|---|
| `money` | public float |
| `influence` | public float |
| `operations` | public float |
| `research` | public float |
| `boost` | public float |
| `water` | public float |
| `volatiles` | public float |
| `metals` | public float |
| `nobleMetals` | public float |
| `fissiles` | public float |
| `antimatter` | public float |
| `exotics` | public float |

### Methods

```csharp
public float GetWeightedCost(FactionResource resource)
```

```csharp
public TIResourcesCost ToResourcesCost(float multiplier = 1f)
```

```csharp
public Dictionary<FactionResource, float> ToRVCollection(float multiplier = 1f)
```
