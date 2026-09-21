# ModuleDataEntry

*Decompiled from `ModuleDataEntry.cs`.*


## Class `ModuleDataEntry`

```csharp
public class ModuleDataEntry
```

### Fields

| Name | Type |
|---|---|
| `moduleTemplate` | public TIShipPartTemplate |
| `weaponTemplate` | public TIShipWeaponTemplate |
| `cachedModuleTemplate` | private TIShipPartTemplate |

### Properties

- `public string moduleTemplateName`
- `public int slotIndex`

### Methods

```csharp
public ModuleDataEntry(TIShipPartTemplate moduleTemplate, int slotIndex)
```

```csharp
public ModuleDataEntry()
```

```csharp
public void CorrectBrokenSlot(int correctIndex)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public override int GetHashCode()
```
