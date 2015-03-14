## Documentation ##
The [Documentation](Documentation.md) page contains detailed descriptions and examples of all library functions.

## General Setup ##
  * Download and extract the library, be sure to keep the .XML file with the .DLL file. This will enable extended intellisense information which makes using the library a whole lot easier.
  * In your application project, add a reference to the .DLL file

## Important ##
**During development you should get your XML responses from a local web server instead of the eve api. [Here's how to set it up](UrlConstants.md).**

## Using the Library ##
  1. Add a using directive at the top of the file
```
using libeveapi;
```
  1. Load the ResponseCache from a file before making any API calls.  This is used when the program shuts down, so all responses will still be cached when the program restarts.
```
string responseCacheFilename = "ResponseCache.xml";
if (File.exists(responseCacheFilename ))
{
    ResponseCache.LoadFromFile(responseCacheFilename )
}
```
  1. Make an API call. If there is a valid (not expired) cached version of the response then that version will be returned automatically. If there is no cached version, or the cached version is no longer valid then a network call to the eve api will be made and the response will be cached.
```
// GetAccountCharacters(userId, apiKey)
CharacterList characterList = EveApi.GetAccountCharacters(123, "apiKey");
```
  1. Save the ResponseCache to a file before exiting the application.
```
ResponseCache.SaveToFile(responseCacheFilename);
```