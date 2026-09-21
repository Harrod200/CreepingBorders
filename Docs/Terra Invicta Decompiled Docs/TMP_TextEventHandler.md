# TMP_TextEventHandler

*Decompiled from `TMPro/TMP_TextEventHandler.cs`.*


## Class `TMP_TextEventHandler`

```csharp
public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `onCharacterSelection` | public TMP_TextEventHandler.CharacterSelectionEvent |
| `onSpriteSelection` | public TMP_TextEventHandler.SpriteSelectionEvent |
| `onWordSelection` | public TMP_TextEventHandler.WordSelectionEvent |
| `onLineSelection` | public TMP_TextEventHandler.LineSelectionEvent |
| `onLinkSelection` | public TMP_TextEventHandler.LinkSelectionEvent |
| `m_OnCharacterSelection` | private TMP_TextEventHandler.CharacterSelectionEvent |
| `m_OnSpriteSelection` | private TMP_TextEventHandler.SpriteSelectionEvent |
| `m_OnWordSelection` | private TMP_TextEventHandler.WordSelectionEvent |
| `m_OnLineSelection` | private TMP_TextEventHandler.LineSelectionEvent |
| `m_OnLinkSelection` | private TMP_TextEventHandler.LinkSelectionEvent |
| `m_TextComponent` | private TMP_Text |
| `m_Camera` | private Camera |
| `m_Canvas` | private Canvas |
| `m_selectedLink` | private int |
| `m_lastCharIndex` | private int |
| `m_lastWordIndex` | private int |
| `m_lastLineIndex` | private int |

### Methods

```csharp
private void Awake()
```

```csharp
private void LateUpdate()
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```

```csharp
private void SendOnCharacterSelection(char character, int characterIndex)
```

```csharp
private void SendOnSpriteSelection(char character, int characterIndex)
```

```csharp
private void SendOnWordSelection(string word, int charIndex, int length)
```

```csharp
private void SendOnLineSelection(string line, int charIndex, int length)
```

```csharp
private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
```
