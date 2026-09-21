# Council

*Decompiled from `PavonisInteractive/TerraInvicta/Entities/Council.cs`.*


## Class `Council`

```csharp
public class Council
```

### Fields

| Name | Type |
|---|---|
| `councilors` | public IReadOnlyCollection<Councilor> |
| `_councilors` | private List<Councilor> |
| `councilorFactory` | private readonly Councilor.Factory |

### Properties

- `public TIFactionState state`
- `public Player player`

### Methods

```csharp
public Council(TIFactionState councilState, Councilor.Factory councilorFactory)
```

```csharp
private void ReloadCouncilors()
```
