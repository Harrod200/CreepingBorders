# StratPolicyResponseSelector

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/StratPolicyResponseSelector.cs`.*


## Class `StratPolicyResponseSelector`

```csharp
public class StratPolicyResponseSelector : IPolicyResponseSelectionStrategy
```

### Methods

```csharp
public static float ChanceFederation(TINationState proposingNation, TINationState respondingNation)
```

```csharp
public static float ChanceUnification(TINationState proposingNation, TINationState respondingNation)
```

```csharp
public static float ChanceEndWar(TINationState proposingNation, TIWarState war)
```

```csharp
public static float ChanceFormAlliance(TINationState proposingNation, TINationState respondingNation)
```

```csharp
public static float ChanceEndRivalry(TINationState proposingNation, TINationState respondingNation)
```

```csharp
public static float ChanceSurrenderRegion(TINationState askingNation, TIRegionState proposedRegion)
```

```csharp
public static float ChanceAllowDarkFederationDeparture(TINationState askingNation)
```

```csharp
public bool SelectPolicyReply(TINationState proposingNation, TINationState respondingNation, TIPolicyOptionWithConfirm policy)
```

```csharp
public bool SelectPolicyReply(TINationState proposingNation, TINationState respondingNation, TIWarState war, TIPolicyOptionWithConfirm policy)
```

```csharp
public bool SelectPolicyReply(TINationState proposingNation, TINationState respondingNation, TIPolicyOptionWithConfirm policy, TIRegionState region)
```
