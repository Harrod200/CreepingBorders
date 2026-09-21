# DictionaryExtensions

*Decompiled from `DictionaryExtensions.cs`.*


## Class `DictionaryExtensions`

```csharp
public static class DictionaryExtensions
```

### Methods

```csharp
public static string ToDetailedString<T, V>(this Dictionary<T, V> dict)
```

```csharp
public static Dictionary<T, IEnumerable<U>> ToEnumerableDictionary<T, U>(this Dictionary<T, List<U>> dictionary)
```

```csharp
public static Dictionary<T, IEnumerable<U>> ToEnumerableDictionary<T, U>(this Dictionary<T, HashSet<U>> dictionary)
```

```csharp
public static Dictionary<U, T> Inverted<T, U>(this Dictionary<T, IEnumerable<U>> dictionary)
```

```csharp
public static Dictionary<U, T> Inverted<T, U>(this Dictionary<T, List<U>> dictionary)
```

```csharp
public static Dictionary<K, V> CorrectEnumKeyedDictionary<K, V>(this Dictionary<K, V> dictionary, V defaultValue = default(V)) where K : Enum
```
