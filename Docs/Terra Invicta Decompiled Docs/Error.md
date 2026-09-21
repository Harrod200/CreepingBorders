# Error

*Decompiled from `PavonisInteractive/TerraInvicta/Error.cs`.*


## Class `Error`

```csharp
public static class Error
```

### Fields

| Name | Type |
|---|---|
| `failedMessage` | private const string |

### Properties

- `private const string typeMessage = "Check Failed: var has type`
- `private const string notTypeMessage = "Check Failed: var has type`
- `private const string nullMessage = "Check Failed:`
- `private const string notNullMessage = "Check Failed:`
- `private const string equalMessage = "Check Failed: Expected not equal [`
- `private const string notEqualMessage = "Check Failed: Expected equal [`
- `private const string emptyCollectionMessage = "Check Failed:`
- `private const string notContainsMessage = "Check Failed: collection does not contain`
- `private const string outOfRangeMessage = "Check Failed:`
- `private const string exceptionMessage = "`
- `private const string notFoundMessage = "Check Failed:`

### Methods

```csharp
public static void Log(string message, params object[] args)
```

```csharp
public static void LogException(Exception e)
```

```csharp
public static bool Is(bool condition, string message, params object[] args)
```

```csharp
public static bool Is(bool condition)
```

```csharp
public static bool IsEqual<T>(T left, T right, string message, params object[] args)
```

```csharp
public static bool IsEqual<T>(T left, T right)
```

```csharp
public static bool IsNotEqual<T>(T left, T right, string message, params object[] args)
```

```csharp
public static bool IsNotEqual<T>(T left, T right)
```

```csharp
public static bool IsNull<T>(T obj, string message, params object[] args)
```

```csharp
public static bool IsNull<T>(T obj)
```

```csharp
public static bool IsNotNull<T>(T obj, string message, params object[] args)
```

```csharp
public static bool IsNotNull<T>(T obj)
```

```csharp
public static bool IsNot<T>(object obj, string message, params object[] args)
```

```csharp
public static bool IsNot<T>(object obj)
```

```csharp
public static bool IsOutOfRange(double value, double low, double high, string message, params object[] args)
```

```csharp
public static bool IsOutOfRange(double value, double low, double high)
```

```csharp
public static bool IsNotEqualCount(ICollection left, ICollection right, string message, params object[] args)
```

```csharp
public static bool IsNotEqualCount(ICollection left, ICollection right)
```

```csharp
public static bool IsEmpty<T>(T collection, string message, params object[] args) where T : ICollection
```

```csharp
public static bool IsEmpty<T>(T collection) where T : ICollection
```

```csharp
public static bool NotContain<T>(ICollection<T> collection, T obj, string message, params object[] args)
```

```csharp
public static bool NotContain<T>(ICollection<T> collection, T obj)
```

```csharp
public static bool OnException(Action action, string message, params object[] args)
```

```csharp
public static bool OnException(Action action)
```

```csharp
public static bool IsInvalid(object obj)
```

```csharp
public static bool IsInvalid(IValidatable obj)
```

```csharp
public static bool IsInvalidGameState<T>(T state) where T : TIGameState
```

```csharp
public static bool IsDirectoryMissing(string path, string message, params object[] args)
```

```csharp
public static bool IsDirectoryMissing(string path)
```

```csharp
public static bool IsFileMissing(string path, string message, params object[] args)
```

```csharp
public static bool IsFileMissing(string path)
```
