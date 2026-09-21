# OrgName

*Decompiled from `PavonisInteractive/TerraInvicta/OrgName.cs`.*


## Struct `OrgName`

```csharp
public struct OrgName : INamelistKey<OrgName>, INamelistKey, IEquatable<OrgName>
```

### Fields

| Name | Type |
|---|---|
| `orgType` | private readonly OrgType |
| `segment` | private readonly string |

### Methods

```csharp
public OrgName(OrgType orgType, string segment)
```

```csharp
public bool Equals(OrgName key)
```

```csharp
public OrgName Any()
```
