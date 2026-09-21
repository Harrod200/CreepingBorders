# NamelistManager

*Decompiled from `PavonisInteractive/TerraInvicta/NamelistManager.cs`.*


## Class `NamelistManager`

```csharp
public class NamelistManager
```

### Fields

| Name | Type |
|---|---|
| `namelists` | private Dictionary<Type, INamelist> |

### Methods

```csharp
public NamelistManager()
```

```csharp
public void LoadNamelists(bool startup)
```

```csharp
private void OnLanguageChangedEvent()
```

```csharp
public bool TryGetName<TKey>(TKey key, out string name) where TKey : INamelistKey<TKey>
```

```csharp
public string GetName<TKey>(TKey key) where TKey : INamelistKey<TKey>
```

```csharp
private void Load<TKey>(INamelistParser<TKey> parser) where TKey : INamelistKey<TKey>
```

```csharp
private void StageModNameLists()
```
