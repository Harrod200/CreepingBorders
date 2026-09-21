# EnumerableExtensions

*Decompiled from `EnumerableExtensions.cs`.*


## Class `EnumerableExtensions`

```csharp
public static class EnumerableExtensions
```

### Methods

```csharp
public static T SelectRandomWeightedItem<T>(this IEnumerable<T> weightedList, Func<T, float> Selector, float totalWeight = -1f, float min = 1E-37f)
```

```csharp
public static IEnumerable<T> SelectRandomWeightedItems<T>(this IEnumerable<T> enumberable, Func<T, float> Selector, int count, bool doNotReplace = true)
```

```csharp
public static T MaxBy<T, R>(this IEnumerable<T> en, Func<T, R> evaluate) where R : IComparable<R>
```

```csharp
public static T MinBy<T, R>(this IEnumerable<T> en, Func<T, R> evaluate) where R : IComparable<R>
```

```csharp
public static T SelectRandomItem<T>(this IList<T> collection)
```

```csharp
public static T SelectRandomItem<T>(this T[] collection)
```

```csharp
public static T SelectRandomItem<T>(this IEnumerable<T> collection)
```

```csharp
public static IEnumerable<T> SelectRandomItems<T>(this IEnumerable<T> collection, int count)
```

```csharp
public static bool None<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
```

```csharp
public static bool NotAll<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
```

```csharp
public static bool OnlySome<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
```

```csharp
public static bool AddUnique<T>(this List<T> list, T item)
```

```csharp
public static void AddRangeUnique<T>(this List<T> list, List<T> items)
```

```csharp
public static IEnumerable<ValueTuple<T, U>> ToCollection<T, U>(this Dictionary<T, IEnumerable<U>> dictionary)
```

```csharp
public static IEnumerable<ValueTuple<T, U>> ToCollection<T, U>(this Dictionary<T, List<U>> dictionary)
```

```csharp
public static IEnumerable<ValueTuple<T, U>> ToCollection<T, U>(this Dictionary<T, HashSet<U>> dictionary)
```

```csharp
public static List<T> Sort<T, U>(this List<T> list, Func<T, U> Evaluate) where U : IComparable
```

```csharp
public static List<T> Sorted<T, U>(this IEnumerable<T> elements, Func<T, U> Evaluate) where U : IComparable
```

```csharp
public static IEnumerable<T> Take_Random<T>(this IEnumerable<T> elements, int count)
```

```csharp
public static IEnumerable<T> BottomPercentage<T, U>(this IEnumerable<T> elements, Func<T, U> Evaluate, float percentage) where U : IComparable
```

```csharp
public static IEnumerable<T> TopPercentage<T, U>(this IEnumerable<T> elements, Func<T, U> Evaluate, float percentage) where U : IComparable
```

```csharp
public static float Product(this float[] elements, float emptyValue = 0f)
```

```csharp
public static float Product(this List<float> elements, float emptyValue = 0f)
```
