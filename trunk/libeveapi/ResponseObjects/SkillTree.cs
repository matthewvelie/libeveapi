using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class SkillTree : ApiResponse
    {
        public Skill[] Skills = new Skill[0];
        public SkillGroup[] SkillGroups = new SkillGroup[0];

        public static SkillTree FromXmlDocument(XmlDocument xmlDoc)
        {
            SkillTree skillTree = new SkillTree();

            // Skill Groups
            List<SkillGroup> parsedSkillGroups = new List<SkillGroup>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='skillGroups']/row"))
            {
                SkillGroup skillGroup = new SkillGroup();
                skillGroup.GroupName = row.Attributes["groupName"].InnerText;
                skillGroup.GroupId = Convert.ToInt32(row.Attributes["groupID"].InnerText);
                parsedSkillGroups.Add(skillGroup);
            }
            skillTree.SkillGroups = parsedSkillGroups.ToArray();

            // Skills
            List<Skill> parsedSkills = new List<Skill>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='skills']/row"))
            {
                Skill skill = new Skill();
                skill.TypeName = row.Attributes["typeName"].InnerText;
                skill.GroupId = Convert.ToInt32(row.Attributes["groupID"].InnerText);
                skill.TypeId = Convert.ToInt32(row.Attributes["typeID"].InnerText);
                skill.Description = row.SelectSingleNode("description").InnerText;
                skill.Rank = Convert.ToInt32(row.SelectSingleNode("rank").InnerText);

                skill.PrimaryAttribute = mapStringToAttributeType(row.SelectSingleNode("requiredAttributes/primaryAttribute").InnerText);
                skill.SecondaryAttribute = mapStringToAttributeType(row.SelectSingleNode("requiredAttributes/secondaryAttribute").InnerText);

                // Required Skills
                List<RequiredSkill> parsedRequiredSkills = new List<RequiredSkill>();
                foreach (XmlNode requiredNode in row.SelectNodes("rowset[@name='requiredSkills']/row"))
                {
                    RequiredSkill requiredSkill = new RequiredSkill();
                    requiredSkill.TypeId = Convert.ToInt32(requiredNode.Attributes["typeID"].InnerText);
                    requiredSkill.SkillLevel = Convert.ToInt32(requiredNode.Attributes["skillLevel"].InnerText);
                    parsedRequiredSkills.Add(requiredSkill);
                }
                skill.RequiredSkills = parsedRequiredSkills.ToArray();

                // Skill Bonuses
                List<SkillBonus> parsedSkillBonuses = new List<SkillBonus>();
                foreach (XmlNode bonusNode in row.SelectNodes("rowset[@name='skillBonusCollection']/row"))
                {
                    SkillBonus skillBonus = new SkillBonus();
                    skillBonus.BonusType = bonusNode.Attributes["bonusType"].InnerText;
                    skillBonus.BonusValue = Convert.ToDouble(bonusNode.Attributes["bonusValue"].InnerText);
                    parsedSkillBonuses.Add(skillBonus);
                }
                skill.SkillBonuses = parsedSkillBonuses.ToArray();

                parsedSkills.Add(skill);
            }
            skillTree.Skills = parsedSkills.ToArray();

            return skillTree;
        }

        public class Skill
        {
            public string TypeName;
            public int GroupId;
            public int TypeId;
            public string Description;
            public int Rank;
            public RequiredSkill[] RequiredSkills = new RequiredSkill[0];
            public AttributeType PrimaryAttribute;
            public AttributeType SecondaryAttribute;
            public SkillBonus[] SkillBonuses = new SkillBonus[0];
        }

        public class RequiredSkill
        {
            public int TypeId;
            public int SkillLevel;
        }

        public class SkillGroup
        {
            public string GroupName;
            public int GroupId;
        }

        public class SkillBonus
        {
            public string BonusType;
            public double BonusValue;
        }

        private static AttributeType mapStringToAttributeType(string s)
        {
            switch (s)
            {
                case "memory":
                    return AttributeType.Memory;
                    break;
                case "willpower":
                    return AttributeType.Willpower;
                    break;
                case "intelligence":
                    return AttributeType.Intelligence;
                    break;
                case "perception":
                    return AttributeType.Perception;
                case "charisma":
                    return AttributeType.Charisma;
            }

            return AttributeType.Unknown;
        }

        public enum AttributeType
        {
            Memory,
            Willpower,
            Intelligence,
            Perception,
            Charisma,
            Unknown
        }
    }
}
