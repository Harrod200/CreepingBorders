# TIFederationState

*Decompiled from `PavonisInteractive/TerraInvicta/TIFederationState.cs`.*


## Class `TIFederationState`

```csharp
public class TIFederationState : TIPolityState
```

### Fields

| Name | Type |
|---|---|
| `memberAllies` | public List<TINationState> |
| `memberEnemies` | public List<TINationState> |
| `leadNation` | public TINationState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_nation` | public override TINationState |
| `ref_factions` | public override List<TIFactionState> |
| `hegemonicFederation` | public bool |
| `federationName` | public string |
| `flagResource` | public string |
| `displayNameWithArticle` | public string |
| `displayNameWithArticleCapitalized` | public string |
| `adjective` | public string |
| `lastAttemptToLeaveDarkFederation` | public Dictionary<TINationState, TIDateTime> |
| `federationPooledResources` | public static readonly FactionResource[] |

### Properties

- `public List<TINationState> members`
- `public bool spaceProgram`

### Methods

```csharp
public List<TIRegionState> MemberClaims(bool includeHostile)
```

```csharp
public double GDP(TINationState except = null)
```

```csharp
public override bool Initialize()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public override void PostAllStartUpInit_5()
```

```csharp
public void SortMembers()
```

```csharp
public void SetSpaceProgramValue()
```

```csharp
public void FoundFederation(TIFactionState actingFaction, List<TINationState> foundingMembers)
```

```csharp
public bool CanAddNation(TINationState prospectiveNation)
```

```csharp
public void AddNation(TIFactionState actingFaction, TINationState nation, bool startup = false)
```

```csharp
public void RemoveNation(TIFactionState actingFaction, TINationState nation, bool offerWar)
```

```csharp
public void AllyWithFederation(TIFactionState actingFaction, TINationState nation)
```

```csharp
private void SetDisplayData()
```

```csharp
public void RecordAttemptToLeaveDarkFederation(TINationState leavingNation)
```

```csharp
public bool AttemptedToLeaveDarkFederationSince(TINationState nation, float inTheLastXYears)
```

```csharp
public float MemberPooledResource_Year(TINationState nation, FactionResource resource)
```

```csharp
public bool NetTaker(TINationState member, FactionResource resource)
```

```csharp
public float ECOBonus(TINationState member)
```
