# SpaceAssetName

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceAssetName.cs`.*


## Struct `SpaceAssetName`

```csharp
public struct SpaceAssetName : INamelistKey<SpaceAssetName>, INamelistKey, IEquatable<SpaceAssetName>
```

### Fields

| Name | Type |
|---|---|
| `assetGroup` | private readonly string |
| `suggestedRegion` | private readonly string |

### Methods

```csharp
public SpaceAssetName(string assetGroup, string suggestedRegion)
```

```csharp
public bool Equals(SpaceAssetName key)
```

```csharp
public SpaceAssetName Any()
```
