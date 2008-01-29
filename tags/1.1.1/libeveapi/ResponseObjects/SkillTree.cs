using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// 
    /// </summary>
    public class SkillTree : ApiResponse
    {
        private Skill[] skills = new Skill[0];
        private SkillGroup[] skillGroups = new SkillGroup[0];

        /// <summary>
        /// 
        /// </summary>
        public Skill[] Skills
        {
            get { return skills; }
            set { skills = value; }
        }
        public SkillGroup[] SkillGroups
        {
            get { return skillGroups; }
            set { skillGroups = value; }
        }

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
                skill.GroupId = Convert.ToInt32(row.Attributes["groupID"].InnerText, CultureInfo.InvariantCulture);
                skill.TypeId = Convert.ToInt32(row.Attributes["typeID"].InnerText, CultureInfo.InvariantCulture);
                skill.Description = row.SelectSingleNode("description").InnerText;
                skill.Rank = Convert.ToInt32(row.SelectSingleNode("rank").InnerText, CultureInfo.InvariantCulture);

                skill.PrimaryAttribute = mapStringToAttributeType(row.SelectSingleNode("requiredAttributes/primaryAttribute").InnerText);
                skill.SecondaryAttribute = mapStringToAttributeType(row.SelectSingleNode("requiredAttributes/secondaryAttribute").InnerText);

                // Required Skills
                List<RequiredSkill> parsedRequiredSkills = new List<RequiredSkill>();
                foreach (XmlNode requiredNode in row.SelectNodes("rowset[@name='requiredSkills']/row"))
                {
                    RequiredSkill requiredSkill = new RequiredSkill();
                    requiredSkill.TypeId = Convert.ToInt32(requiredNode.Attributes["typeID"].InnerText, CultureInfo.InvariantCulture);
                    requiredSkill.SkillLevel = Convert.ToInt32(requiredNode.Attributes["skillLevel"].InnerText, CultureInfo.InvariantCulture);
                    parsedRequiredSkills.Add(requiredSkill);
                }
                skill.RequiredSkills = parsedRequiredSkills.ToArray();

                // Skill Bonuses
                List<SkillBonus> parsedSkillBonuses = new List<SkillBonus>();
                foreach (XmlNode bonusNode in row.SelectNodes("rowset[@name='skillBonusCollection']/row"))
                {
                    SkillBonus skillBonus = new SkillBonus();
                    skillBonus.BonusType = bonusNode.Attributes["bonusType"].InnerText;
                    skillBonus.BonusValue = Convert.ToDouble(bonusNode.Attributes["bonusValue"].InnerText, CultureInfo.InvariantCulture);
                    parsedSkillBonuses.Add(skillBonus);
                }
                skill.SkillBonuses = parsedSkillBonuses.ToArray();

                parsedSkills.Add(skill);
            }
            skillTree.Skills = parsedSkills.ToArray();

            return skillTree;
        }

        /// <summary>
        /// Information about a EVE Skill
        /// </summary>
        public class Skill
        {
            private string typeName;
            private int groupId;
            private int typeId;
            private string description;
            private int rank;
            private RequiredSkill[] requiredSkills = new RequiredSkill[0];
            private AttributeType primaryAttribute;
            private AttributeType secondaryAttribute;
            private SkillBonus[] skillBonuses = new SkillBonus[0];

            /// <summary>
            /// Name of the skill
            /// </summary>
            public string TypeName
            {
                get { return typeName; }
                set { typeName = value; }
            }

            /// <summary>
            /// Unique identifier for the group this skill belongs to
            /// </summary>
            public int GroupId
            {
                get { return groupId; }
                set { groupId = value; }
            }

            /// <summary>
            /// Unique identifier for this skill type
            /// </summary>
            public int TypeId
            {
                get { return typeId; }
                set { typeId = value; }
            }

            /// <summary>
            /// information about the skill
            /// </summary>
            public string Description
            {
                get { return description; }
                set { description = value; }
            }

            /// <summary>
            /// The training time multiplier of the skill
            /// </summary>
            public int Rank
            {
                get { return rank; }
                set { rank = value; }
            }

            /// <summary>
            /// The skills required to train this skill
            /// </summary>
            public RequiredSkill[] RequiredSkills
            {
                get { return requiredSkills; }
                set { requiredSkills = value; }
            }

            /// <summary>
            /// The attrbute that has the most effect on the amount of time required to train this skill.
            /// </summary>
            public AttributeType PrimaryAttribute
            {
                get { return primaryAttribute; }
                set { primaryAttribute = value; }
            }

            /// <summary>
            /// The attribute that has the second most effect of the amount of time required to train this skill.
            /// </summary>
            public AttributeType SecondaryAttribute
            {
                get { return secondaryAttribute; }
                set { secondaryAttribute = value; }
            }

            /// <summary>
            /// The bonuses gained from training this skill.
            /// </summary>
            public SkillBonus[] SkillBonuses
            {
                get { return skillBonuses; }
                set { skillBonuses = value; }
            }
        }

        /// <summary>
        /// A skill required to train the parent skill
        /// </summary>
        public class RequiredSkill
        {
            private int typeId;
            private int skillLevel;

            /// <summary>
            /// The unique identifier of this skill type.
            /// </summary>
            public int TypeId
            {
                get { return typeId; }
                set { typeId = value; }
            }

            /// <summary>
            /// This skill level is required to train the parent skill.
            /// </summary>
            public int SkillLevel
            {
                get { return skillLevel; }
                set { skillLevel = value; }
            }
        }

        /// <summary>
        /// A group of related skills
        /// </summary>
        public class SkillGroup
        {
            private string groupName;
            private int groupId;

            /// <summary>
            /// The name of this skill group.
            /// </summary>
            public string GroupName
            {
                get { return groupName; }
                set { groupName = value; }
            }

            /// <summary>
            /// The unique identifier for this skill group.
            /// </summary>
            public int GroupId
            {
                get { return groupId; }
                set { groupId = value; }
            }
        }

        /// <summary>
        /// A bonus gained from training the parent skill
        /// </summary>
        public class SkillBonus
        {
            private string bonusType;
            private double bonusValue;

            /// <summary>
            /// Description of the bonus
            /// </summary>
            public string BonusType
            {
                get { return bonusType; }
                set { bonusType = value; }
            }

            /// <summary>
            /// The amount of bonus gained from each level of the skill trained.
            /// </summary>
            public double BonusValue
            {
                get { return bonusValue; }
                set { bonusValue = value; }
            }
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
        
        /// <summary>
        /// Different types of character attributes
        /// </summary>
        public enum AttributeType
        {
            /// <summary>
            /// The memory attribute
            /// </summary>
            Memory,
            /// <summary>
            /// The Willpower attribute
            /// </summary>
            Willpower,
            /// <summary>
            /// The Intelligence attribute
            /// </summary>
            Intelligence,
            /// <summary>
            /// The Perception attribute
            /// </summary>
            Perception,
            /// <summary>
            /// The Charisma attribute
            /// </summary>
            Charisma,
            /// <summary>
            /// What is this attribute?
            /// </summary>
            Unknown
        }
    }
}
