using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;

namespace libeveapi
{
    /// <summary>
    /// Represents a character name and  CharacterID response from the eve api
    /// http://wiki.eve-dev.net/APIv2_Eve_CharacterID_XML
    /// </summary>
    public class CharacterID : ApiResponse
    {
        /// <summary>
        /// The character name and character id that are associated with eachother
        /// </summary>
        public CharacterIDItem[] CharacterIDItems = new CharacterIDItem[0];

        /// <summary>
        /// Returns the characterID and character name that are associated with eachother
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static CharacterID FromXmlDocument(XmlDocument xmlDoc)
        {
            //FIX the row:name problem here (HACK!)
            string fixXML = xmlDoc.OuterXml;
            fixXML = Regex.Replace(fixXML, "row:name", "row");
            xmlDoc.LoadXml(fixXML);
            //END FIX

            //REAL FIX - We're not using this because if they change then this will break -
            /* XmlNamespaceManager namespaceManager = new XmlNamespaceManager( xmlDoc.NameTable);
             * namespaceManager.AddNamespace("row", "characterID");
             * XmlNode n = d.SelectSingleNode("//rowset[@name='characters']/row:name", namespaceManager);
             * Console.WriteLine(n.Attributes["name"].InnerText + " " + n.Attributes["characterID"].InnerText)
             */

            CharacterID charID = new CharacterID();
            charID.ParseCommonElements(xmlDoc);

            List<CharacterIDItem> characterList = new List<CharacterIDItem>();
            foreach (XmlNode charIDRow in xmlDoc.SelectNodes("//rowset[@name='characters']/row"))
            {
                CharacterIDItem charIDItem = new CharacterIDItem();
                charIDItem.name = charIDRow.Attributes["name"].InnerText;
                charIDItem.characterID = Convert.ToInt32(charIDRow.Attributes["characterID"].InnerText);
                characterList.Add(charIDItem);
            }
            charID.CharacterIDItems = characterList.ToArray();

            return charID;
        }
    }

    /// <summary>
    /// An charIDItem associated with a character or corporation
    /// </summary>
    public class CharacterIDItem
    {
        /// <summary>
        /// The character's name
        /// </summary>
        public string name;

        /// <summary>
        /// The characterID for the character name
        /// </summary>
        public int characterID;

    }

}
