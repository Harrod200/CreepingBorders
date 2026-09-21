# Log

*Decompiled from `PavonisInteractive/TerraInvicta/Log.cs`.*


## Class `Log`

```csharp
public static class Log
```

### Fields

| Name | Type |
|---|---|
| `initialized` | private static bool |
| `clockLog` | public static string |
| `ILoggerWrapper` | private class NullLogger : ILog, |
| `IsDebugEnabled` | public bool |
| `IsInfoEnabled` | public bool |
| `IsWarnEnabled` | public bool |
| `IsErrorEnabled` | public bool |
| `IsFatalEnabled` | public bool |
| `Logger` | public global::log4net.Core.ILogger |

### Properties

- `public static ILog logger`

### Methods

```csharp
internal static void Initialize()
```

```csharp
public static void Fatal(string message, params object[] args)
```

```csharp
public static void Error(string message, params object[] args)
```

```csharp
public static void Warn(string message, params object[] args)
```

```csharp
public static void Info(string message, params object[] args)
```

```csharp
public static void Debug(string message, params object[] args)
```

```csharp
public static void Time(string name, Action action, bool verboseLog = true, bool finalLog = true)
```

```csharp
private static void Time(string name, float time, bool verboseLog, bool finalLog)
```

```csharp
public void Debug(object message)
```

```csharp
public void Debug(object message, Exception exception)
```

```csharp
public void DebugFormat(string format, params object[] args)
```

```csharp
public void DebugFormat(string format, object arg0)
```

```csharp
public void DebugFormat(string format, object arg0, object arg1)
```

```csharp
public void DebugFormat(string format, object arg0, object arg1, object arg2)
```

```csharp
public void DebugFormat(IFormatProvider provider, string format, params object[] args)
```

```csharp
public void Error(object message)
```

```csharp
public void Error(object message, Exception exception)
```

```csharp
public void ErrorFormat(string format, params object[] args)
```

```csharp
public void ErrorFormat(string format, object arg0)
```

```csharp
public void ErrorFormat(string format, object arg0, object arg1)
```

```csharp
public void ErrorFormat(string format, object arg0, object arg1, object arg2)
```

```csharp
public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
```

```csharp
public void Fatal(object message)
```

```csharp
public void Fatal(object message, Exception exception)
```

```csharp
public void FatalFormat(string format, params object[] args)
```

```csharp
public void FatalFormat(string format, object arg0)
```

```csharp
public void FatalFormat(string format, object arg0, object arg1)
```

```csharp
public void FatalFormat(string format, object arg0, object arg1, object arg2)
```

```csharp
public void FatalFormat(IFormatProvider provider, string format, params object[] args)
```

```csharp
public void Info(object message)
```

```csharp
public void Info(object message, Exception exception)
```

```csharp
public void InfoFormat(string format, params object[] args)
```

```csharp
public void InfoFormat(string format, object arg0)
```

```csharp
public void InfoFormat(string format, object arg0, object arg1)
```

```csharp
public void InfoFormat(string format, object arg0, object arg1, object arg2)
```

```csharp
public void InfoFormat(IFormatProvider provider, string format, params object[] args)
```

```csharp
public void Warn(object message)
```

```csharp
public void Warn(object message, Exception exception)
```

```csharp
public void WarnFormat(string format, params object[] args)
```

```csharp
public void WarnFormat(string format, object arg0)
```

```csharp
public void WarnFormat(string format, object arg0, object arg1)
```

```csharp
public void WarnFormat(string format, object arg0, object arg1, object arg2)
```

```csharp
public void WarnFormat(IFormatProvider provider, string format, params object[] args)
```
