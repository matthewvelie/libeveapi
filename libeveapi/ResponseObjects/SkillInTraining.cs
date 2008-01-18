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
        public bool SkillCurrentlyInTraining;
        /// <summary>
        /// Server time when skill training completes
        /// Minvalue - when no skill training
        /// </summary>
        public DateTime TrainingEndTime;
        /// <summary>
        /// Server time when skill training started
        /// Minvalue - when no skill training
        /// </summary>
        public DateTime TrainingStartTime;
        /// <summary>
        /// Id of skill in training
        /// 0 - when no skill training
        /// </summary>
        public int TrainingTypeId;
        /// <summary>
        /// Skill Points at training start
        /// 0 - when no skill training
        /// </summary>
        public int TrainingStartSP;
        /// <summary>
        /// Skill Points after training end
        /// 0 - when no skill training
        /// </summary>
        public int TrainingDestinationSP;
        /// <summary>
        /// Skill level being trained
        /// 0 - when no skill training
        /// </summary>
        public int TrainingToLevel;

        /// <summary>
        /// Create a SkillIntTraining Object by parsing an XmlDocument
        /// response for the eveapi
        /// </summary>
        /// <param name="xmlDoc">XmlDocument containing the skill in training xml</param>
        /// <returns></returns>
        public static SkillInTraining FromXmlDocument(XmlDocument xmlDoc)
        {
            SkillInTraining skilltraining = new SkillInTraining();
            skilltraining.ParseCommonElements(xmlDoc);
            skilltraining.SkillCurrentlyInTraining = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/skillInTraining").InnerText));
            if (skilltraining.SkillCurrentlyInTraining)
            {
                skilltraining.TrainingEndTime = Convert.ToDateTime(xmlDoc.SelectSingleNode("/eveapi/result/trainingEndTime").InnerText);
                skilltraining.TrainingStartTime = Convert.ToDateTime(xmlDoc.SelectSingleNode("/eveapi/result/trainingStartTime").InnerText);
                skilltraining.TrainingTypeId = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingTypeID").InnerText);
                skilltraining.TrainingStartSP = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingStartSP").InnerText);
                skilltraining.TrainingDestinationSP = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingDestinationSP").InnerText);
                skilltraining.TrainingToLevel = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingToLevel").InnerText);
            }
            else
            {
                skilltraining.TrainingEndTime = DateTime.MinValue;
                skilltraining.TrainingStartTime = DateTime.MinValue;
                skilltraining.TrainingTypeId = 0;
                skilltraining.TrainingStartSP = 0;
                skilltraining.TrainingDestinationSP = 0;
                skilltraining.TrainingToLevel = 0;
            }
            return skilltraining;
        }
    }
}
