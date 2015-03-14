### Description ###
A list of error codes that can be returned by the EVE API servers

### Library Method ###
```
/// <summary>
/// Returns a list of error codes that can be returned by the EVE API servers
/// </summary>
/// <returns></returns>
public static ErrorList GetErrorList()
```

### Result ###
**ErrorList class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| GetMessageForErrorCode(string errorCode) | method | Returns the description for the specified error code |

### Example ###
```
public static void ErrorListExample()
{
    ErrorList errorList = EveApi.GetErrorList();
    Console.WriteLine("{0}", errorList.GetMessageForErrorCode("100"));
}
```