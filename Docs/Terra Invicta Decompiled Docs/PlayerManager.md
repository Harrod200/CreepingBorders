# PlayerManager

*Decompiled from `PavonisInteractive/TerraInvicta/PlayerManager.cs`.*


## Class `PlayerManager`

```csharp
public class PlayerManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `container` | private GameObjectDictionary<GameStateID> |
| `factory` | private Player.Factory |
| `_container` | private GameObjectDictionary<GameStateID> |

### Methods

```csharp
public void Construct(Player.Factory playerFactory)
```

```csharp
public GameObject FindPlayer(GameStateID playerID)
```

```csharp
public Player FindPlayerComponent(TIFactionState faction)
```

```csharp
public bool TryFindPlayer(GameStateID ID, out GameObject gameObject)
```

```csharp
public void RemovePlayer(GameStateID playerID)
```

```csharp
public void Initialize()
```
