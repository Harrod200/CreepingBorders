# fsObjectAttribute

*Decompiled from `FullSerializer/fsObjectAttribute.cs`.*


## Class `fsObjectAttribute`

```csharp
public sealed class fsObjectAttribute : Attribute
```

### Fields

| Name | Type |
|---|---|
| `PreviousModels` | public Type[] |
| `VersionString` | public string |
| `MemberSerialization` | public fsMemberSerialization |
| `Converter` | public Type |
| `Processor` | public Type |

### Methods

```csharp
public fsObjectAttribute()
```

```csharp
public fsObjectAttribute(string versionString, params Type[] previousModels)
```
