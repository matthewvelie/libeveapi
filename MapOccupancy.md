### Description ###
Returns a list of contestable solarsystems and the NPC faction currently occupying them. It should be noted that this file only returns a non-zero ID if the occupying faction is not the sovereign faction.

### Library Method ###
```
/// <summary>
/// Get a list of contestable solar systems and the NPC faction currently occupying them
/// </summary>
/// <returns></returns>
public static MapFacWarSystems GetFactionWarSystems()
```

### Result ###
**MapFacWarSystems class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| FactionWarSystems | FactionWarSystem[.md](.md) | Array of solar systems |

**MapFacWarSystems.FactionWarSystem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| SolarSystemId | int | Unique ID of a solar system |
| SolarSystemName | string | Name of the solar system |
| OccuppyingFactionId | int | Unique ID of occupying faction |
| OccupyingFactionName | string | Name of occupying faction |
| !Contested | bool | Whether the system is being fought over |

### Example ###
```
public static void MapFactionWarSystemsExample()
{
    MapFacWarSystems mapFacWarSystems = EveApi.GetFactionWarSystems();

    Console.WriteLine("Currently occupied by Gallente Federation:");
    foreach (MapFacWarSystems.FactionWarSystem system in mapFacWarSystems.FactionWarSystems)
    {
        if (system.OccupyingFactionId == 500004)
        {
            Console.WriteLine(system.SolarSystemName);
        }
    }
}
```