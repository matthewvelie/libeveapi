### Description ###
Represents a character name and CharacterId response from the eve api

### Library Methods ###
```
/// <summary>
/// Returns the character id and character name, given the one or the other
/// </summary>
/// <param name="characterId">characterId used to look up character name</param>
/// <returns></returns>
public static CharacterIdName GetCharacterIdName(int characterId)

/// <summary>
/// Returns the character id and character name, given the one or the other
/// </summary>
/// <param name="charactername">character name string, use to look up character id</param>
/// <returns></returns>
public static CharacterIdName GetCharacterIdName(string charactername)
```


### Results ###
**CharacterIdName class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| CharacterIdItems | CharacterIdItem[.md](.md) | The character name and character id that are associated with each other |

**CharacterIdName.CharacterIdItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| Name | string | The character's name |
| CharacterId | int | the characterId associated with the character name |

### Example ###
```
public static int GetCharacterIdByName(string characterName)
{
    CharacterId characterId = EveApi.GetCharacterIdName(characterName);
    return characterId.CharacterIdItems[0].CharacterId;
}
```