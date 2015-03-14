# Introduction #
This API is used to access the balance of a character's wallet.  Character's will only have one wallet, whose !accountKey is 1000.

## URLS ##
/char/AccountBalance.xml.aspx

## Overview ##
Information about the API Calls

| **Key** | **Data** |
|:--------|:---------|
| API Version | 1 |
| Cache Timing | Short |
| Authorization | Full |

| **Type Of Access Key** | **Supported** |
|:-----------------------|:--------------|
| Character | Yes |
| Corporation | Yes |
| Global | No |

# Details #

Long description of the stuff here

## Input ##
| **Name** | **Type** | **Description** |
|:---------|:---------|:----------------|
| userID | int | EVE generated userID for the account  |
| characterID | int | The EVE generated characterID for the specific character on the account you would like to access |
| apiKey | string | The Full API Key for the account |

## Output ##
The information below describes the output information produced by the EVE API

### Sample XML ###
```
<?xml version='1.0' encoding='UTF-8'?>
<eveapi version="2">
  <currentTime>2007-12-16 11:55:31</currentTime>
  <result>
    <rowset name="accounts" key="accountID" columns="accountID,accountKey,balance">
      <row accountID="4807144" accountKey="1000" balance="209127823.31" />
    </rowset>
  </result>
  <cachedUntil>2007-12-16 12:10:31</cachedUntil>
</eveapi>

```
### Rowset Columns ###
| **Name** | **Type** | **Description** |
|:---------|:---------|:----------------|
| accountID | int | The EVE generated AccountID |
| accountKey | int | The account (wallet) identifier, always 1000 for characters |
| balance | double | The amount of ISK that the character has in that wallet |

## libEveApi Reference ##
Link To library reference