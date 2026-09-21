# GameTimeCondition

*Decompiled from `PavonisInteractive/TerraInvicta/GamePlayScript/Systems/GameTimeCondition.cs`.*


## Class `GameTimeCondition`

```csharp
public class GameTimeCondition
```

### Fields

| Name | Type |
|---|---|
| `condition` | private GameTimeCondition.Condition |
| `nextUpdate` | private DateTime |
| `MIDMONTHDAY` | public const int |
| `Condition` | private enum |

### Methods

```csharp
public static GameTimeCondition Daily0000(DateTime now)
```

```csharp
public static GameTimeCondition Daily0300(DateTime now)
```

```csharp
public static GameTimeCondition Daily0600(DateTime now)
```

```csharp
public static GameTimeCondition Daily0900(DateTime now)
```

```csharp
public static GameTimeCondition Daily1030(DateTime now)
```

```csharp
public static GameTimeCondition Daily1200(DateTime now)
```

```csharp
public static GameTimeCondition Daily1500(DateTime now)
```

```csharp
public static GameTimeCondition Daily1800(DateTime now)
```

```csharp
public static GameTimeCondition Daily2100(DateTime now)
```

```csharp
public static GameTimeCondition Daily2300(DateTime now)
```

```csharp
public static GameTimeCondition Monthly(DateTime now)
```

```csharp
public static GameTimeCondition MidMonthly(DateTime now)
```

```csharp
private GameTimeCondition(GameTimeCondition.Condition condition, DateTime now)
```

```csharp
public bool Satisfied(DateTime now)
```
