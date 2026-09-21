# ComponentMap

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/ComponentMap.cs`.*


## Class `ComponentMap`

```csharp
public class ComponentMap : IEquatable<ComponentMap>, ICloneable
```

### Fields

| Name | Type |
|---|---|
| `single` | public static ComponentMap |
| `map` | private ulong |
| `height` | private int |
| `width` | private int |
| `size` | private int |

### Methods

```csharp
private static ulong ToUInt64(string map)
```

```csharp
public ComponentMap(int height, int width, ulong map)
```

```csharp
public ComponentMap(int height, int width, string map)
```

```csharp
public ComponentMap(ComponentMap other)
```

```csharp
public bool CanAttach(ComponentMap item)
```

```csharp
public bool CanAttach(ComponentMap item, int heightOffset, int widthOffset)
```

```csharp
public bool Attach(ComponentMap item, int heightOffset, int widthOffset)
```

```csharp
public bool Detach(ComponentMap item, int heightOffset, int widthOffset)
```

```csharp
public override string ToString()
```

```csharp
public object Clone()
```

```csharp
public bool Equals(ComponentMap other)
```

```csharp
private ulong BuildMask(int width, int heightOffset, int widthOffset)
```

```csharp
private bool FindMatch(ComponentMap item)
```

```csharp
private bool CheckDetach(ComponentMap item, int heightOffset, int widthOffset)
```

```csharp
private bool CheckAttach(ComponentMap item, int heightOffset, int widthOffset)
```

```csharp
private ulong Row(int i)
```
