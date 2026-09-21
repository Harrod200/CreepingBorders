# TIDouble3

*Decompiled from `PavonisInteractive/TerraInvicta/Components/TIDouble3.cs`.*


## Struct `TIDouble3`

```csharp
public struct TIDouble3 : IEquatable<TIDouble3>
```

### Fields

| Name | Type |
|---|---|
| `xzy` | public TIDouble3 |
| `Magnitude` | public double |
| `Direction` | public TIDouble3 |
| `operator` | public static bool |
| `x` | public double |
| `y` | public double |
| `z` | public double |

### Methods

```csharp
public TIDouble3(double x, double y, double z)
```

```csharp
public override int GetHashCode()
```

```csharp
public override bool Equals(object obj)
```

```csharp
public override string ToString()
```

```csharp
public string ToString(string format, IFormatProvider formatProvider)
```

```csharp
public bool Equals(TIDouble3 other)
```

```csharp
public static implicit operator Vector3d(TIDouble3 d)
```

```csharp
public static implicit operator TIDouble3(Vector3d d)
```

```csharp
public static implicit operator TIDouble3(Vector3 d)
```

```csharp
public static implicit operator TIDouble3(float3 d)
```

```csharp
public static explicit operator Vector3(TIDouble3 d)
```

```csharp
public static explicit operator float3(TIDouble3 d)
```
