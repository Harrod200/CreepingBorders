# TIOrgIconTemplate

*Decompiled from `TIOrgIconTemplate.cs`.*


## Class `TIOrgIconTemplate`

```csharp
public class TIOrgIconTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `path` | public string |
| `firstLetters` | public string |
| `primaryOrgType` | public OrgType |
| `allowedOrgTypes` | public List<OrgType> |
| `minTier` | public int |
| `maxTier` | public int |

### Methods

```csharp
public override bool IsValid(out string error)
```

```csharp
public bool ValidIconForOrg(string orgName, OrgType orgType, int tier)
```
