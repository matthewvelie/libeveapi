using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// A list of characters on the account
    /// </summary>
    public class CharacterList : ApiResponse
    {
        /// <summary>
        /// List of characters associated with an account
        /// </summary>
        public CharacterListItem[] CharacterListItems = new CharacterListItem[0];

        /// <summary>
        /// Create a CharacterList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static CharacterList FromXmlDocument(XmlDocument xmlDoc)
        {
            CharacterList characterList = new CharacterList();
            characterList.ParseCommonElements(xmlDoc);

            List<CharacterListItem> parsedCharacters = new List<CharacterListItem>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='characters']/row"))
            {
                CharacterListItem character = new CharacterListItem();
                character.Name = row.Attributes["name"].InnerText;
                character.CharacterId = row.Attributes["characterID"].InnerText;
                character.CorporationName = row.Attributes["corporationName"].InnerText;
                character.CorporationId = row.Attributes["corporationID"].InnerText;
                parsedCharacters.Add(character);
            }
            characterList.CharacterListItems = parsedCharacters.ToArray();

            return characterList;
        }
    }

    /// <summary>
    /// Represents a character from the account character list
    /// </summary>
    public class CharacterListItem
    {
        /// <summary>
        /// Name of the character
        /// </summary>
        public string Name;

        /// <summary>
        /// ID of the character
        /// </summary>
        public string CharacterId;

        /// <summary>
        /// Name of the corporation the character is a member of
        /// </summary>
        public string CorporationName;

        /// <summary>
        /// ID of the corporation the character is a member of
        /// </summary>
        public string CorporationId;
    }
}
