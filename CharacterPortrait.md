### Description ###
Retrieves the character's portrait from the EVE servers

**NOTE:These images are NOT cached by the library it is up to the client application to cache the library.**

### Library Method ###
```
/// <summary>
/// Retrieve the portrait for a character
/// </summary>
/// <param name="characterId">Retrieve the portrait of the character with this id</param>
/// <param name="portraitSize">Small (64) or Large (256)</param>
/// <returns></returns>
public static Image GetCharacterPortrait(int characterId, PortraitSize portraitSize)
```

### Result ###
http://msdn2.microsoft.com/en-us/library/system.drawing.image(VS.80).aspx

### Example ###
```
using System.Drawing;

Image image = EveApi.GetCharacterPortrait(1234, PortraitSize.Small);
```