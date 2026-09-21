# ErrorEventArgs

*Decompiled from `LapinerTools/Steam/Data/ErrorEventArgs.cs`.*


## Class `ErrorEventArgs`

```csharp
public class ErrorEventArgs : EventArgsBase
```

### Fields

| Name | Type |
|---|---|
| `ERROR_MSG_STEAM_NOT_INIT` | public const string |
| `ERROR_MSG_WORKSHOP_LEGAL_AGREEMENT` | public const string |

### Methods

```csharp
public static string ERROR_MSG(EResult p_result)
```

```csharp
public static ErrorEventArgs CreateSteamNotInit()
```

```csharp
public static ErrorEventArgs CreateWorkshopLegalAgreement()
```

```csharp
public static ErrorEventArgs Create(EResult p_result)
```

```csharp
public ErrorEventArgs()
```

```csharp
public ErrorEventArgs(string p_errorMessage)
```
