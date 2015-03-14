# Introduction #

A list of all of the changes to the API is found here since version 1.0.0.

## 1.1.2 - 1/28/2008 ##
  * Fixed FuelListItem.TypeId which was left as a string, which should have been an int like all other TypeId's.  This was inside the StarbaseDetail.cs file.

## 1.1.1 - 1/28/2008 ##
  * Localization issues have been fixed. (Bug Reporter: Amida Ta)

## 1.1 - 1/27/2008 ##
  * All public member variables have been replaced with properties.
  * updated XML file to fix invalid comments

## 1.0.2 - 1/25/2008 ##
  * With this version it is now possible to override the API and request old cached data.  Normally the API would only serve the cache data if it was before the cacheUntil value, at this point you could request a new version.  You can send along a bool value with any API function called ignoreCacheUntil, and the api will return the latest cached data that is has.  This should normally be called if the first call is made and a network exception is thrown so the newest api data can not be accessed.
  * Updated characterList to use properties instead of public data.

## 1.0.1 - 1/20/2008 ##
  * A minor revision to the industry job list.  Enums are now used for ActivityID which determines which activity is currently happening with the job.  This is used in addition to the integer value provided.  Also an enum for IndustryJobCompletedStatuses has been created to better manage what was the completed state of the object.

## 1.0.0 - 1/20/2008 ##
  * The 1.0 release is now out and should be stable, and implement all off the different EVE Api items, along with caching.
  * Proxy Server support has now been added.