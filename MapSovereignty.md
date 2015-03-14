### Description ###
Returns a list of solarsystems and what faction or alliance controls them.

### Library Method ###
```
/// <summary>
/// Returns a list solar systems that have sovereignty
/// </summary>
/// <returns></returns>
public static MapSovereignty GetMapSovereignty()
```

### Result ###
**MapSovereignty class (See ApiResult for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| M!apSystemSovereigntyItems | MapSovereigntyItem[.md](.md) | List of systems and their sovereignty status |

**MapSovereignty.MapSovereigntyItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| SolarSystemId | int | The unique identification number of a solar system |
| AllianceId | int | The Id of the alliance that has sovereignty of this solar system, or 0 if nobody has sovereignty. |
| ConstellationSovereignty | int | The Id of the alliance that has sovereignty of this constellation, or 0 if nobody has constellation sovereignty. http://myeve.eve-online.com/devblog.asp?a=blog&bid=477 |
| SovereigntyLevel | int | The level of sovereignty |
| FactionId | int | The NPC faction that controls this system |
| SolarSystemName | string | Name of the solar system |

### Example ###
```
public static void MapSovereigntyExample()
{
    MapSovereignty ms = EveApi.GetMapSovereignty();
    foreach (MapSovereignty.MapSovereigntyItem msi in ms.MapSystemSovereigntyItems)
    {
        Console.WriteLine("System Name: {0} Sovereignty Level: {1}", msi.SolarSystemName, msi.SovereigntyLevel);
    }
}
```