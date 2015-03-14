# Introduction #


## URLS ##
IndustryJobs.xml.aspx

## Overview ##


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

Contains the industrial activities of the character

## Input ##
| **Name** | **Type** | **Description** |
|:---------|:---------|:----------------|
| UserID | int | The character's userID |
| apiKey | string | The character's full API Key |
| characterId | int | The character's characterId |


## Output ##
Output contains detailed information about the item that is in the job, where it was and where it will be placed after.

### Sample XML ###
```
<?xml version='1.0' encoding='UTF-8'?>
<eveapi version="1">
  <currentTime>2007-12-01 12:10:48</currentTime>
  <result>
    <rowset name="jobs" key="jobID" columns="jobID,containerID,installedItemID,installedItemLocationID,installedItemQuantity,installedItemProductivityLevel,installedItemMaterialLevel,installedItemLicensedProductionRunsRemaining,outputLocationID,installerID,runs,licensedProductionRuns,installedInSolarSystemID,containerLocationID,materialMultiplier,charMaterialMultiplier,timeMultiplier,charTimeMultiplier,installedItemTypeID,outputTypeID,containerTypeID,installedItemCopy,completed,completedSuccessfully,installedItemFlag,outputFlag,activityID,completedStatus,installTime,beginProductionTime,endProductionTime,pauseProductionTime">
      <row jobID="444" containerID="60010783" installedItemID="150438239" installedItemLocationID="60010783" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="300" outputLocationID="60010783" installerID="150208955" runs="1" licensedProductionRuns="10" installedInSolarSystemID="30004969" containerLocationID="30004969" materialMultiplier="-4" charMaterialMultiplier="1" timeMultiplier="-4" charTimeMultiplier="1" installedItemTypeID="1079" outputTypeID="1080" containerTypeID="3869" installedItemCopy="1" completed="0" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="8" completedStatus="0" installTime="2007-11-30 11:59:00" beginProductionTime="2007-11-30 11:59:00" endProductionTime="2007-11-30 14:29:00" pauseProductionTime="0001-01-01 00:00:00" />
      <row jobID="443" containerID="60010783" installedItemID="150438148" installedItemLocationID="60010783" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="300" outputLocationID="60010783" installerID="150208955" runs="1" licensedProductionRuns="14" installedInSolarSystemID="30004969" containerLocationID="30004969" materialMultiplier="-5" charMaterialMultiplier="1" timeMultiplier="-2" charTimeMultiplier="1" installedItemTypeID="1079" outputTypeID="1080" containerTypeID="3869" installedItemCopy="1" completed="0" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="8" completedStatus="0" installTime="2007-11-30 11:55:00" beginProductionTime="2007-11-30 11:55:00" endProductionTime="2007-11-30 14:25:00" pauseProductionTime="0001-01-01 00:00:00" />
      <row jobID="442" containerID="60010783" installedItemID="150441912" installedItemLocationID="60010783" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="-1" outputLocationID="60010783" installerID="150208955" runs="10" licensedProductionRuns="277" installedInSolarSystemID="30004969" containerLocationID="30004969" materialMultiplier="1" charMaterialMultiplier="1" timeMultiplier="1" charTimeMultiplier="1.5" installedItemTypeID="3243" outputTypeID="3243" containerTypeID="3869" installedItemCopy="0" completed="0" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="5" completedStatus="0" installTime="2007-11-30 11:41:00" beginProductionTime="2007-11-30 11:41:00" endProductionTime="2007-12-02 09:51:00" pauseProductionTime="0001-01-01 00:00:00" />
     <row jobID="394" containerID="60002269" installedItemID="150361975" installedItemLocationID="60002269" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="300" outputLocationID="60002269" installerID="150208955" runs="1" licensedProductionRuns="10" installedInSolarSystemID="30000178" containerLocationID="30000178" materialMultiplier="-4" charMaterialMultiplier="1" timeMultiplier="-4" charTimeMultiplier="1" installedItemTypeID="3243" outputTypeID="3245" containerTypeID="1529" installedItemCopy="1" completed="1" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="8" completedStatus="1" installTime="2007-08-15 18:50:00" beginProductionTime="2007-08-15 18:50:00" endProductionTime="2007-08-15 18:50:00" pauseProductionTime="0001-01-01 00:00:00" />
      <row jobID="393" containerID="60002269" installedItemID="150361974" installedItemLocationID="60002269" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="300" outputLocationID="60002269" installerID="150208955" runs="1" licensedProductionRuns="10" installedInSolarSystemID="30000178" containerLocationID="30000178" materialMultiplier="-4" charMaterialMultiplier="1" timeMultiplier="-4" charTimeMultiplier="1" installedItemTypeID="3243" outputTypeID="3245" containerTypeID="1529" installedItemCopy="1" completed="1" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="8" completedStatus="1" installTime="2007-08-15 18:50:00" beginProductionTime="2007-08-15 18:50:00" endProductionTime="2007-08-15 18:53:00" pauseProductionTime="0001-01-01 00:00:00" />
      <row jobID="392" containerID="60002269" installedItemID="150361823" installedItemLocationID="60002269" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="-1" outputLocationID="60002269" installerID="150208955" runs="100" licensedProductionRuns="0" installedInSolarSystemID="30000178" containerLocationID="30000178" materialMultiplier="1" charMaterialMultiplier="1" timeMultiplier="1" charTimeMultiplier="0.8" installedItemTypeID="1177" outputTypeID="262" containerTypeID="1529" installedItemCopy="0" completed="1" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="1" completedStatus="1" installTime="2007-08-15 18:36:00" beginProductionTime="2007-08-15 18:36:00" endProductionTime="2007-08-16 01:16:00" pauseProductionTime="0001-01-01 00:00:00" />
      <row jobID="391" containerID="60002269" installedItemID="150361822" installedItemLocationID="60002269" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="-1" outputLocationID="60002269" installerID="150208955" runs="100" licensedProductionRuns="0" installedInSolarSystemID="30000178" containerLocationID="30000178" materialMultiplier="1" charMaterialMultiplier="1" timeMultiplier="1" charTimeMultiplier="0.8" installedItemTypeID="1170" outputTypeID="255" containerTypeID="1529" installedItemCopy="0" completed="1" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="1" completedStatus="1" installTime="2007-08-15 18:36:00" beginProductionTime="2007-08-15 18:36:00" endProductionTime="2007-08-16 01:16:00" pauseProductionTime="0001-01-01 00:00:00" />
      <row jobID="390" containerID="60002269" installedItemID="150361821" installedItemLocationID="60002269" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="-1" outputLocationID="60002269" installerID="150208955" runs="100" licensedProductionRuns="0" installedInSolarSystemID="30000178" containerLocationID="30000178" materialMultiplier="1" charMaterialMultiplier="1" timeMultiplier="1" charTimeMultiplier="0.8" installedItemTypeID="1151" outputTypeID="236" containerTypeID="1529" installedItemCopy="0" completed="1" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="1" completedStatus="1" installTime="2007-08-15 18:36:00" beginProductionTime="2007-08-15 18:36:00" endProductionTime="2007-08-15 18:47:00" pauseProductionTime="0001-01-01 00:00:00" />
      <row jobID="389" containerID="60002269" installedItemID="150361820" installedItemLocationID="60002269" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="-1" outputLocationID="60002269" installerID="150208955" runs="100" licensedProductionRuns="0" installedInSolarSystemID="30000178" containerLocationID="30000178" materialMultiplier="1" charMaterialMultiplier="1" timeMultiplier="1" charTimeMultiplier="0.8" installedItemTypeID="11203" outputTypeID="11202" containerTypeID="1529" installedItemCopy="0" completed="1" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="1" completedStatus="1" installTime="2007-08-15 18:36:00" beginProductionTime="2007-08-15 18:36:00" endProductionTime="2007-09-07 22:09:00" pauseProductionTime="0001-01-01 00:00:00" />
      <row jobID="388" containerID="60002269" installedItemID="150361886" installedItemLocationID="60002269" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="-1" outputLocationID="60002269" installerID="150208955" runs="20" licensedProductionRuns="300" installedInSolarSystemID="30000178" containerLocationID="30000178" materialMultiplier="1" charMaterialMultiplier="1" timeMultiplier="1" charTimeMultiplier="1.5" installedItemTypeID="3243" outputTypeID="3243" containerTypeID="1529" installedItemCopy="0" completed="1" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="5" completedStatus="1" installTime="2007-08-15 18:35:00" beginProductionTime="2007-08-15 18:35:00" endProductionTime="2007-08-15 18:47:00" pauseProductionTime="0001-01-01 00:00:00" />
      <row jobID="200" containerID="60001078" installedItemID="150212062" installedItemLocationID="60001078" installedItemQuantity="1" installedItemProductivityLevel="0" installedItemMaterialLevel="0" installedItemLicensedProductionRunsRemaining="-1" outputLocationID="60001078" installerID="150208955" runs="1" licensedProductionRuns="1" installedInSolarSystemID="30001644" containerLocationID="30001644" materialMultiplier="1" charMaterialMultiplier="1" timeMultiplier="1" charTimeMultiplier="1.5" installedItemTypeID="944" outputTypeID="944" containerTypeID="1529" installedItemCopy="0" completed="1" completedSuccessfully="0" installedItemFlag="4" outputFlag="4" activityID="5" completedStatus="1" installTime="2006-11-01 18:18:00" beginProductionTime="2006-11-01 18:18:00" endProductionTime="2006-11-01 19:58:00" pauseProductionTime="0001-01-01 00:00:00" />
    </rowset>
  </result>
  <cachedUntil>2007-12-01 12:25:48</cachedUntil>
</eveapi>
```
### Rowset Columns ###
| **Name** | **Type** | **Description** |
|:---------|:---------|:----------------|
| jobID |  |   |
| containerID |  |   |
| installedItemID |  |   |
| installedItemLocationID |  |   |
| installedItemQuantity |  |   |
| installedItemProductivityLevel |  |   |
| installedItemMaterialLevel |  |   |
| installedItemLicensedProductionRunsRemaining |  |   |
| outputLocationID |  |   |
| installerID |  |   |
| runs |  |   |
| licensedProductionRuns |  |   |
| installedInSolarSystemID |  |   |
| containerLocationID |  |  |
| materialMultiplier |  |  |
| charMaterialMultiplier |  |  |
| timeMultiplier |  |  |
| charTimeMultiplier |  |  |
| installedItemTypeID |  |  |
| outputTypeID |  |  |
| containerTypeID |  |  |
| installedItemCopy |  |  |
| completed |  |  |
| completedSuccessfully |  |  |
| installedItemFlag |  |  |
| outputFlag |  |  |
| activityID |  |  |
| completedStatus |  |  |
| installTime | datetime  |  |
| beginProductionTime | datetime  |  |
| endProductionTime | datetime  |  |
| pauseProductionTime | datetime |  |

## libEveApi Reference ##
Link To library reference