# fsJsonParser

*Decompiled from `FullSerializer/fsJsonParser.cs`.*


## Class `fsJsonParser`

```csharp
public class fsJsonParser
```

### Methods

```csharp
private fsResult MakeFailure(string message)
```

```csharp
private bool TryMoveNext()
```

```csharp
private bool HasValue()
```

```csharp
private bool HasValue(int offset)
```

```csharp
private char Character()
```

```csharp
private char Character(int offset)
```

```csharp
private void SkipSpace()
```

```csharp
private bool IsHex(char c)
```

```csharp
private uint ParseSingleChar(char c1, uint multipliyer)
```

```csharp
private uint ParseUnicode(char c1, char c2, char c3, char c4)
```

```csharp
private fsResult TryUnescapeChar(out char escaped)
```

```csharp
private fsResult TryParseExact(string content)
```

```csharp
private fsResult TryParseTrue(out fsData data)
```

```csharp
private fsResult TryParseFalse(out fsData data)
```

```csharp
private fsResult TryParseNull(out fsData data)
```

```csharp
private bool IsSeparator(char c)
```
