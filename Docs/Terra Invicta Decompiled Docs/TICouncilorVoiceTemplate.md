# TICouncilorVoiceTemplate

*Decompiled from `TICouncilorVoiceTemplate.cs`.*


## Class `TICouncilorVoiceTemplate`

```csharp
public class TICouncilorVoiceTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `eGender` | public CouncilorGender |
| `displayName` | public new string |
| `displayIdx` | public string |
| `category` | public string |
| `categoryGender` | public string |
| `enable` | public bool |
| `specific_person` | public bool |
| `language` | public string |
| `accent` | public string |
| `index` | public int |
| `gender` | public string |
| `councilorEventInstance` | private EventInstance |
| `councilorEventDescription` | private EventDescription |
| `VoiceMissionSituation` | public enum |
| `VoiceCouncilorSituation` | public enum |

### Methods

```csharp
public void PlayMissionVoice(TIMissionTemplate missionTemplate, TICouncilorVoiceTemplate.VoiceMissionSituation voiceMissionSituation, bool onEarth, bool queueVoice = true)
```

```csharp
public void PlayMissionVoice(TIMissionTemplate missionTemplate, TIMissionOutcome voiceMissionOutcome, bool onEarth)
```

```csharp
public void PlaySelectionVoice(TICouncilorState councilorState, bool onEarth)
```

```csharp
public bool ValidForCharacter(TICouncilorState councilorState, CouncilorGender gender, string language, string accent)
```
