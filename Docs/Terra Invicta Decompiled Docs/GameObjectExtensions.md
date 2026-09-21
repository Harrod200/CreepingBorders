# GameObjectExtensions

*Decompiled from `PavonisInteractive/TerraInvicta/GameObjectExtensions.cs`.*


## Class `GameObjectExtensions`

```csharp
public static class GameObjectExtensions
```

### Methods

```csharp
public static T GetComponent<T>(this GameObject gameObject) where T : MonoBehaviour
```

```csharp
public static void GetComponentsInChildren<T>(this GameObject gameObject, bool includeInactive, int childDepth, ref List<T> components)
```

```csharp
public static T GetComponentOnChild<T>(this GameObject gameObject, string childName) where T : Component
```

```csharp
public static bool Has<T>(this GameObject gameObject) where T : MonoBehaviour
```

```csharp
public static T Add<T>(this GameObject gameObject) where T : MonoBehaviour
```

```csharp
public static T GetOrAdd<T>(this GameObject gameObject) where T : MonoBehaviour
```

```csharp
public static void Remove<T>(this GameObject gameObject, bool destroyImmediately = false) where T : MonoBehaviour
```

```csharp
public static T GetComponentInParent<T>(this GameObject gameObject, bool includeInactive) where T : Component
```

```csharp
public static T GetComponentInParent<T>(this Component component, bool includeInactive) where T : Component
```

```csharp
public static T GetComponentInParent<T>(this Transform transform, bool includeInactive) where T : Component
```

```csharp
public static void SortChildren(this Transform transform, Func<Transform, IComparable> Evaluate, bool smallestToLargest = true, Func<Transform, bool> Predicate = null)
```

```csharp
public static void SortChildren<T>(this Transform transform, Func<T, IComparable> Evaluate, bool smallestToLargest = true) where T : MonoBehaviour
```

```csharp
public static IEnumerable<Transform> Children(this Transform transform)
```

```csharp
public static int ActiveChildCount(this Transform transform)
```

```csharp
public static bool HasComponent<T>(this GameObject gameObject)
```

```csharp
public static bool HasComponent<T>(this Component component)
```
