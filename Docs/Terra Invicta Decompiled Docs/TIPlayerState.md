# TIPlayerState

*Decompiled from `PavonisInteractive/TerraInvicta/TIPlayerState.cs`.*


## Class `TIPlayerState`

```csharp
public class TIPlayerState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `template` | public TIPlayerTemplate |
| `faction` | public TIFactionState |
| `name` | public string |
| `bugReportMessage` | public string |

### Properties

- `public bool isAI`

### Methods

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public void AssignAIStatus(bool isAI)
```
