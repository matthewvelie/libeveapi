# Introduction #
This page will give you all the information needed about your character.  Race, bloodline, etc, along with implant information, and skills that have been trained.

## URLS ##
CharacterSheet.xml.aspx

## Overview ##
Information about the API Calls

| **Key** | **Data** |
|:--------|:---------|
| API Version | 1 |
| Cache Timing | Short |
| Authorization | Limited |

| **Type Of Access Key** | **Supported** |
|:-----------------------|:--------------|
| Character | Yes |
| Corporation | No |
| Global | No |

# Details #

Long description of the stuff here

## Input ##
| **Name** | **Type** | **Description** |
|:---------|:---------|:----------------|
| userID | int | The userID for the account being checked. |
| apiKey | char(64) | This is the limited api key for the userID |
| characterID | int | The characterID provided from the character list. |

## Output ##
The information below describes the output information produced by the EVE API

### Sample XML ###
```
<eveapi version="1">
  <currentTime>2007-06-18 22:49:01</currentTime>
  <result>
    <characterID>150337897</characterID>
    <name>corpslave</name>
    <race>Minmatar</race>
    <bloodLine>Brutor</bloodLine>
    <gender>Female</gender>
    <corporationName>corpexport Corp</corporationName>
    <corporationID>150337746</corporationID>
    <balance>190210393.87</balance>
    <attributeEnhancers>
      <intelligenceBonus>
        <augmentatorName>Snake Delta</augmentatorName>
        <augmentatorValue>3</augmentatorValue>
      </intelligenceBonus>
      <memoryBonus>
        <augmentatorName>Halo Beta</augmentatorName>
        <augmentatorValue>3</augmentatorValue>
      </memoryBonus>
    </attributeEnhancers>
    <attributes>
      <intelligence>6</intelligence>
      <memory>4</memory>
      <charisma>7</charisma>
      <perception>12</perception>
      <willpower>10</willpower>
    </attributes>
    <rowset name="skills" key="typeID">
      <row typeID="3431" level="3" skillpoints="8000"/>
      <row typeID="3413" level="3" skillpoints="8000"/>
      <row typeID="21059" level="1" skillpoints="500"/>
      <row typeID="3416" level="3" skillpoints="8000"/>
      <row typeID="3445" unpublished="1" skillpoints="277578" />
    </rowset>
  </result>
  <cachedUntil>2007-06-18 23:49:01</cachedUntil>
</eveapi>
```
### Rowset Columns ###
| **Name** | **Type** | **Description** |
|:---------|:---------|:----------------|
| characterID | int | The characterID that the data belongs to |
| name | string | The character's name |
| race | string | The character's race |
| bloodLine | string | The bloodline of the character |
| gender | string | The gender of the character |
| corporationName | string | The name of the corporation the character is a part of |
| corporationID | int | The Id of the corporation the character is a part of |
| balance | double | The wallet balance of the character |
| augmentatorName | string | The name of the implant.  There can be multiple implants. |
| augmentatorValue | int | The increase in that attribute, always a whole number from the implant |
| attributes (intelligence, etc) | int | The current value (without skills or implants) of that attribute |
| typeID | int | The typeId of that skill |
| level | int | The highest level completed |
| skillpoints | int | The current number of skillpoints |
| unpublished | int | This field will only be shown if it is unpublished, and it will be set to 1 |


## libEveApi Reference ##
Link To library reference