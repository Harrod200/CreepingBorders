# TICondition

*Decompiled from `TICondition.cs`.*


## Class `TICondition`

```csharp
public class TICondition
```

### Fields

| Name | Type |
|---|---|
| `descriptionParams` | public virtual List<string> |
| `symbolResource` | public virtual string |
| `strIdx` | public string |
| `sign` | public ConditionSign |
| `strValue` | public string |
| `pass` | public const string |

### Methods

```csharp
public virtual ConditionTargetType ConditionTarget()
```

```csharp
public virtual bool PassesCondition(TIGameState state)
```

```csharp
public virtual bool TargetPassesCondition(TIGameState state, TIGameState targetedState)
```

```csharp
public bool IsValid()
```

```csharp
public virtual string GetDescriptionPath()
```

```csharp
public string GetDescriptionPathWithValue()
```

```csharp
public string GetDescriptionPathWithSign()
```

```csharp
public StringBuilder GetDescription()
```

```csharp
public string GetNumericComparisonString(bool percent = false)
```

```csharp
public static bool PassesComparison(ConditionSign sign, double value1, double value2)
```

```csharp
public static bool PassesComparison(ConditionSign sign, float value1, float value2)
```

```csharp
public static bool PassesComparison(ConditionSign sign, int value1, int value2)
```

```csharp
public static bool PassesComparison(ConditionSign sign, bool bvalue1, bool bvalue2)
```

```csharp
public static bool PassesComparison(ConditionSign sign, string sValue1, string sValue2)
```

```csharp
public static bool PassesComparison<T>(ConditionSign sign, T sValue1, T sValue2) where T : class
```

```csharp
public static bool PassesComparison<T>(ConditionSign sign, T item, IList<T> collection)
```
