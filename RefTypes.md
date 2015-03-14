### Description ###
This represents the different refence types used in the journal entries

### Library Method ###
```
/// <summary>
/// Returns a list of RefTypes that are used by certain API Calls
/// </summary>
/// <returns></returns>
public static RefTypes GetRefTypesList()
```

### Result ###
**RefTypes class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| string GetReferenceTypeNameForId(int referenceTypeId) | Method | Returns the description for the specified reference type id |

### Example ###
```
public static void RefTypesExaple()
{
    RefTypes refTypes = EveApi.GetRefTypesList();
    Console.WriteLine("Type {0} Name {1}", 1, refTypes.GetReferenceTypeNameForId(1));
}
```