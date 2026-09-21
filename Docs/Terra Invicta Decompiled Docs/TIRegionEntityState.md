# TIRegionEntityState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionEntityState.cs`.*


## Class `TIRegionEntityState`

```csharp
public abstract class TIRegionEntityState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `ref_region` | public override TIRegionState |
| `ref_nation` | public override TINationState |
| `hasMapObject` | public override bool |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `hasEarthMapObject` | public override bool |
| `gameStateSubjectCreated` | protected bool |

### Properties

- `public TIRegionState region`
- `public abstract string descriptor`
- `public abstract string description`

### Methods

```csharp
public abstract bool Extant()
```

```csharp
public abstract string GetIllustrationPath(TIFactionState faction)
```

```csharp
public virtual Sprite GetIcon(TIFactionState faction)
```

```csharp
public abstract string GetIconResourcePath(TIFactionState faction)
```

```csharp
public void SetRegionEntityDataDirty()
```
