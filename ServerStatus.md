### Description ###
Retrieves current Tranquility status

### Library Method ###
```
/// <summary>
/// Retrieve current Tranquility status
/// </summary>
/// <returns></returns>
public static ServerStatus GetServerStatus()
```

### Result ###
**ServerStatus class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| ServerOpen | bool | Server status |
| OnlinePlayers | int | Number of players currently online |

### Example ###
```
public static void ServerStatus()
{
    ServerStatus serverStatus = EveApi.GetServerStatus();

    if (serverStatus.ServerOpen)
    {
        Console.WriteLine("Tranquility is currently up");
        Console.WriteLine("There are currently {0} players online", serverStatus.OnlinePlayers);
    }
    else
    {
        Console.WriteLine("Tranquility is currently down");
    }
}
```