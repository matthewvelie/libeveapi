using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
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
        /// <param name="xmlDoc">An XML Document containing information about the Character List</param>
        /// <returns><see cref="CharacterList"/></returns>
        public static CharacterList FromXmlDocument(XmlDocument xmlDoc)
        {
            CharacterList characterList = new CharacterList();
            characterList.ParseCommonElements(xmlDoc);

            List<CharacterListItem> parsedCharacters = new List<CharacterListItem>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='characters']/row"))
            {
                CharacterListItem character = new CharacterListItem();
                character.Name = row.Attributes["name"].InnerText;
                character.CharacterId = Convert.ToInt32(row.Attributes["characterID"].InnerText, CultureInfo.InvariantCulture);
                character.CorporationName = row.Attributes["corporationName"].InnerText;
                character.CorporationId = Convert.ToInt32(row.Attributes["corporationID"].InnerText, CultureInfo.InvariantCulture);
                parsedCharacters.Add(character);
            }
            characterList.CharacterListItems = parsedCharacters.ToArray();

            return characterList;
        }

        /// <summary>
        /// Represents a character from the account character list
        /// </summary>
        public class CharacterListItem
        {
            private string name;
            private int characterId;
            private string corporationName;
            private int corporationId;

            /// <summary>
            /// Name of the character
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            /// <summary>
            /// Id of the character
            /// </summary>
            public int CharacterId
            {
                get { return characterId; }
                set { characterId = value; }
            }

            /// <summary>
            /// Name of the corporation the character is a member of
            /// </summary>
            public string CorporationName
            {
                get { return corporationName; }
                set { corporationName = value; }
            }

            /// <summary>
            /// Id of the corporation the character is a member of
            /// </summary>
            public int CorporationId
            {
                get { return corporationId; }
                set { corporationId = value; }
            }
        }
    }
}