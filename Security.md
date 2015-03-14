## Api Key Security ##
The library references cached responses using the SHA1 hash of their request urls. This means that no UserID, ApiKey or CharacterID is saved to the disk when you save the response cache.

## ResponseCache Encryption ##
The response cache may contain sensitive data depending on the api calls used in your application. This could be starbase locations, asset lists, member locations etc. By default the response cache is saved in plain text, however it is possible to save the cache in another format by passing in a Stream to the Save and Load methods.

```
// Save the response cache using an external stream
using (Stream s = new FileStream("ResponseCache.xml", FileMode.Create))
{
    ResponseCache.Save(s);
}

// Load the response cache using an external stream
using (Stream s = new FileStream("ResponseCache.xml", FileMode.Open))
{
    ResponseCache.Load(s);
}
```