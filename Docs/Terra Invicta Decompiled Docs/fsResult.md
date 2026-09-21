# fsResult

*Decompiled from `FullSerializer/fsResult.cs`.*


## Struct `fsResult`

```csharp
public struct fsResult
```

### Fields

| Name | Type |
|---|---|
| `Failed` | public bool |
| `Succeeded` | public bool |
| `HasWarnings` | public bool |
| `AsException` | public Exception |
| `RawMessages` | public IEnumerable<string> |
| `FormattedMessages` | public string |
| `EmptyStringArray` | private static readonly string[] |
| `_success` | private bool |
| `_messages` | private List<string> |
| `Success` | public static fsResult |

### Methods

```csharp
public void AddMessage(string message)
```

```csharp
public void AddMessages(fsResult result)
```

```csharp
public fsResult Merge(fsResult other)
```

```csharp
public static fsResult Warn(string warning)
```

```csharp
public static fsResult Fail(string warning)
```

```csharp
public fsResult AssertSuccess()
```

```csharp
public fsResult AssertSuccessWithoutWarnings()
```
