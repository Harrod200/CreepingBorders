# SelectNarrativeEventOption

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SelectNarrativeEventOption.cs`.*


## Class `SelectNarrativeEventOption`

```csharp
public class SelectNarrativeEventOption : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `factionID` | private GameStateID |
| `eventTargetID` | private GameStateID |
| `secondaryTargetID` | private GameStateID |
| `optionSelected` | private int |
| `eventTemplate` | private TINarrativeEventTemplate |
| `allTargetIDs` | private Dictionary<GameStateID, GameStateID> |
| `prompt` | private Prompt |

### Methods

```csharp
public SelectNarrativeEventOption(TIFactionState faction, TIGameState eventTarget, TIGameState secondaryTarget, TINarrativeEventTemplate eventTemplate, int optionSelected, Dictionary<TIGameState, TIGameState> allTargets, Prompt prompt)
```

```csharp
public override void Execute()
```
