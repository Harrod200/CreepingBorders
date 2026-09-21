# TIInputManager

*Decompiled from `TIInputManager.cs`.*


## Class `TIInputManager`

```csharp
public class TIInputManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `mainCamera` | private static Camera |
| `IsDragSelecting` | public static bool |
| `IsAltKeyDown` | public static bool |
| `IsControlKeyDown` | public static bool |
| `IsShiftKeyDown` | public static bool |
| `ControlGroupKeyPressedThisFrame` | public static bool |
| `IsModifierKeyDown` | public static bool |
| `IsLeftMouseButtonDown` | public static bool |
| `WasLeftMouseButtonClicked` | public static bool |
| `IsRightMouseButtonDown` | public static bool |
| `WasRightMouseButtonClicked` | public static bool |
| `IsCameraMovementKeyPressed` | public static bool |
| `IsMouseHoveringApplication` | public static bool |
| `acceptingInput` | public static bool |
| `waitingForKeybind` | public static bool |
| `inTargetingMode` | public static bool |
| `blockSelectionRaycasts` | public static bool |
| `blockCombatZoom` | public static bool |
| `receivingInputForNarrativeHotkeys` | public static bool |
| `hidingUI` | private static bool |
| `currentRebind` | public static Keybind_UIMenuObject |
| `keyBindings` | public static List<KeyCode> |
| `keyBindingModifiers` | public static List<KeyCode> |
| `keyBindingsReserve` | public static List<KeyCode> |
| `forbiddenBindings` | public List<KeyCode> |
| `modifierKeys` | public List<KeyCode> |
| `Objectives` | public static KeyCode |
| `PoliticalEarth` | public static KeyCode |
| `SolarSystem` | public static KeyCode |
| `Councilors` | public static KeyCode |
| `Nations` | public static KeyCode |
| `Habitats` | public static KeyCode |
| `Fleets` | public static KeyCode |
| `Research` | public static KeyCode |
| `Intel` | public static KeyCode |
| `CycleRecolorEarthMap` | public static KeyCode |
| `ToggleOrbitTrails` | public static KeyCode |
| `ToggleExpandNewsFeed` | public static KeyCode |
| `QuickSave` | public static KeyCode |
| `ToggleHelper` | public static KeyCode |
| `ToggleDistanceSymbols` | public static KeyCode |
| `ToggleProspectData` | public static KeyCode |
| `ToggleShowAllColonizedBodyNames` | public static KeyCode |
| `OpenShipDesigner` | public static KeyCode |
| `OpenConstructionManager` | public static KeyCode |
| `OpenGlobalSearch` | public static KeyCode |
| `AccessibilityMagnifier` | public static KeyCode |
| `IncreaseSpeed` | public static KeyCode |
| `DecreaseSpeed` | public static KeyCode |
| `PauseSpeed` | public static KeyCode |
| `PauseSpeedNoToggle` | public static KeyCode |
| `SetSpeedIndex1` | public static KeyCode |
| `SetSpeedIndex2` | public static KeyCode |
| `SetSpeedIndex3` | public static KeyCode |
| `SetSpeedIndex4` | public static KeyCode |
| `SetSpeedIndex5` | public static KeyCode |
| `SetSpeedIndex6` | public static KeyCode |
| `cameraLeft` | public static KeyCode |
| `cameraRight` | public static KeyCode |
| `cameraUp` | public static KeyCode |
| `cameraDown` | public static KeyCode |
| `cameraZoomIn` | public static KeyCode |
| `cameraZoomOut` | public static KeyCode |
| `altitudeControl` | public static KeyCode |
| `lateralControl` | public static KeyCode |
| `burnControl` | public static KeyCode |
| `yawControl` | public static KeyCode |
| `pitchControl` | public static KeyCode |
| `rollControl` | public static KeyCode |
| `cycleShipsUp` | public static KeyCode |
| `cycleShipsDown` | public static KeyCode |
| `toggleGrid` | public static KeyCode |
| `toggleCombatUI` | public static KeyCode |
| `toggleShipWaypoints` | public static KeyCode |
| `toggleFPSWidget` | public static KeyCode |
| `fleetCommandSelectPrimaryTarget` | public static KeyCode |
| `fleetCommandLaunchMissileSalvo` | public static KeyCode |
| `controlGroup1` | public static KeyCode |
| `controlGroup2` | public static KeyCode |
| `controlGroup3` | public static KeyCode |
| `controlGroup4` | public static KeyCode |
| `controlGroup5` | public static KeyCode |
| `controlGroup6` | public static KeyCode |
| `controlGroup7` | public static KeyCode |
| `controlGroup8` | public static KeyCode |
| `controlGroup9` | public static KeyCode |
| `controlGroup0` | public static KeyCode |
| `cursor_Resist` | public Texture2D |
| `cursor_Alien` | public Texture2D |
| `cursor_Appease` | public Texture2D |
| `cursor_Cooperate` | public Texture2D |
| `cursor_Destroy` | public Texture2D |
| `cursor_Escape` | public Texture2D |
| `cursor_Exploit` | public Texture2D |
| `cursor_Main` | public Texture2D |
| `cursor_Neutral` | public Texture2D |
| `default_Cursor` | public Texture2D |
| `target_Cursor` | public Texture2D |
| `target_CursorValid` | public Texture2D |
| `target_CursorInvalid` | public Texture2D |
| `faction_TargetCursorInvalid` | public static Texture2D |
| `faction_TargetCursorValid` | public static Texture2D |
| `cursorResist` | public static Texture2D |
| `cursorAlien` | public static Texture2D |
| `cursorAppease` | public static Texture2D |
| `cursorCooperate` | public static Texture2D |
| `cursorDestroy` | public static Texture2D |
| `cursorEscape` | public static Texture2D |
| `cursorExploit` | public static Texture2D |
| `cursorMain` | public static Texture2D |
| `cursorNeutral` | public static Texture2D |
| `targetCursor` | public static Texture2D |
| `targetCursorValid` | public static Texture2D |
| `targetCursorInvalid` | public static Texture2D |
| `defaultCursor` | public static Texture2D |
| `cursorInit` | public bool |
| `flickTime` | private float |
| `flickTimer` | private float |
| `cSwap` | private bool |
| `lastMousePos` | public static Vector3 |
| `lastClickedGameState` | public static TIGameState |
| `lastClickedTimeStamp` | public static float |
| `_isDragSelecting` | private static bool |
| `_dragSelectValid` | private static bool |
| `_boxSelectStartPosition` | private static Vector3 |
| `_boxSelectEndPosition` | private static Vector3 |
| `_boxColor` | private static Color |
| `hit` | private static RaycastHit |
| `_selectionBox` | private static MeshCollider |
| `_selectionMesh` | private static Mesh |
| `_mainCamera` | private static Camera |
| `_boxSelectedMarkerControllers` | private static List<MarkerController> |
| `_corners` | private static Vector2[] |
| `_verts` | private static Vector3[] |
| `_vecs` | private static Vector3[] |
| `lastModifierKeycode` | public KeyCode |
| `altitudeHeightOffset` | public static float |
| `factionCursor` | private static Texture2D |
| `BoxSelectionUtils` | public static class |
| `WhiteTexture` | public static Texture2D |
| `_whiteTexture` | private static Texture2D |
| `KeyPressMode` | public enum |

### Properties

- `public static TIInputManager inputManager`

### Methods

```csharp
public static void LoadProfileKeybindings()
```

```csharp
public static void InitBindingArray()
```

```csharp
public static void UpdateBindings(bool saveData = true)
```

```csharp
public static bool IsHotkeyTriggered(KeyCode hotkey, TIInputManager.KeyPressMode keyPressMode = TIInputManager.KeyPressMode.Down)
```

```csharp
public static bool DoubleClickedGameState(TIGameState gameState, bool registerClick = false)
```

```csharp
private void Awake()
```

```csharp
public static void Init()
```

```csharp
public static void BlockKeybindings()
```

```csharp
public static void RestoreKeybindings()
```

```csharp
public static void RemoveKeyBind(Keybind_UIMenuObject uiKeybind)
```

```csharp
public static void ResetKeybindsToDefault()
```

```csharp
private void OnApplicationFocus(bool focus)
```

```csharp
private void Update()
```

```csharp
public static void ToggleCursorVisibility()
```

```csharp
private void CursorTest()
```

```csharp
private void LateUpdate()
```

```csharp
public bool CheckNewKeybind(KeyCode newKeycode, KeyCode newModifierKeycode)
```

```csharp
public static void SetNewKeybind(int index, KeyCode newKeycode, KeyCode newModifierKeycode = KeyCode.None)
```

```csharp
public static string GetKeybind(int index)
```

```csharp
public static string GetReserveKeybind(int index)
```

```csharp
public static string GetKeybindWithModifiers(int index)
```

```csharp
public static void SetDefaultCursor(bool useFactionCursor = true)
```

```csharp
public static Texture2D GetFactionCursor(string presetName)
```

```csharp
public static Texture2D CombineCursors(Texture2D cur1, Texture2D cur2)
```

```csharp
public static Texture2D ScaleTextureLinux(Texture2D source, int targetWidth, int targetHeight)
```

```csharp
public static void SetCursorNew(Texture2D cursorSprite, bool targetting = false)
```

```csharp
public static void SetCursor(Texture2D cursorSprite, bool targetting = false)
```

```csharp
public static void CreateTargetingCursor(Texture2D cursorSprite)
```

```csharp
private void OnBoxSelectReleased()
```

```csharp
private Vector2[] getBoundingBox(Vector2 p1, Vector2 p2)
```

```csharp
private Mesh generateSelectionMesh(Vector3[] corners, Vector3[] vecs)
```

```csharp
private void CleanUpSelectionBox()
```

```csharp
public void CancelBoxSelect(CombatPauseMenuOpened e)
```

```csharp
public static void CancelBoxSelect()
```

```csharp
private void OnTriggerEnter(Collider other)
```

```csharp
private void OnGUI()
```

```csharp
public static void DrawScreenRect(Rect rect, Color color)
```

```csharp
public static void DrawScreenRectBorder(Rect rect, float thickness, Color color)
```

```csharp
public static Rect GetScreenRect(Vector3 screenPosition1, Vector3 screenPosition2)
```
