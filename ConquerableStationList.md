### Description ###
A list of all the conquerable stations in the game.

### Library Method ###
```
/// <summary>
/// Gets a list of conquerable stations from the api
/// </summary>
/// <returns></returns>
public static ConquerableStationList GetConquerableStationList()
```

### Result ###
**ConquerableStationList class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| ConquerableStations | ConquerableStation[.md](.md) | List of conquerable stations |

**ConquerableStationList.ConquerableStation class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| StationId | int | Unique identifier for the station |
| StationName | string | Name of the station |
| StationTypeId | int | The unique identifier for the station type |
| SolarSystemId | int | The unique identifier of the solar system where the station is located |
| CorporationId | int | The unique identifier of the corporation that owns the station |
| CorporationName | string | The name of the corporation that owns the station |

### Example ###
```
public static void ConquerableStationListExample()
{
    ConquerableStationList csl = EveApi.GetConquerableStationList();
    foreach (ConquerableStationList.ConquerableStation station in csl.ConquerableStations)
    {
        Console.WriteLine("Station Name: {0} Corporation Name: {1}", station.StationName, station.CorporationName);
    }
}
```