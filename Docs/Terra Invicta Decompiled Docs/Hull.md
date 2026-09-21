# Hull

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/Hull.cs`.*


## Class `Hull`

```csharp
public class Hull : IHull
```

### Fields

| Name | Type |
|---|---|
| `length` | public float |
| `width` | public float |
| `mountKeys` | private IDictionary<Type, IList<Hull.MapKey>> |
| `mountMaps` | private IDictionary<Hull.MapKey, ComponentMap> |
| `components` | private readonly IDictionary<Hull.MapKey, List<IComponent>> |
| `name` | public string |
| `type` | public Type |

### Properties

- `public IList<IHullSection> sections`
- `public TISpaceShipState shipState`

### Methods

```csharp
public Hull(IList<IHullSection> sections, CombatShipController shipController)
```

```csharp
public Hull(IList<IHullSection> sections, TISpaceShipState state)
```

```csharp
public bool AddComponentMap<T>(ComponentMap map, string name = "") where T : IComponent
```

```csharp
public bool AddComponentMap<T>(string name = "") where T : IComponent
```

```csharp
public bool Attach<T>(T component, int heightOffset, int widthOffset, string name = "", params IHullSection[] sections) where T : IComponent
```

```csharp
public bool Attach<T>(T component, string name = "", params IHullSection[] sections) where T : IComponent
```

```csharp
public IEnumerable<T> IterateByClass<T>() where T : IComponent
```

```csharp
public ArmorFacing BearingFacing(Transform shooter, Transform target, out float struckAngle)
```

```csharp
public ArmorFacing StruckFacing(DamageSource source, Vector3 position, Vector3 forward, out float struckAngle)
```

```csharp
public float ApplyDamage(DamageSource source, Transform transform)
```

```csharp
public bool IsDestroyed()
```

```csharp
public MapKey(Type type, string name)
```

```csharp
public bool Equals(Hull.MapKey key)
```

```csharp
public override int GetHashCode()
```

```csharp
public override bool Equals(object obj)
```
