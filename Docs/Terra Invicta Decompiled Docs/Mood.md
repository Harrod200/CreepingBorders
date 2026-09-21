# Mood

*Decompiled from `PavonisInteractive/TerraInvicta/Mood.cs`.*


## Class `Mood`

```csharp
public static class Mood
```

### Fields

| Name | Type |
|---|---|
| `encounterState` | private static Mood.State |
| `playerState` | private static Mood.State |
| `visualizationState` | private static Mood.State |
| `State` | public enum |
| `Event` | public enum |

### Methods

```csharp
public static void SetState(Mood.State state)
```

```csharp
public static void ClearState(Mood.State state)
```

```csharp
public static void TriggerEvent(Mood.Event event_)
```

```csharp
public static void BeginFactionEncounter(TIFactionState encounteredFaction)
```

```csharp
public static void EndFactionEncounter()
```

```csharp
public static void UpdateActivePlayerState()
```

```csharp
public static void UpdateVisualizationState(bool dontReplaceZoomState = false)
```

```csharp
public static void GoodNews()
```

```csharp
public static void BadNews()
```
