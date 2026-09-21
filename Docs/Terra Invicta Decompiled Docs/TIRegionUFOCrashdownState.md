# TIRegionUFOCrashdownState

*Decompiled from `PavonisInteractive/TerraInvicta/TIRegionUFOCrashdownState.cs`.*


## Class `TIRegionUFOCrashdownState`

```csharp
public class TIRegionUFOCrashdownState : TIRegionAlienEntityState
```

### Fields

| Name | Type |
|---|---|
| `ref_UFOCrashdown` | public override TIRegionUFOCrashdownState |
| `isRegionUFOCrashdown` | public override bool |
| `gameTime` | private GameTimeManager |

### Properties

- `public bool crashdownPresent`
- `public TIDateTime crashdownTime`

### Methods

```csharp
public override bool Extant()
```

```csharp
public override string GetIconResourcePath(TIFactionState faction)
```

```csharp
public override string GetIllustrationPath(TIFactionState faction)
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public void InitWithRegionState(TIRegionState region)
```

```csharp
public void SetAsInitialCrashdownRegion()
```

```csharp
public void TriggerCrashdown(bool firstCrashdown)
```

```csharp
public void ExpireCrashdownForFaction(TIFactionState faction)
```

```csharp
public void ExpireUFOCrashdownForAll()
```
