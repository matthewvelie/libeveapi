# Introduction #
This API is used to access all of the assets that a the character has spread throughout the universe.

## URLS ##
/char/AssetList.xml.aspx

## Overview ##
Information about the API Calls

| **Key** | **Data** |
|:--------|:---------|
| API Version | 2 |
| Cache Timing | Long |
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
| version | int | Required to be "2" |

## Output ##
The information below describes the output information produced by the EVE API

### Sample XML ###
```
<?xml version='1.0' encoding='UTF-8'?>
<eveapi version="1">
  <currentTime>2007-12-01 17:55:07</currentTime>
  <result>
    <rowset name="assets" key="itemID" columns="itemID,locationID,typeID,quantity,flag,singleton">
      <row itemID="150354641" locationID="30000380" typeID="11019" quantity="1" flag="0" singleton="1">
        <rowset name="contents" key="itemID" columns="itemID,typeID,quantity,flag,singleton">
          <row itemID="150354709" typeID="16275" quantity="200000" flag="5" singleton="0" />
          <row itemID="150354710" typeID="16272" quantity="150000" flag="5" singleton="0" />
          <row itemID="150354711" typeID="16273" quantity="150000" flag="5" singleton="0" />
          <row itemID="150354712" typeID="24597" quantity="1000" flag="5" singleton="0" />
          <row itemID="150354713" typeID="24596" quantity="1000" flag="5" singleton="0" />
          <row itemID="150354714" typeID="24595" quantity="1000" flag="5" singleton="0" />
          <row itemID="150354715" typeID="24594" quantity="1000" flag="5" singleton="0" />
          <row itemID="150354716" typeID="24593" quantity="1000" flag="5" singleton="0" />
          <row itemID="150354717" typeID="24592" quantity="1000" flag="5" singleton="0" />
          <row itemID="150354718" typeID="16274" quantity="450000" flag="5" singleton="0" />
          <row itemID="150354719" typeID="9848" quantity="1000" flag="5" singleton="0" />
          <row itemID="150354720" typeID="9832" quantity="8000" flag="5" singleton="0" />
          <row itemID="150354721" typeID="3689" quantity="5000" flag="5" singleton="0" />
          <row itemID="150354722" typeID="3683" quantity="25000" flag="5" singleton="0" />
          <row itemID="150354723" typeID="44" quantity="4000" flag="5" singleton="0" />
        </rowset>
      </row>
      <row itemID="150354706" locationID="30001984" typeID="11019" quantity="1" flag="0" singleton="1">
        <rowset name="contents" key="itemID" columns="itemID,typeID,quantity,flag,singleton">
          <row itemID="150354741" typeID="24593" quantity="400" flag="5" singleton="0" />
          <row itemID="150354742" typeID="24592" quantity="400" flag="5" singleton="0" />
          <row itemID="150354755" typeID="16275" quantity="199000" flag="5" singleton="0" />
          <row itemID="150354837" typeID="24597" quantity="400" flag="5" singleton="0" />
          <row itemID="150354838" typeID="24596" quantity="400" flag="5" singleton="0" />
          <row itemID="150354839" typeID="24595" quantity="400" flag="5" singleton="0" />
          <row itemID="150354840" typeID="24594" quantity="400" flag="5" singleton="0" />
          <row itemID="150356329" typeID="14343" quantity="1" flag="5" singleton="0" />
        </rowset>
      </row>
      <row itemID="150212056" locationID="60001078" typeID="25851" quantity="10" flag="4" singleton="0" />
      <row itemID="150212057" locationID="60001078" typeID="20424" quantity="20" flag="4" singleton="0" />
      <row itemID="150212058" locationID="60001078" typeID="20421" quantity="20" flag="4" singleton="0" />
      <row itemID="150357641" locationID="30001984" typeID="23" quantity="1" flag="0" singleton="1">
        <rowset name="contents" key="itemID" columns="itemID,typeID,quantity,flag,singleton">
          <row itemID="150357740" typeID="16275" quantity="9166" flag="0" singleton="0" />
        </rowset>
      </row>
      <row itemID="150212062" locationID="60001078" typeID="944" quantity="1" flag="4" singleton="1" />
      <row itemID="150212063" locationID="60001078" typeID="597" quantity="1" flag="4" singleton="0" />
    </rowset>
  </result>
  <cachedUntil>2007-12-02 16:55:07</cachedUntil>
</eveapi>
```
### Rowset Columns ###
| **Name** | **Type** | **Description** |
|:---------|:---------|:----------------|
| itemID | int | Unique ID for this item. This is only guaranteed to be unique within this page load. IDs are recycled over time and it is possible for this to happen. Also, items are not guaranteed to maintain the same itemID over time. When they are repackaged, stacks are split or merged, when they're assembled, and other actions can cause itemIDs to change.  |
| locationID | int | References a solar system or station. **Note** that this column is not present in the sub-asset lists, i.e. for things inside of other things.  |
| typeID | int | The type of this item. References the [invTypes](invTypes.md) table.  |
| quantity | int | How many items are in this stack.  |
| flag | int | Indicates something about this item's storage location. The flag is used to differentiate between hangar divisions, drone bay, fitting location, and similar. Please see the [Inventory Flags](InventoryFlags.md) documentation.  |
| singleton | boolean | If true, indicates that this item is a singleton. This means that the item is not packaged.  |

## Notes ##
  * This will allow you to see everything, including items installed at POS's, inside containers and fitted to your ship.
  * This is unable to give you the name of the container that has the items in it, just where the container is currently located at.

## libEveApi Reference ##
Link To library reference