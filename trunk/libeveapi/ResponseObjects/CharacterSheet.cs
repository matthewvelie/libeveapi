using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class CharacterSheet : ApiResponse
    {
        public string CharacterId;
        public string Name;
        public string Race;
        public string BloodLine;
        public string Gender;
        public string CorporationName;
        public string CorporationId;
        public double Balance;

        public int Intelligence;
        public int Memory;
        public int Charisma;
        public int Perception;
        public int Willpower;

        public AttributeEnhancer MemoryBonus = new AttributeEnhancer();
        public AttributeEnhancer WillpowerBonus = new AttributeEnhancer();
        public AttributeEnhancer PerceptionBonus = new AttributeEnhancer();
        public AttributeEnhancer IntelligenceBonus = new AttributeEnhancer();
        public AttributeEnhancer CharismaBonus = new AttributeEnhancer();

        public SkillItem[] SkillItemList = new SkillItem[0];

        public static CharacterSheet FromXmlDocument(XmlDocument xmlDoc)
        {
            CharacterSheet characterSheet = new CharacterSheet();
            characterSheet.ParseCommonElements(xmlDoc);

            // general info
            characterSheet.CharacterId = xmlDoc.SelectSingleNode("/eveapi/result/characterID").InnerText;
            characterSheet.Name = xmlDoc.SelectSingleNode("/eveapi/result/name").InnerText;
            characterSheet.Race = xmlDoc.SelectSingleNode("/eveapi/result/race").InnerText;
            characterSheet.BloodLine = xmlDoc.SelectSingleNode("/eveapi/result/bloodLine").InnerText;
            characterSheet.Gender = xmlDoc.SelectSingleNode("/eveapi/result/gender").InnerText;
            characterSheet.CorporationName = xmlDoc.SelectSingleNode("/eveapi/result/corporationName").InnerText;
            characterSheet.CorporationId = xmlDoc.SelectSingleNode("/eveapi/result/corporationID").InnerText;
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
                si.TypeId = row.Attributes["typeID"].InnerText;
                si.Skillpoints = Convert.ToInt64(row.Attributes["skillpoints"].InnerText);
                si.Level = row.Attributes["level"].InnerText;

                if (row.Attributes.GetNamedItem("unpublished") != null)
                {
                    si.Unpublished = row.Attributes["unpublished"].InnerText;
                }

                parsedSkillItems.Add(si);
            }
            characterSheet.SkillItemList = parsedSkillItems.ToArray();

            return characterSheet;
        }

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

    public class SkillItem
    {
        public string TypeId;
        public long Skillpoints;
        public string Level;
        public string Unpublished;
    }

    public class AttributeEnhancer
    {
        public string Name = string.Empty;
        public int Value = 0;
    }
}
