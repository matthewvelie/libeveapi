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
        private bool skillCurrentlyInTraining;
        private DateTime trainingEndTime;
        private DateTime trainingStartTime;
        private DateTime trainingEndTimeLocal;
        private DateTime trainingStartTimeLocal;
        private int trainingTypeId;
        private int trainingStartSP;
        private int trainingDestinationSP;
        private int trainingToLevel;

        /// <summary>
        /// True if a skill is currently training, false is no skill is training
        /// </summary>
        public bool SkillCurrentlyInTraining
        {
            get { return skillCurrentlyInTraining; }
            set { skillCurrentlyInTraining = value; }
        }
        /// 
        /// <summary>
        /// Server time when skill training completes in ccp time
        /// Minvalue - when no skill training
        /// </summary>
        public DateTime TrainingEndTime
        {
            get { return trainingEndTime; }
            set { trainingEndTime = value; }
        }
        /// 
        /// <summary>
        /// Server time when skill training started in ccp time
        /// Minvalue - when no skill training
        /// </summary>
        public DateTime TrainingStartTime
        {
            get { return trainingStartTime; }
            set { trainingStartTime = value; }
        }
        /// 
        /// <summary>
        /// Server time when skill training completes in local time
        /// Minvalue - when no skill training
        /// </summary>
        public DateTime TrainingEndTimeLocal
        {
            get { return trainingEndTimeLocal; }
            set { trainingEndTimeLocal = value; }
        }
        /// 
        /// <summary>
        /// Server time when skill training started in local time
        /// Minvalue - when no skill training
        /// </summary>
        public DateTime TrainingStartTimeLocal
        {
            get { return trainingStartTimeLocal; }
            set { trainingStartTimeLocal = value; }
        }
        /// 
        /// <summary>
        /// Id of skill in training
        /// 0 - when no skill training
        /// </summary>
        public int TrainingTypeId
        {
            get { return trainingTypeId; }
            set { trainingTypeId = value; }
        }
        /// 
        /// <summary>
        /// Skill Points at training start
        /// 0 - when no skill training
        /// </summary>
        public int TrainingStartSP
        {
            get { return trainingStartSP; }
            set { trainingStartSP = value; }
        }
        /// 
        /// <summary>
        /// Skill Points after training end
        /// 0 - when no skill training
        /// </summary>
        public int TrainingDestinationSP
        {
            get { return trainingDestinationSP; }
            set { trainingDestinationSP = value; }
        }
        /// 
        /// <summary>
        /// Skill level being trained
        /// 0 - when no skill training
        /// </summary>
        public int TrainingToLevel
        {
            get { return trainingToLevel; }
            set { trainingToLevel = value; }
        }

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
                skilltraining.TrainingEndTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(xmlDoc.SelectSingleNode("/eveapi/result/trainingEndTime").InnerText);
                skilltraining.TrainingStartTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(xmlDoc.SelectSingleNode("/eveapi/result/trainingStartTime").InnerText);
                skilltraining.TrainingTypeId = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingTypeID").InnerText);
                skilltraining.TrainingStartSP = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingStartSP").InnerText);
                skilltraining.TrainingDestinationSP = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingDestinationSP").InnerText);
                skilltraining.TrainingToLevel = Convert.ToInt32(xmlDoc.SelectSingleNode("/eveapi/result/trainingToLevel").InnerText);

                skilltraining.TrainingEndTimeLocal = TimeUtilities.ConvertCCPToLocalTime(skilltraining.TrainingEndTime);
                skilltraining.TrainingStartTimeLocal = TimeUtilities.ConvertCCPToLocalTime(skilltraining.TrainingStartTimeLocal);
            }
            else
            {
                skilltraining.TrainingEndTime = DateTime.MinValue;
                skilltraining.TrainingStartTime = DateTime.MinValue;
                skilltraining.TrainingEndTimeLocal = DateTime.MinValue;
                skilltraining.TrainingStartTimeLocal = DateTime.MinValue;
                skilltraining.TrainingTypeId = 0;
                skilltraining.TrainingStartSP = 0;
                skilltraining.TrainingDestinationSP = 0;
                skilltraining.TrainingToLevel = 0;
            }
            return skilltraining;
        }
    }
}
