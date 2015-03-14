# Introduction #
This API is used to find the different characters that are available on the account.

## URLS ##
/char/Characters.xml.aspx

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

Most all of the different API Calls require a character ID to be present.  This information is hard for the user to easily be able to determine; while they should know their character name, they will most likely not know the character ID.  This xml file will provide you with the list of the character names, along with their ID's.  At maximum the file will contain three rows of data, as there is a limit of three characters per account.

## Input ##
| **Name** | **Type** | **Description** |
|:---------|:---------|:----------------|
| userID | int | EVE generated userID for the account  |
| characterID | int | The EVE generated characterID for the specific character on the account you would like to access |

## Output ##
The information below describes the output information produced by the EVE API

### Sample XML ###
```
<?xml version='1.0' encoding='UTF-8'?>
<eveapi version="1">
  <currentTime>2007-12-12 11:48:50</currentTime>
  <result>
    <rowset name="characters" key="characterID" columns="name,characterID,corporationName,corporationID">
      <row name="Mary" characterID="150267069"
           corporationName="Starbase Anchoring Corp" corporationID="150279367" />
      <row name="Marcus" characterID="150302299"
           corporationName="Marcus Corp" corporationID="150333466" />
      <row name="Dieinafire" characterID="150340823"
           corporationName="Center for Advanced Studies" corporationID="1000169" />
    </rowset>
  </result>
  <cachedUntil>2007-12-12 12:48:50</cachedUntil>
</eveapi>
```

### Rowset Columns ###
| **Name** | **Type** | **Description** |
|:---------|:---------|:----------------|
| name | string | name of the character |
| characterID | int | The EVE generated characterID belonging to the character |
| corporationName | string | The name of the corporation that the character belongs to |
| corporationID | int | The EVE generated ID of the corporation that the character belongs to |

## libEveApi Reference ##
Link To library reference