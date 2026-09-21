# uMyGUI_TreeBrowser

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_TreeBrowser.cs`.*


## Class `uMyGUI_TreeBrowser`

```csharp
public class uMyGUI_TreeBrowser : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `InnerNodePrefab` | public GameObject |
| `LeafNodePrefab` | public GameObject |
| `OffsetStart` | public float |
| `OffsetEnd` | public float |
| `Padding` | public float |
| `IndentSize` | public float |
| `ForcedEntryHeight` | public float |
| `UseExplicitNavigation` | public bool |
| `NavScrollSpeed` | public float |
| `NavScrollSmooth` | public float |
| `ParentScroller` | public ScrollRect |
| `RTransform` | private RectTransform |
| `m_innerNodePrefab` | private GameObject |
| `m_leafNodePrefab` | private GameObject |
| `m_offsetStart` | private float |
| `m_offsetEnd` | private float |
| `m_padding` | private float |
| `m_indentSize` | private float |
| `m_forcedEntryHeight` | private float |
| `m_useExplicitNavigation` | private bool |
| `m_navScrollSpeed` | private float |
| `m_navScrollSmooth` | private float |
| `m_parentScroller` | private ScrollRect |
| `OnInnerNodeClick` | public EventHandler<uMyGUI_TreeBrowser.NodeClickEventArgs> |
| `OnLeafNodeClick` | public EventHandler<uMyGUI_TreeBrowser.NodeClickEventArgs> |
| `OnLeafNodePointerDown` | public EventHandler<uMyGUI_TreeBrowser.NodeClickEventArgs> |
| `OnNodeInstantiate` | public EventHandler<uMyGUI_TreeBrowser.NodeInstantiateEventArgs> |
| `m_rectTransform` | private RectTransform |
| `m_nodes` | private List<uMyGUI_TreeBrowser.InternalNode> |
| `m_lastSelectedGO` | private GameObject |
| `Node` | public class |
| `SendMessageData` | public readonly object |
| `Children` | public readonly uMyGUI_TreeBrowser.Node[] |
| `EventArgs` | public class NodeClickEventArgs : |
| `ClickedNode` | public readonly uMyGUI_TreeBrowser.Node |
| `EventArgs` | public class NodeInstantiateEventArgs : |
| `Node` | public readonly uMyGUI_TreeBrowser.Node |
| `Instance` | public readonly GameObject |
| `InternalNode` | private class |
| `m_node` | public readonly uMyGUI_TreeBrowser.Node |
| `m_instance` | public GameObject |
| `m_indentLevel` | public int |
| `m_transform` | public RectTransform |
| `m_isFoldout` | public bool |
| `m_minY` | public float |

### Methods

```csharp
public void BuildTree(uMyGUI_TreeBrowser.Node[] p_rootNodes)
```

```csharp
public void BuildTree(uMyGUI_TreeBrowser.Node[] p_rootNodes, int p_insertAt, int p_indentLevel)
```

```csharp
public void Clear()
```

```csharp
private void Start()
```

```csharp
private void LateUpdate()
```

```csharp
private void OnDestroy()
```

```csharp
private void SetExplicitNavigationTargets()
```

```csharp
private void SetAutomaticNavigation(RectTransform p_nodeTransform)
```

```csharp
private float SetRectTransformPosition(RectTransform p_transform, float p_currY, float p_size, int p_indentLevel)
```

```csharp
private void UpdateNodePosition(int p_startIndex, float p_moveDist)
```

```csharp
private void SetupInnerNode(uMyGUI_TreeBrowser.InternalNode p_node)
```

```csharp
private void SetupLeafNode(uMyGUI_TreeBrowser.InternalNode p_node)
```

```csharp
private void ToggleInnerNodeFoldout(uMyGUI_TreeBrowser.InternalNode p_node)
```

```csharp
private void SafeCallOnLeafNodePointerDown(uMyGUI_TreeBrowser.InternalNode p_node)
```

```csharp
private void SafeCallOnLeafNodeClick(uMyGUI_TreeBrowser.InternalNode p_node)
```

```csharp
public Node(object p_sendMessageData, uMyGUI_TreeBrowser.Node[] p_children)
```

```csharp
public NodeClickEventArgs(uMyGUI_TreeBrowser.Node p_clickedNode)
```

```csharp
public NodeInstantiateEventArgs(uMyGUI_TreeBrowser.Node p_node, GameObject p_instance)
```

```csharp
public InternalNode(uMyGUI_TreeBrowser.Node p_node, GameObject p_instance, int p_indentLevel)
```
