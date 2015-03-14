# 02/05/2010: We are looking for maintainers. #
If you are interested please email the project owners.

## A library for the eve-online api. ##

### What is libeveapi? ###
libeveapi is a library designed to simplify working with data from the Eve-Online API. The library handles requesting data from the api along with caching and parsing the result.

### Caching ###
Every response from the Eve-Online API includes a "cacheUntil" directive. After the first request for some data the library will transparently cache the response until the "cacheUntil" time is reached. The library manages the cache transparently. All you have to do is load the cache file when your application starts up and save it before your application shuts down.

### Security ###
libeveapi does not save any authentication information (apiKey, userID). All responses are cached using the SHA1 hash of the request url. For added security you have complete control over how the cache is saved. If you are working with sensitive data from the API then you are free to encrypt the cache in any form you choose. For more information see [Security](Security.md).

### Using the Library ###
For detailed explanations and examples see the [documentation](Documentation.md).
```
using libeveapi;

// Load the XML Responses from a local webserver during development
#if DEBUG
Constants.ApiPrefix = "http://localhost/eveapi";
#endif

// Load the ResponseCache when your application starts up.
if (File.Exists("ResponseCache.xml"))
{
    ResponseCache.LoadFromFile("ResponseCache.xml");
}
// Application startup and other stuff...

// Some time later - we need a list of all the characters on an account
// Method is GetAccountCharacters(userId, apiKey);
CharacterList characterList = EveApi.GetAccountCharacters(1234, "apiKey");
foreach (CharacterListItem character in characterList.CharacterListItems)
{
    string characterName = character.Name;
    int characterId = character.CharacterId;
    int corporationId = character.CorporationId;
    string corporationName = character.CorporationName;
}
// Application does whatever it does...

// Save the ResponseCache before exiting your application.
ResponseCache.SaveToFile("ResponseCache.xml");
```

| **API Call** | **Supported** | **Api Call** | **Supported** |
|:-------------|:--------------|:-------------|:--------------|
| [Account Balances](AccountBalances.md) | Yes | [Market Orders](MarketOrders.md) | Yes |
| [Alliance List](AllianceList.md) | Yes | [Map: Jumps](MapJumps.md) | Yes |
| [Asset List](AssetList.md) | Yes |  [Map: Kills](MapKills.md) | Yes |
| [Character List](CharacterList.md) | Yes | [Map: Sovereignty](MapSovereignty.md) | Yes |
| [Character Sheet](CharacterSheet.md) | Yes |  [Member Tracking](MemberTracking.md) | Yes |
| [Conquerable Station/Outpost List](ConquerableStationList.md) | Yes | [Character Name / ID Lookup](CharacterNameIdLookup.md) | Yes |
| [Corporation Sheet](CorporationSheet.md) | Yes |  [ID to Character Portrait](CharacterPortrait.md) | Yes |
| [Error List](ErrorList.md) | Yes | [RefTypes List](RefTypes.md) | Yes |
| [Industry Jobs](IndustryJobs.md) | Yes |  [Skill in Training](SkillInTraining.md) | Yes  |
| [Journal Entries](JournalEntries.md) | Yes | [Skill Tree](SkillTree.md) | Yes |
| [Kill Log](KillLog.md) | Yes | [Starbase (POS) Details](StarbaseDetail.md) | Yes |
| [Market / Wallet Transactions](WalletTransactions.md) | Yes | [Starbase (POS) List](StarbaseList.md) | Yes |
| [Server Status](ServerStatus.md) | Yes (SVN) | [Map: Occupancy](MapOccupancy.md) | Yes (SVN) |