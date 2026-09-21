# ListExtensions

*Decompiled from `PavonisInteractive/TerraInvicta/ListExtensions.cs`.*


## Class `ListExtensions`

```csharp
public static class ListExtensions
```

### Methods

```csharp
public static T GetElement<T>(this List<T> list, Func<T, bool> cmp) where T : class
```

```csharp
public static List<T> Shuffle<T>(this List<T> collection)
```

```csharp
public static List<T> AddSizeItemsToDefault<T>(this List<T> list, int newSize, T defaultValue = default(T))
```
