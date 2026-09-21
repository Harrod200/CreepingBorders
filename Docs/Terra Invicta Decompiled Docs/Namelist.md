# Namelist

*Decompiled from `PavonisInteractive/TerraInvicta/Namelist.cs`.*


## Class `Namelist`

```csharp
public class Namelist<TKey> : INamelist<TKey>, INamelist where TKey : INamelistKey<TKey>
```

### Fields

| Name | Type |
|---|---|
| `names` | private readonly Dictionary<TKey, List<NamelistEntry>> |
| `weights` | private readonly Dictionary<TKey, int> |
| `parser` | private readonly INamelistParser<TKey> |
| `filename` | private readonly string |
| `moddedNameListPaths` | private readonly List<string> |

### Methods

```csharp
public Namelist(string filename, INamelistParser<TKey> parser, List<string> moddedNameLists = null)
```

```csharp
public string GetName(TKey key)
```

```csharp
private void LoadFile()
```
