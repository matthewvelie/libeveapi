using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;

namespace libeveapi
{
    /// <summary>
    /// Represents a character name and  CharacterId response from the eve api
    /// http://wiki.eve-dev.net/APIv2_Eve_CharacterID_XML
    /// </summary>
    public class CharacterIdName : ApiResponse
    {
        /// <summary>
        /// The character name and character id that are associated with eachother
        /// </summary>
        public CharacterIdNameItem[] CharacterIdItems = new CharacterIdNameItem[0];

        /// <summary>
        /// Returns the characterId and character name that are associated with eachother
        /// </summary>
        /// <param name="xmlDoc">An XML Document containing characterId and character name information</param>
        /// <returns><see cref="CharacterIdName"/></returns>
        public static CharacterIdName FromXmlDocument(XmlDocument xmlDoc)
        {
            //FIX the row:name problem here (HACK!)
            string fixXML = xmlDoc.OuterXml;
            fixXML = Regex.Replace(fixXML, "row:name", "row");
            xmlDoc.LoadXml(fixXML);
            //END FIX

            //REAL FIX - We're not using this because if they change then this will break -
            /* XmlNamespaceManager namespaceManager = new XmlNamespaceManager( xmlDoc.NameTable);
             * namespaceManager.AddNamespace("row", "characterId");
             * XmlNode n = d.SelectSingleNode("//rowset[@name='characters']/row:name", namespaceManager);
             * Console.WriteLine(n.Attributes["name"].InnerText + " " + n.Attributes["characterID"].InnerText)
             */

            CharacterIdName charId = new CharacterIdName();
            charId.ParseCommonElements(xmlDoc);

            List<CharacterIdNameItem> characterList = new List<CharacterIdNameItem>();
            foreach (XmlNode charIdRow in xmlDoc.SelectNodes("//rowset[@name='characters']/row"))
            {
                CharacterIdNameItem charIdItem = new CharacterIdNameItem();
                charIdItem.Name = charIdRow.Attributes["name"].InnerText;
                charIdItem.CharacterId = Convert.ToInt32(charIdRow.Attributes["characterID"].InnerText);
                characterList.Add(charIdItem);
            }
            charId.CharacterIdItems = characterList.ToArray();

            return charId;
        }

        /// <summary>
        /// An charIdItem associated with a character or corporation
        /// </summary>
        public class CharacterIdNameItem
        {
            /// <summary>
            /// The character's name
            /// </summary>
            public string Name;

            /// <summary>
            /// The characterId for the character name
            /// </summary>
            public int CharacterId;

        }
    }
}
