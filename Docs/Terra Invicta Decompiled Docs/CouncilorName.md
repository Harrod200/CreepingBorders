# CouncilorName

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilorName.cs`.*


## Struct `CouncilorName`

```csharp
public struct CouncilorName : INamelistKey<CouncilorName>, INamelistKey, IEquatable<CouncilorName>
```

### Fields

| Name | Type |
|---|---|
| `group` | public string |
| `gender` | public string |
| `segment` | public string |

### Methods

```csharp
public CouncilorName(string group, string segment, string gender)
```

```csharp
public bool Equals(CouncilorName key)
```

```csharp
public CouncilorName Any()
```
