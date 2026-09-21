# TradeOffer

*Decompiled from `TradeOffer.cs`.*


## Class `TradeOffer`

```csharp
public class TradeOffer
```

### Fields

| Name | Type |
|---|---|
| `ResourcesOffered` | public IEnumerable<FactionResource> |
| `offeringFaction` | public TIFactionState |
| `resourceValues` | public List<ResourceValue> |
| `projects` | public List<TIProjectTemplate> |
| `habSectors` | public List<TISectorState> |
| `habs` | public List<TIHabState> |
| `controlPoints` | public List<TIControlPoint> |
| `orgs` | public List<TIOrgState> |
| `intelData` | public List<TIGameState> |
| `treatyType` | public TradeOffer.TreatyType |
| `intelExchange` | public bool |
| `TreatyType` | public enum |
| `TradeAgreement` | public struct |
| `Factions` | public IEnumerable<TIFactionState> |
| `ResourcesTraded` | public IEnumerable<FactionResource> |
| `OfferA` | public TradeOffer |
| `OfferB` | public TradeOffer |

### Methods

```csharp
public TradeOffer(TIFactionState offeringFaction)
```

```csharp
public TradeOffer()
```

```csharp
public void ModifyOffer(ResourceValue newValue)
```

```csharp
public void ModifyOffer(TIProjectTemplate projectTemplate)
```

```csharp
public void ModifyOffer(TISectorState habSector)
```

```csharp
public void ModifyOffer(TIOrgState org)
```

```csharp
public void ModifyOffer(TIControlPoint controlPoint)
```

```csharp
public void ToggleAlienIntelOffer()
```

```csharp
public void ToggleHumanCouncilorsIntelOffer()
```

```csharp
public void ToggleProspectorData()
```

```csharp
public float GetResourceQuantityOffered(FactionResource resource)
```

```csharp
public TradeOffer MergeWith(TradeOffer otherOffer)
```

```csharp
public void BecomeCopyOf(TradeOffer offer)
```

```csharp
public TradeOffer Copy()
```

```csharp
public void Blank()
```

```csharp
public TradeOffer GetOffer(TIFactionState faction)
```

```csharp
public TradeOffer GetOtherPartysOffer(TIFactionState faction)
```

```csharp
public float GetResourceQuantityReceived(TIFactionState faction, FactionResource resource)
```

```csharp
public static implicit operator TradeOffer.TradeAgreement([TupleElementNames(new string[]
```
