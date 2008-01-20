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
            /// <summary>
            /// Name of the skill
            /// </summary>
            public string TypeName;

            /// <summary>
            /// Unique identifier for the group this skill belongs to
            /// </summary>
            public int GroupId;

            /// <summary>
            /// Unique identifier for this skill type
            /// </summary>
            public int TypeId;

            /// <summary>
            /// information about the skill
            /// </summary>
            public string Description;

            /// <summary>
            /// The training time multiplier of the skill
            /// </summary>
            public int Rank;

            /// <summary>
            /// The skills required to train this skill
            /// </summary>
            public RequiredSkill[] RequiredSkills = new RequiredSkill[0];

            /// <summary>
            /// The attrbute that has the most effect on the amount of time required to train this skill.
            /// </summary>
            public AttributeType PrimaryAttribute;

            /// <summary>
            /// The attribute that has the second most effect of the amount of time required to train this skill.
            /// </summary>
            public AttributeType SecondaryAttribute;

            /// <summary>
            /// The bonuses gained from training this skill.
            /// </summary>
            public SkillBonus[] SkillBonuses = new SkillBonus[0];
        }

        /// <summary>
        /// A skill required to train the parent skill
        /// </summary>
        public class RequiredSkill
        {
            /// <summary>
            /// The unique identifier of this skill type.
            /// </summary>
            public int TypeId;

            /// <summary>
            /// This skill level is required to train the parent skill.
            /// </summary>
            public int SkillLevel;
        }

        /// <summary>
        /// A group of related skills
        /// </summary>
        public class SkillGroup
        {
            /// <summary>
            /// The name of this skill group.
            /// </summary>
            public string GroupName;

            /// <summary>
            /// The unique identifier for this skill group.
            /// </summary>
            public int GroupId;
        }

        /// <summary>
        /// A bonus gained from training the parent skill
        /// </summary>
        public class SkillBonus
        {
            /// <summary>
            /// Description of the bonus
            /// </summary>
            public string BonusType;

            /// <summary>
            /// The amount of bonus gained from each level of the skill trained.
            /// </summary>
            public double BonusValue;
        }

        private static AttributeType mapStringToAttributeType(string s)
        {
            switch (s)
            {
                case "memory":
                    return AttributeType.Memory;
                    
                case "willpower":
                    return AttributeType.Willpower;
                    
                case "intelligence":
                    return AttributeType.Intelligence;
                    
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
