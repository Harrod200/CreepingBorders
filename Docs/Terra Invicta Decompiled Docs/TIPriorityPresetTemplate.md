# TIPriorityPresetTemplate

*Decompiled from `TIPriorityPresetTemplate.cs`.*


## Class `TIPriorityPresetTemplate`

```csharp
public class TIPriorityPresetTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `assignToFaction` | public TIFactionState |
| `TotalWeights` | public int |
| `nationalAIOption` | public bool |
| `factionName` | public string |
| `economySetting` | public int |
| `welfareSetting` | public int |
| `environmentSetting` | public int |
| `knowledgeSetting` | public int |
| `governmentSetting` | public int |
| `unitySetting` | public int |
| `oppressionSetting` | public int |
| `spaceProgramSetting` | public int |
| `spoilsSetting` | public int |
| `initSpaceProgramSetting` | public int |
| `boostSetting` | public int |
| `missionControlSetting` | public int |
| `foundMilitarySetting` | public int |
| `militarySetting` | public int |
| `armySetting` | public int |
| `navySetting` | public int |
| `initNuclearWeaponsSetting` | public int |
| `nuclearProgramSetting` | public int |
| `spaceDefenseSetting` | public int |
| `stoSetting` | public int |
| `customDesign` | public bool |
| `deleted` | public bool |
| `_settings` | private Dictionary<PriorityType, int> |

### Methods

```csharp
public Dictionary<PriorityType, int> GetAllSettings()
```

```csharp
public TIPriorityPresetTemplate(string dataNameToSet)
```

```csharp
public void SetDisplayName(string displayName)
```

```csharp
public static void ResetPreset(TIPriorityPresetTemplate template)
```

```csharp
public static void DuplicatePreset(TIPriorityPresetTemplate templateToCopy, ref TIPriorityPresetTemplate duplicateTemplate)
```

```csharp
public void SetPreset(PriorityType priority, int value)
```

```csharp
public void SetAllPresets()
```

```csharp
public int GetPreset(PriorityType priority)
```

```csharp
public bool ValidPreset_Global()
```

```csharp
protected bool ValidPresetForNation(TINationState nation)
```

```csharp
public bool ValidPresetForFaction(TIFactionState faction)
```

```csharp
public bool ValidPreset(TINationState nation, TIFactionState faction = null)
```

```csharp
public bool CheckArgumentsForOnlyThreeValues(int testValue, int ignoreValue1, int ignoreValue2, params object[] args)
```

```csharp
public bool MatchesPreset(Dictionary<PriorityType, int> presetData, List<PriorityType> skipPriorities)
```
