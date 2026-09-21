# TIFactionIdeologyTemplate

*Decompiled from `TIFactionIdeologyTemplate.cs`.*


## Class `TIFactionIdeologyTemplate`

```csharp
public class TIFactionIdeologyTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `human` | public bool |
| `proAlien` | public bool |
| `antiAlien` | public bool |
| `idealistic` | public bool |
| `cynical` | public bool |
| `fanatic` | public bool |
| `ideologyStr` | public string |
| `ideologyStrGeneric` | public string |
| `ideologyStrPublicOpinion` | public string |
| `alien` | public bool |
| `undecided` | public bool |
| `sortOrder` | public int |
| `willProxy` | public int |
| `willAppease` | public int |
| `initialReactionGroup` | public int |
| `ideology` | public FactionIdeology |
| `ideologyCoordinates` | public Vector3 |

### Methods

```csharp
public static TIFactionIdeologyTemplate GetIdeologyTemplate(FactionIdeology ideology)
```

```csharp
public static TIFactionState GetFactionByIdeology(FactionIdeology ideology)
```

```csharp
public static TIFactionState GetFactionByIdeologyTemplate(TIFactionIdeologyTemplate template)
```
