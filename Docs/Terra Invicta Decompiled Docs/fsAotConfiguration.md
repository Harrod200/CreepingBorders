# fsAotConfiguration

*Decompiled from `FullSerializer/fsAotConfiguration.cs`.*


## Class `fsAotConfiguration`

```csharp
public class fsAotConfiguration : ScriptableObject
```

### Fields

| Name | Type |
|---|---|
| `aotTypes` | public List<fsAotConfiguration.Entry> |
| `outputDirectory` | public string |
| `AotState` | public enum |
| `Entry` | public struct |
| `State` | public fsAotConfiguration.AotState |
| `FullTypeName` | public string |

### Methods

```csharp
public bool TryFindEntry(Type type, out fsAotConfiguration.Entry result)
```

```csharp
public void UpdateOrAddEntry(fsAotConfiguration.Entry entry)
```

```csharp
public Entry(Type type)
```

```csharp
public Entry(Type type, fsAotConfiguration.AotState state)
```
