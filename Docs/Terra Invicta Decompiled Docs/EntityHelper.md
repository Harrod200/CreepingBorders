# EntityHelper

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/EntityHelper.cs`.*


## Class `EntityHelper`

```csharp
public class EntityHelper : IInitializable
```

### Fields

| Name | Type |
|---|---|
| `entityContainer` | private GameObject |
| `entityManager` | private EntityManager |
| `entitySettings` | private TestSettings.EntitySettings |

### Methods

```csharp
public void Initialize()
```

```csharp
public T CreateEntity<T>(GameObject prefab) where T : MonoBehaviour
```

```csharp
public T CreateEntity<T>() where T : MonoBehaviour
```
