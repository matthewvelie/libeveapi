using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Detailed information about a character
    /// </summary>
    public class CharacterSheet : ApiResponse
    {
        /// <summary>
        /// The eve assigned characterId
        /// </summary>
        public int CharacterId;
        /// <summary>
        /// The name of the character
        /// </summary>
        public string Name;
        /// <summary>
        /// The race of the character
        /// </summary>
        public string Race;
        /// <summary>
        /// The bloodline of the character
        /// </summary>
        public string BloodLine;
        /// <summary>
        /// The gender of the character (currently male/female)
        /// </summary>
        public string Gender;
        /// <summary>
        /// The name of the corporation that the character is in
        /// </summary>
        public string CorporationName;
        /// <summary>
        /// The eve generated Id of the corporation
        /// </summary>
        public int CorporationId;
        /// <summary>
        /// The character's current wallet balance
        /// </summary>
        public double Balance;

        /// <summary>
        /// The character's intelligence attribute
        /// </summary>
        public int Intelligence;
        /// <summary>
        /// The character's memory attribute
        /// </summary>
        public int Memory;
        /// <summary>
        /// The character's charisma attribute
        /// </summary>
        public int Charisma;
        /// <summary>
        /// The character's perception attribute
        /// </summary>
        public int Perception;
        /// <summary>
        /// The character's willpower attribute
        /// </summary>
        public int Willpower;

        /// <summary>
        /// Memory Implant
        /// </summary>
        public AttributeEnhancer MemoryBonus = new AttributeEnhancer();
        /// <summary>
        /// Willpower Implant
        /// </summary>
        public AttributeEnhancer WillpowerBonus = new AttributeEnhancer();
        /// <summary>
        /// Perception Implant
        /// </summary>
        public AttributeEnhancer PerceptionBonus = new AttributeEnhancer();
        /// <summary>
        /// Intelligence Implant
        /// </summary>
        public AttributeEnhancer IntelligenceBonus = new AttributeEnhancer();
        /// <summary>
        /// Charisma Implant
        /// </summary>
        public AttributeEnhancer CharismaBonus = new AttributeEnhancer();

        /// <summary>
        /// The list of retrieved skills
        /// </summary>
        public SkillItem[] SkillItemList = new SkillItem[0];

        /// <summary>
        /// Create an CharacterSheet by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc">An XML Document containing the CharacterSheet</param>
        /// <returns><see cref="CharacterSheet"/></returns>
        public static CharacterSheet FromXmlDocument(XmlDocument xmlDoc)
        {
            CharacterSheet characterSheet = new CharacterSheet();
            characterSheet.ParseCommonElements(xmlDoc);

            // general info
            characterSheet.CharacterId = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/characterID").InnerText);
            characterSheet.Name = xmlDoc.SelectSingleNode("/eveapi/result/name").InnerText;
            characterSheet.Race = xmlDoc.SelectSingleNode("/eveapi/result/race").InnerText;
            characterSheet.BloodLine = xmlDoc.SelectSingleNode("/eveapi/result/bloodLine").InnerText;
            characterSheet.Gender = xmlDoc.SelectSingleNode("/eveapi/result/gender").InnerText;
            characterSheet.CorporationName = xmlDoc.SelectSingleNode("/eveapi/result/corporationName").InnerText;
            characterSheet.CorporationId = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/corporationID").InnerText);
            characterSheet.Balance = Convert.ToDouble(xmlDoc.SelectSingleNode("/eveapi/result/balance").InnerText);

            // attribute enhancers
            parseAugmentator("/eveapi/result/attributeEnhancers/memoryBonus", xmlDoc, characterSheet.MemoryBonus);
            parseAugmentator("/eveapi/result/attributeEnhancers/willpowerBonus", xmlDoc, characterSheet.WillpowerBonus);
            parseAugmentator("/eveapi/result/attributeEnhancers/perceptionBonus", xmlDoc, characterSheet.PerceptionBonus);
            parseAugmentator("/eveapi/result/attributeEnhancers/intelligenceBonus", xmlDoc, characterSheet.IntelligenceBonus);
            parseAugmentator("/eveapi/result/attributeEnhancers/charismaBonus", xmlDoc, characterSheet.CharismaBonus);

            // attributes
            characterSheet.Intelligence = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/attributes/intelligence").InnerText);
            characterSheet.Memory = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/attributes/memory").InnerText);
            characterSheet.Charisma = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/attributes/charisma").InnerText);
            characterSheet.Perception = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/attributes/perception").InnerText);
            characterSheet.Willpower = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/attributes/willpower").InnerText);

            // skills
            List<SkillItem> parsedSkillItems = new List<SkillItem>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='skills']/row"))
            {
                SkillItem si = new SkillItem();
                si.TypeId = Convert.ToInt32(row.Attributes["typeID"].InnerText);
                si.Skillpoints = Convert.ToInt64(row.Attributes["skillpoints"].InnerText);
                si.Level = Convert.ToInt32(row.Attributes["level"].InnerText);

                if (row.Attributes.GetNamedItem("unpublished") != null)
                {
                    si.Unpublished = row.Attributes["unpublished"].InnerText;
                }

                parsedSkillItems.Add(si);
            }
            characterSheet.SkillItemList = parsedSkillItems.ToArray();

            return characterSheet;
        }

        /// <summary>
        /// Parses out each implant that the character has in
        /// </summary>
        /// <param name="xpath">The xpath location of the implant in the xml</param>
        /// <param name="xmlDoc">The xml document</param>
        /// <param name="ae">The correct attribute enhancer to modify</param>
        /// <returns></returns>
        protected static void parseAugmentator(string xpath, XmlDocument xmlDoc, AttributeEnhancer ae)
        {
            //XmlNode enhancer = xmlDoc.SelectSingleNode("/eveapi/result/attributeEnhancers/memoryBonus");
            XmlNode enhancer = xmlDoc.SelectSingleNode(xpath);
            if (enhancer != null)
            {
                ae.Name = enhancer.SelectSingleNode("./augmentatorName").InnerText;
                ae.Value = Convert.ToInt32(enhancer.SelectSingleNode("./augmentatorValue").InnerText);
            }
        }
    }

    /// <summary>
    /// Stores valid information about each skill in the character sheet
    /// </summary>
    public class SkillItem
    {
        /// <summary>
        /// TypeId of the skill
        /// </summary>
        public int TypeId;
        /// <summary>
        /// Current number of skillpoints the character has in the skill
        /// </summary>
        public long Skillpoints;
        /// <summary>
        /// The highest completed level of the skill
        /// </summary>
        public int Level;
        /// <summary>
        /// Flag if the skill is an unpublished skill
        /// </summary>
        public string Unpublished;
    }

    /// <summary>
    /// Contains information about each attributeEnhancer (implant)
    /// </summary>
    public class AttributeEnhancer
    {
        /// <summary>
        /// The name of the implant
        /// </summary>
        public string Name = string.Empty;
        /// <summary>
        /// The implant's effect on that attribute
        /// </summary>
        public int Value = 0;
    }
}
