# Terminal

*Decompiled from `PavonisInteractive/TerraInvicta/Debugging/Terminal.cs`.*


## Class `Terminal`

```csharp
public class Terminal : IInitializable, IDisposable
```

### Fields

| Name | Type |
|---|---|
| `view` | private GameObject |
| `inputField` | private TMP_InputField |
| `enterButton` | private Button |
| `historyLog` | private TextMeshProUGUI |
| `controller` | public TerminalController |
| `stringBuilder` | private StringBuilder |
| `gameTime` | private GameTimeManager |
| `historySplit` | private string[] |
| `historyLineIndex` | private int |

### Methods

```csharp
public Terminal(GameObject view, TerminalController controller)
```

```csharp
public void Initialize()
```

```csharp
private void CacheComponents()
```

```csharp
private void AddDelegates()
```

```csharp
private void OnEnterClick()
```

```csharp
private void SubmitInput(string txt)
```

```csharp
private void AddToHistory(string txt)
```

```csharp
private void AddErrorToHistory(string txt)
```

```csharp
private void ClearInput()
```

```csharp
public void Show()
```

```csharp
private void SetFocus()
```

```csharp
public void Hide()
```

```csharp
public void PreviousCommand()
```

```csharp
public void NextCommand()
```

```csharp
private void PullCommandFromHistory(int dir = 1)
```

```csharp
public void Dispose()
```

```csharp
private void RemoveDelegates()
```
