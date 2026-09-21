# TIDateTime

*Decompiled from `TIDateTime.cs`.*


## Class `TIDateTime`

```csharp
public class TIDateTime : IComparable
```

### Fields

| Name | Type |
|---|---|
| `operator` | public static bool |
| `year` | public int |
| `month` | public int |
| `day` | public int |
| `hour` | public int |
| `minute` | public int |
| `second` | public int |
| `millisecond` | public int |
| `GregorianYear_s` | private const float |
| `JulianYear_s` | private const float |

### Methods

```csharp
public TIDateTime()
```

```csharp
public TIDateTime(DateTime time)
```

```csharp
public TIDateTime(TIDateTime initTime)
```

```csharp
public TIDateTime(TIDateTime initTime, double adjustment_s)
```

```csharp
public TIDateTime(DateTime dt, double adjustment_s)
```

```csharp
public TIDateTime(int year, int month, int day)
```

```csharp
public TIDateTime(int year, int month, int day, int hour, int minute)
```

```csharp
public void ImportTime(DateTime dt)
```

```csharp
public DateTime ExportTime()
```

```csharp
public void AddSeconds(double number = 1.0)
```

```csharp
public void AddHours(double number = 1.0)
```

```csharp
public void AddDays(float number = 1f)
```

```csharp
public bool TryAddDays(float number = 1f)
```

```csharp
public TIDateTime DaysAdded(float number)
```

```csharp
public void AddMonths(int number = 1)
```

```csharp
public void AddYears(int number = 1)
```

```csharp
public void AddMilliseconds(int number = 1)
```

```csharp
public void CopyDateTime(TIDateTime newDateTime)
```

```csharp
public void SetTime(int newYear, int newMonth, int newDay, int newHour = 0, int newMinute = 0, int newSecond = 0, int newMillisec = 0)
```

```csharp
public TIDateTime SetTime(double julianEpoch)
```

```csharp
public double ToJulianDate()
```

```csharp
public double ToJulianDateInSeconds()
```

```csharp
public double ToJulianEpoch()
```

```csharp
public double DifferenceInMillis(TIDateTime toSubtract)
```

```csharp
public double DifferenceInSeconds(TIDateTime toSubtract)
```

```csharp
public double DifferenceInHours(TIDateTime toSubtract)
```

```csharp
public double DifferenceInDays(TIDateTime toSubtract)
```

```csharp
public double DifferenceInJulianYears(TIDateTime toSubtract)
```

```csharp
public string ToShortDateString()
```

```csharp
public string ToCustomDateString()
```

```csharp
public string ToLongDateString()
```

```csharp
public string ToLongTimeString()
```

```csharp
public string ToShortTimeString()
```

```csharp
public string ToCustomTimeString()
```

```csharp
public string ToCustomTimeDateString()
```

```csharp
public static string GetMonthString(int monthIdx)
```

```csharp
public override string ToString()
```

```csharp
public string ToString(string param)
```

```csharp
public static bool operator <(TIDateTime val1, TIDateTime val2)
```

```csharp
public static bool operator >(TIDateTime val1, TIDateTime val2)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public override int GetHashCode()
```

```csharp
public int CompareTo(object obj)
```

```csharp
public static TIDateTime Min(TIDateTime a, TIDateTime b)
```

```csharp
public static TIDateTime Max(TIDateTime a, TIDateTime b)
```
