# fsConfig

*Decompiled from `FullSerializer/fsConfig.cs`.*


## Class `fsConfig`

```csharp
public class fsConfig
```

### Fields

| Name | Type |
|---|---|
| `SerializeAttributes` | public Type[] |
| `IgnoreSerializeAttributes` | public Type[] |
| `DefaultMemberSerialization` | public fsMemberSerialization |
| `EnablePropertySerialization` | public bool |
| `SerializeNonAutoProperties` | public bool |
| `SerializeNonPublicSetProperties` | public bool |
| `CustomDateTimeFormatString` | public string |
| `Serialize64BitIntegerAsString` | public bool |
| `SerializeEnumsAsInteger` | public bool |

### Properties

- `public Func<string, MemberInfo, string> GetJsonNameFromMemberName = (string name, MemberInfo info) => name;`
