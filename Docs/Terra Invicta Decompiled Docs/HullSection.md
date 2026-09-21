# HullSection

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/HullSection.cs`.*


## Class `HullSection`

```csharp
public class HullSection : IHullSection, IComponent
```

### Fields

| Name | Type |
|---|---|
| `facings` | public IList<Facing> |
| `shipState` | public TISpaceShipState |

### Properties

- `public ComponentMap map`

### Methods

```csharp
public HullSection(TISpaceShipState state, Facing facing)
```

```csharp
public HullSection(TISpaceShipState state)
```

```csharp
public void AddFacing(Facing facing)
```

```csharp
public bool Contains(float angle)
```

```csharp
public Damage ApplyDamage(Damage damage, float angle, out float internalDamageApplied)
```
