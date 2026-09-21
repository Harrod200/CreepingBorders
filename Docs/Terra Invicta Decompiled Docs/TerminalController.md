# TerminalController

*Decompiled from `PavonisInteractive/TerraInvicta/Debugging/TerminalController.cs`.*


## Class `TerminalController`

```csharp
public class TerminalController
```

### Fields

| Name | Type |
|---|---|
| `OnOutputError` | public event Action<string> |
| `OnOutput` | public event Action<string> |
| `commands` | private Dictionary<string, CommandRegistration> |
| `builder` | private StringBuilder |

### Methods

```csharp
public TerminalController()
```

```csharp
public void RegisterCommand(string command, CommandHandler handler, string help)
```

```csharp
public void ParseCommand(string commandString)
```

```csharp
private void ProcessArguments(CommandRegistration cmd, string argString)
```

```csharp
private void Help(string[] args)
```

```csharp
public void OutputError(string line)
```

```csharp
public void Output(string line)
```

```csharp
public void Destroy()
```
