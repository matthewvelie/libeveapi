### Description ###
Represents the number of kills per system from the eve api

### Library Method ###
```
/// <summary>
/// Returns a list kills in solar systems with more than 0 kills
/// </summary>
/// <returns></returns>
public static MapKills GetMapKills()
```

### Results ###
**MapKills class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| MapSystemKills | MapKillsItem | List of kills information for each system |

**MapKills.MapKillsItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| SolarSystemId | int | The Id of the solarsystem |
| ShipKills | int | The number of kills |
| FactionKills | int | The number of kills |
| PodKills | int | The number of pod kills |

### Example ###
```
public static void MapKillsExample()
{
    MapKills mapKills = EveApi.GetMapKills();
    foreach (MapKills.MapKillsItem item in mapKills.MapSystemKills)
    {
        if (item.ShipKills > 5)
        {
            Console.WriteLine("{0} is a bad place to be right now", item.SolarSystemId);
        }
    }
}
```