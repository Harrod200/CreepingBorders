# GSMSerializeTest

*Decompiled from `PavonisInteractive/TerraInvicta/Test/GSMSerializeTest.cs`.*


## Class `GSMSerializeTest`

```csharp
public class GSMSerializeTest : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `savePath` | public string |
| `tests` | private List<MethodInfo> |
| `testCount` | private int |
| `failCount` | private int |
| `testFailures` | private int |
| `TIGameState` | public class SimpleState : |
| `a` | public int |
| `TIGameState` | public class SelfState : |
| `selfID` | public GameStateID |
| `self` | public GSMSerializeTest.SelfState |
| `TIGameState` | public class RefState : |
| `state` | public GSMSerializeTest.SimpleState |
| `TIGameState` | public class ListState : |
| `states` | public List<GSMSerializeTest.SimpleState> |
| `TIGameState` | public class DictionaryState : |
| `stateMap` | public Dictionary<GSMSerializeTest.SimpleState, GSMSerializeTest.SimpleState> |

### Methods

```csharp
public void ATestSelfReference()
```

```csharp
public void ATestOtherReference()
```

```csharp
public void ATestListReferences()
```

```csharp
public void TestDictReferences()
```

```csharp
private void SaveAndLoad()
```

```csharp
private void Report()
```

```csharp
private void AssertNotNull(object o)
```

```csharp
private void AssertEqual(GameStateID a, GameStateID b)
```

```csharp
private void AssertEqual(object a, object b)
```

```csharp
private void AssertNotEqual(object a, object b)
```

```csharp
private void Assert(Func<bool> f, string failMessage = "Assertion Failed")
```

```csharp
private void Awake()
```

```csharp
private void Update()
```
