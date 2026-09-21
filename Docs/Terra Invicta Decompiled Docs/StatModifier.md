# StatModifier

*Decompiled from `StatModifier.cs`.*


## Struct `StatModifier`

```csharp
public struct StatModifier
```

### Fields

| Name | Type |
|---|---|
| `conditionalModifier` | public bool |
| `modifierValue` | public int |
| `stat` | public CouncilorAttribute |
| `operation` | public StatModSetOperation |
| `strValue` | public string |
| `condition` | public TICondition |
| `_modifierValue` | private int |

### Methods

```csharp
public StatModifier(CouncilorAttribute stat, StatModSetOperation operation, string strValue, TICondition condition)
```

```csharp
private bool ModifierHasNumericValue()
```
