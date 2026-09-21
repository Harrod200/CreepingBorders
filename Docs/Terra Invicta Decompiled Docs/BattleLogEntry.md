# BattleLogEntry

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/UI/BattleLogEntry.cs`.*


## Class `BattleLogEntry`

```csharp
public class BattleLogEntry : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `timeStampText` | public TMP_Text |
| `battleLogText` | public TMP_Text |
| `battleLogTypeImage` | public Image |
| `kiaIcon` | public Image |
| `logType` | private BattleLogController.BattleLogType |
| `BattleLogEntry_Data` | public class |
| `timeStampSeconds` | public int |
| `timeStampText` | public string |
| `battleLogText` | public string |
| `imageTypeName` | public string |
| `enableKIAIcon` | public bool |
| `logType` | public BattleLogController.BattleLogType |
| `showInList` | public bool |

### Methods

```csharp
public void Init(BattleLogEntry.BattleLogEntry_Data data)
```

```csharp
public BattleLogController.BattleLogType GetLogType()
```
