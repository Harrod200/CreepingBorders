# TIPromptQueueState

*Decompiled from `PavonisInteractive/TerraInvicta/TIPromptQueueState.cs`.*


## Class `TIPromptQueueState`

```csharp
public class TIPromptQueueState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `anyBlocking` | public bool |
| `anyBlockingPrompt` | public static bool |
| `anyActivePlayerBlocking` | public bool |
| `anyActivePlayerBlockingPrompt` | public static bool |
| `nationList` | private List<Prompt> |
| `factionList` | private List<Prompt> |
| `projectSelectionStrategy` | private IProjectSelectionStrategy |
| `techSelectionStrategy` | private ITechSelectionStrategy |
| `policyResponseSelectionStrategy` | private IPolicyResponseSelectionStrategy |
| `combatInitStrategy` | private ICombatInitStrategy |
| `narrativeResponseStrategy` | private INarrativeResponseSelectionStrategy |
| `gameStateSubjectCreated` | private bool |
| `gameTime` | private GameTimeManager |
| `globalValues` | private TIGlobalValuesState |
| `councilorMissionPlanner` | private AICouncilorMissionPlanner |

### Properties

- `public List<Prompt> activePlayerNationPromptList`
- `public List<Prompt> activePlayerFactionPromptList`

### Methods

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostCanvasManagerCreateInit_3()
```

```csharp
public override void PostAllStartUpInit_5()
```

```csharp
public static string GetBlockingDetailStr()
```

```csharp
public void AddPrompt(Prompt newPrompt)
```

```csharp
public void AddPrompt(TIGameState actingState, TIGameState promptingGameState, TIGameState relatedGameState, string name, int value = 0)
```

```csharp
public static void AddPromptStatic(Prompt prompt)
```

```csharp
public static void AddPromptStatic(TIGameState actingState, TIGameState promptingGameState, TIGameState relatedGameState, string name, int value = 0)
```

```csharp
public bool RemovePrompt(Prompt prompt)
```

```csharp
public void RemovePrompt(TIGameState actingState, TIGameState promptingGameState, TIGameState relatedGameState, string name, int value = 0)
```

```csharp
public static void RemovePromptStatic(Prompt prompt)
```

```csharp
public static void RemovePromptStatic(TIGameState actingState, TIGameState promptingGameState, TIGameState relatedGameState, string name, int value = 0)
```

```csharp
public bool HasPrompt(Prompt promptToCheck)
```

```csharp
public bool HasPrompt(TIGameState actingState, TIGameState promptingGameState, TIGameState relatedGameState, string name, int value = 0)
```

```csharp
public static bool HasPromptStatic(Prompt promptToCheck)
```

```csharp
public static bool HasPromptStatic(TIGameState actingState, TIGameState promptingGameState, TIGameState relatedGameState, string name, int value = 0)
```

```csharp
public bool HasAnyPromptofType(string name, bool factionOnly = false, bool nationOnly = false)
```

```csharp
public void HandlePrompts()
```

```csharp
public static bool PlayerMissionPrompt(Prompt prompt)
```

```csharp
public static bool PlayerOperationPrompt(Prompt prompt)
```

```csharp
public static bool ActivePlayerHasSaveBlockingPrompt()
```

```csharp
private void HandleSelectPolicy(TINationState nation, TIFactionState faction, TICouncilorState triggeringCouncilor)
```

```csharp
private void HandleSelectTech(TIFactionState faction, int slot)
```

```csharp
private void HandleSelectProject(TIFactionState faction, int slot)
```

```csharp
private void HandleMissionPhasePrep(TIFactionState faction, Prompt prompt)
```

```csharp
private void HandlePlanMissions(TIFactionState faction, Prompt prompt)
```

```csharp
private void HandleSelectSpaceCombatStance(TIFactionState faction, TISpaceCombatState combatState)
```

```csharp
private void HandleSelectSpaceCombatBid(TIFactionState faction, TISpaceCombatState combatState)
```

```csharp
private void HandleRespondToNarrativeEvent(Prompt prompt, TIFactionState faction, TIGameState eventTarget, TIGameState secondaryTarget)
```

```csharp
private void HandleStealProject(TIFactionState promptedFaction, TICouncilorState councilor, TIGameState target, TIMissionState mission)
```

```csharp
private void HandleSabotageProject(TIFactionState promptedFaction, TICouncilorState councilor, TIGameState target, TIMissionState mission)
```

```csharp
private void HandleFactionContactMakeOffer(TIFactionState contactingFaction, TIFactionState contactedFaction, TIMissionState mission)
```

```csharp
private void HandleFactionContactRespondToOffer(TIFactionState contactingFaction, TIFactionState contactedFaction, TIMissionState mission)
```

```csharp
private void HandleDropUnassignedOrgs(TIFactionState faction)
```

```csharp
private void HandlePromptChangeTrajectory(TIFactionState faction, TISpaceFleetState maneuveringFleet, TISpaceFleetState targetFleet, Trajectory[] validTrajectories = null)
```

```csharp
private IPlayerActionRunner GetNationRunner(TINationState respondingNation)
```

```csharp
private void HandleProposedAlliance(TINationState respondingNation, TINationState promptingNation)
```

```csharp
private void HandleEndWar(TINationState respondingNation, TINationState promptingNation, TIWarState war)
```

```csharp
private void HandleEndRivalry(TINationState respondingNation, TINationState promptingNation)
```

```csharp
private void HandleFederation(TINationState respondingNation, TINationState promptingNation)
```

```csharp
private void HandleUnification(TINationState respondingNation, TINationState promptingNation)
```

```csharp
private void HandleRegionDemanded(TINationState respondingNation, TINationState promptingNation, TIRegionState region)
```

```csharp
private void HandleCallToOffensiveWar(TINationState respondingNation, TINationState promptingNation, TIWarState war)
```

```csharp
private void HandleNationLeavesMyDarkFederation_Violent(TINationState fedLeader, TINationState departingNation, Prompt nationPrompt)
```

```csharp
private void HandleNationLeavesMyDarkFederation_Policy(TINationState fedLeader, TINationState departingNation, Prompt nationPrompt)
```

```csharp
private void HandleRespondToNarrativeEvent(Prompt prompt, TINationState nation, TIGameState eventTarget, TIGameState secondaryTarget)
```

```csharp
private void HandleResponseToArmyBooted(Prompt prompt)
```

```csharp
public string DumpActivePlayerPrompts()
```
