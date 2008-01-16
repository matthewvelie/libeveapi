using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Contains the Current Skill in Training
    /// </summary>
    public class SkillInTraining : ApiResponse 
    {
        public bool skillInTraining;
        /// <summary>
        /// Server time when skill training completes
        /// Minvalue - when no skill training
        /// </summary>
        public DateTime trainingEndTime;
        /// <summary>
        /// Server time when skill training started
        /// Minvalue - when no skill training
        /// </summary>
        public DateTime trainingStartTime;
        /// <summary>
        /// ID of skill in training
        /// 0 - when no skill training
        /// </summary>
        public int trainingTypeID;
        /// <summary>
        /// Skill Points at training start
        /// 0 - when no skill training
        /// </summary>
        public int trainingStartSP;
        /// <summary>
        /// Skill Points after training end
        /// 0 - when no skill training
        /// </summary>
        public int trainingDestinationSP;
        /// <summary>
        /// Skill level being trained
        /// 0 - when no skill training
        /// </summary>
        public int trainingToLevel;

        /// <summary>
        /// Create a SkillIntTraining Object by parsing an XmlDocument
        /// response for the eveapi
        /// </summary>
        /// <param name="xmlDoc">XmlDocument containing the skill in training xml</param>
        /// <returns></returns>
        public static SkillInTraining FromXmlDocument(XmlDocument xmlDoc)
        {
            SkillInTraining skilltraining = new SkillInTraining();
            skilltraining.skillInTraining = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/skillInTraining").InnerText));
            if (skilltraining.skillInTraining)
            {
                skilltraining.trainingEndTime = Convert.ToDateTime(xmlDoc.SelectSingleNode("/eveapi/result/trainingEndTime").InnerText);
                skilltraining.trainingStartTime = Convert.ToDateTime(xmlDoc.SelectSingleNode("/eveapi/result/trainingStartTime").InnerText);
                skilltraining.trainingTypeID = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingTypeID").InnerText);
                skilltraining.trainingStartSP = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingStartSP").InnerText);
                skilltraining.trainingDestinationSP = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingDestinationSP").InnerText);
                skilltraining.trainingToLevel = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingToLevel").InnerText);
            }
            else
            {
                skilltraining.trainingEndTime = DateTime.MinValue;
                skilltraining.trainingStartTime = DateTime.MinValue;
                skilltraining.trainingTypeID = 0;
                skilltraining.trainingStartSP = 0;
                skilltraining.trainingDestinationSP = 0;
                skilltraining.trainingToLevel = 0;
            }
            return skilltraining;
        }
    }
}
