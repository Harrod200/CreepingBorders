# fsJsonPrinter

*Decompiled from `FullSerializer/fsJsonPrinter.cs`.*


## Class `fsJsonPrinter`

```csharp
public static class fsJsonPrinter
```

### Methods

```csharp
private static void InsertSpacing(TextWriter stream, int count)
```

```csharp
private static string EscapeString(string str)
```

```csharp
private static void BuildCompressedString(fsData data, TextWriter stream)
```

```csharp
private static void BuildPrettyString(fsData data, TextWriter stream, int depth)
```

```csharp
public static void PrettyJson(fsData data, TextWriter outputStream)
```

```csharp
public static string PrettyJson(fsData data)
```

```csharp
public static void CompressedJson(fsData data, StreamWriter outputStream)
```

```csharp
public static string CompressedJson(fsData data)
```

```csharp
private static string ConvertDoubleToString(double d)
```
