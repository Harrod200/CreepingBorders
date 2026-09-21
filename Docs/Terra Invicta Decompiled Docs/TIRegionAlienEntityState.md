# TIRegionAlienEntityState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionAlienEntityState.cs`.*


## Class `TIRegionAlienEntityState`

```csharp
public abstract class TIRegionAlienEntityState : TIRegionEntityState
```

### Fields

| Name | Type |
|---|---|
| `descriptor` | public override string |
| `description` | public override string |
| `isRegionAlienEntity` | public override bool |
| `ref_faction` | public override TIFactionState |
| `ref_regionAlienEntity` | public override TIRegionAlienEntityState |

### Methods

```csharp
public virtual bool VisibleToFaction(TIFactionState faction)
```

```csharp
public override string GetDisplayName(TIFactionState faction)
```

```csharp
public override bool Initialize()
```
