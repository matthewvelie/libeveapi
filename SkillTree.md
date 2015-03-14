### Description ###
Retrieves information about every character skill.

### Library Method ###
```
/// <summary>
/// Gets a data structure containing information on every skill in the game.
/// </summary>
/// <returns></returns>
public static SkillTree GetSkillTree()
```

### Result ###
**SkillTree class (See ApiResponse for inherited members)**| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| Skills | Skill[.md](.md) | List of all skills |
| SkillGroups | SkillGroup[.md](.md) | List of skill category groups |

**SkillTree.Skill class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| TypeName | string | Name of the skill |
| GroupId | int | Unique identifier for the group this skill belongs to |
| TypeId | int | Unique identifier for this skill type |
| Description | string | information about the skill |
| Rank | int | The training time multiplier of the skill |
| RequiredSkills | RequiredSkill[.md](.md) | The skills required to train this skill |
| PrimaryAttribute | AttributeType | The attrbute that has the most effect on the amount of time required to train this skill. |
| SecondaryAttribute | AttributeType | The attribute that has the second most effect of the amount of time required to train this skill. |
| SkillBonuses | SkillBonus[.md](.md) | The bonuses gained from training this skill. |

**SkillTree.RequiredSkill class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| TypeId | int | The unique identifier of this skill type. |
| SkillLevel | int | This skill level is required to train the parent skill. |

**SkillTree.SkillGroup class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| GroupName | string | The name of this skill group. |
| GroupId | int | The unique identifier for this skill group. |

**SkillTree.SkillBonus class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| BonusType | string | Description of the bonus |
| BonusValue | double | The amount of bonus gained from each level of the skill trained. |

**SkillTree.AttributeType enumeration**
| Member | Value | Description |
|:-------|:------|:------------|
| Memory | - | Memory attribute |
| Intelligence| - | Intelligence attribute |
| Perception| - | Perception attribute |
| Charisma| - | Charisma attribute |
| Unknown| - | Unknown attribute (shouldn't ever show up) |

### Example ###
```
/// <summary>
/// Display a skill and its required skills
/// </summary>
public static void SkillTreeExample()
{
    SkillTree skillTree = EveApi.GetSkillTree();

    // Get skill 3344 and display its name
    SkillTree.Skill targetSkill = GetSkillByTypeId(3344, skillTree);
    Console.WriteLine("Skill Name: {0}", targetSkill.TypeName);

    // Display the name and level of each required skill
    foreach (SkillTree.RequiredSkill requiredSkill in targetSkill.RequiredSkills)
    {
        SkillTree.Skill requiredSkillInfo = GetSkillByTypeId(requiredSkill.TypeId, skillTree);
        Console.WriteLine("Required Skill: {0} Level: {1}", requiredSkillInfo.TypeName, requiredSkill.SkillLevel);
    }
}

/// <summary>
/// Find a Skill in the SkillTree by TypeId
/// </summary>
/// <param name="typeId"></param>
/// <param name="skillTree"></param>
/// <returns></returns>
private static SkillTree.Skill GetSkillByTypeId(int typeId, SkillTree skillTree)
{
    foreach (SkillTree.Skill skill in skillTree.Skills)
    {
        if (skill.TypeId == typeId)
        {
            return skill;
        }
    }

    return null;
}
```