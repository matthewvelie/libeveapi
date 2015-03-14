### Description ###
Represents the number of jumps per system from the eve api

### Library Method ###
```
/// <summary>
/// Returns a list solar systems that have more than 0 jumps with the jump count
/// </summary>
/// <returns></returns>
public static MapJumps GetMapJumps()
```

### Results ###
**MapJumps class (See ApiResult for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| MapSystemJumps | MapSystemItem[.md](.md) | List of jumps per system |

**MapJumps.MapSystemItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| SolarSystemId | int | The Id of the solar system |
| ShipJumps | int | The number of jumps to/from the system |

### Example ###
```
public static void MapJumpsExample()
{
    MapJumps mapJumps = EveApi.GetMapJumps();
    foreach (MapJumps.MapSystemItem system in mapJumps.MapSystemJumps)
    {
        Console.WriteLine("System: {0} Number of Jumps: {1}", system.SolarSystemId, system.ShipJumps);
    }
}
```