# HabPreferences

*Decompiled from `PavonisInteractive/TerraInvicta/HabPreferences.cs`.*


## Class `HabPreferences`

```csharp
public class HabPreferences : Dictionary<HabMetric, float>
```

### Fields

| Name | Type |
|---|---|
| `Weight` | public float |

### Methods

```csharp
public HabPreferences()
```

```csharp
public HabPreferences Normalized()
```

```csharp
public void Scale(float scalar)
```

```csharp
public HabPreferences Scaled(float scalar)
```

```csharp
public HabPreferences Multiplied(HabPreferences other)
```

```csharp
public HabPreferences Copy()
```
