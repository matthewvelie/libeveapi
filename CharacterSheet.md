### Description ###
Retrieves detailed information about a character including attributes, implants and skills.

### Library Method ###
```
/// <summary>
/// Returns a detailed description of a character
/// </summary>
/// <param name="userId">userId of account for authentication</param>
/// <param name="characterId">CharacterId of character for authentication</param>
/// <param name="apiKey">Limited access API key of account</param>
/// <returns></returns>
public static CharacterSheet GetCharacterSheet(int userId, int characterId, string apiKey)
```

### Result ###
**CharacterSheet class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| CharacterId | int | The eve assigned characterId |
| Name | string | The name of the character |
| Race | string | The race of the character |
| BloodLine | string | The bloodline of the character |
| Gender | string | The gender of the character (currently male/female) |
| CorporationName | string | The name of the character's corporation |
| CorporationId | int | The eve generated id of the character's corporation |
| Balance | double | The character's current wallet balance |
| Intelligence | int | The character's intelligence attribute |
| Memory | int | The character's memory attribute |
| Charisma | int | The character's charisma attribute |
| Perception | int | The character's perception attribute |
| Willpower | int | The characters willpower attribute |
| MemoryBonus | AttributeEnhancer | Memory implant |
| WillpowerBonus| AttributeEnhancer | Willpower implant |
| PerceptionBonus| AttributeEnhancer | Perception implant |
| IntelligenceBonus| AttributeEnhancer | Intelligence implant |
| CharismaBonus| AttributeEnhancer | Charisma implant |
| SkillItemList | SkillItem[.md](.md) | List of character's skills |

**CharacterSheet.AttributeEnhancer class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| Name | string | The name of the implant |
| Value | int | The implant's attribute modifier value |

**CharacterSheet.SkillItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| TypeId | int | Unique identifier for this skill type |
| Skillpoints | long | Character's current number of skillpoints in the skill |
| Level | int | The highest completed level of the skill |
| Unpublished | string | Flag if the skill is an unpublished skill |

### Example ###
```
public static void CharacterSheetExample()
{
    CharacterSheet characterSheet = EveApi.GetCharacterSheet(123, 456, "apiKey");
    
    long totalSkillpoints = 0;
    foreach (CharacterSheet.SkillItem skillItem in characterSheet.SkillItemList)
    {
        totalSkillpoints += skillItem.Skillpoints;
    }

    Console.WriteLine("Character Name: {0} Total Skillpoints: {1}", characterSheet.Name, totalSkillpoints);
}
```