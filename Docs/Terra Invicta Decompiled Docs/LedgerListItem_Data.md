# LedgerListItem_Data

*Decompiled from `PavonisInteractive/TerraInvicta/LedgerListItem_Data.cs`.*


## Class `LedgerListItem_Data`

```csharp
public class LedgerListItem_Data
```

### Fields

| Name | Type |
|---|---|
| `associatedState` | public TIGameState |
| `associatedTemplate` | public TIDataTemplate |
| `parentGameState` | public TIGameState |
| `entryIconSprite` | public Sprite |
| `entryName` | public string |
| `which` | public int |
| `sortOverride` | public int |
| `collapsible` | public bool |
| `collapsed` | public bool |
| `ledgerValueText` | public string[] |
| `ledgerValues` | public Dictionary<LedgerEntryCategory, float> |

### Methods

```csharp
public void SetCommonData(LedgerListItem_Data data, bool collapsible = false, TIGameState associatedState = null, TIDataTemplate associatedTemplate = null, TIGameState parentGameState = null, int which = 0)
```

```csharp
private void SetLedgerEntryData(LedgerEntryCategory category, float value, bool inactive = false, bool cost = false, bool percent = false)
```

```csharp
private void SetEmptyLedgerValue(LedgerEntryCategory category)
```

```csharp
public void SetItemData(TIFactionState faction, int which)
```

```csharp
public void SetItemData(TIHabModuleState habModule)
```

```csharp
public void SetItemData(TISpaceFleetState fleet)
```

```csharp
public void SetItemData(TIHabState hab)
```

```csharp
public void SetItemData(TISpaceShipState ship)
```

```csharp
public void SetItemData(TICouncilorState councilor)
```

```csharp
public void SetItemData(TINationState nation, TIFactionState faction)
```

```csharp
public void SetItemData(TIOrgState org)
```

```csharp
public void SetItemData(TITraitTemplate trait, TICouncilorState councilor)
```
