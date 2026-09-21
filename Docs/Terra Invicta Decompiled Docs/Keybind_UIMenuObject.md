# Keybind_UIMenuObject

*Decompiled from `Keybind_UIMenuObject.cs`.*


## Class `Keybind_UIMenuObject`

```csharp
public class Keybind_UIMenuObject : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `displayText` | public string |
| `currentKeybindText` | public TextMeshProUGUI |
| `currentKeybindName` | public TextMeshProUGUI |
| `waitingForNewKey` | public bool |
| `keybindIndex` | public int |
| `editable` | public bool |
| `editButton` | public Button |

### Methods

```csharp
private void Start()
```

```csharp
public void LoadLocalizedText()
```

```csharp
public void ClickedNewKeybind()
```

```csharp
public void OnClickRemoveKeybind()
```

```csharp
private void OnLanguageChangedEvent()
```

```csharp
private void OnDestroy()
```
