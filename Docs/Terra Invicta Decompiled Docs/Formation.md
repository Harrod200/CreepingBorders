# Formation

*Decompiled from `Formation.cs`.*


## Struct `Formation`

```csharp
public struct Formation
```

### Fields

| Name | Type |
|---|---|
| `pattern` | public TIFormationTemplate |
| `displayName` | public string |
| `description` | public string |
| `patternDataName` | public string |
| `spacing` | public FormationSpacing |
| `concentration` | public FormationConcentration |
| `focus` | public FormationFocus |

### Methods

```csharp
public Formation(Formation formation)
```

```csharp
public Formation(string patternDataName, FormationFocus focus, FormationSpacing spacing, FormationConcentration concentration)
```

```csharp
public static string spacingName(FormationSpacing spacing)
```

```csharp
public static string concentrationName(FormationConcentration concentration)
```

```csharp
public static string focusName(FormationFocus focus)
```

```csharp
public static string patternName(string patternDataName)
```

```csharp
public static string concentrationDescription(FormationConcentration concentration)
```

```csharp
public static string focusDescription(FormationFocus focus)
```

```csharp
public static string patternDescription(string patternDataname)
```
