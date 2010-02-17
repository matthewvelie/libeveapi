using System;
using System.Globalization;
using System.Xml;
using System.Collections.Generic;

namespace libeveapi.ResponseObjects.Parsers
{
    ///<summary>
    /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="SkillQueue"/>.
    ///</summary>
    internal class SkillQueueResponseParser : IApiResponseParser<SkillQueue>
    {
        public SkillQueue Parse(XmlDocument xmlDocument)
        {
            SkillQueue skillqueue = new SkillQueue();
            skillqueue.ParseCommonElements(xmlDocument);
            List<SkillQueue.Skill> skills = new List<SkillQueue.Skill>();
            SkillQueue.Skill skill;

            XmlNodeList nodelist = xmlDocument.SelectNodes("//rowset[@name='skillqueue']/row");
            foreach (XmlNode node in nodelist)
            {
                skill = new SkillQueue.Skill(
                    Convert.ToInt32(node.Attributes["queuePosition"].InnerText),
                    Convert.ToInt32(node.Attributes["typeID"].InnerText),
                    Convert.ToInt32(node.Attributes["level"].InnerText),
                    Convert.ToInt32(node.Attributes["startSP"].InnerText),
                    Convert.ToInt32(node.Attributes["endSP"].InnerText),
                    Convert.ToDateTime(node.Attributes["startTime"].InnerText),
                    Convert.ToDateTime(node.Attributes["endTime"].InnerText),
                    TimeUtilities.ConvertCCPToLocalTime(Convert.ToDateTime(node.Attributes["startTime"].InnerText)),
                    TimeUtilities.ConvertCCPToLocalTime(Convert.ToDateTime(node.Attributes["endTime"].InnerText)));
                skills.Add(skill);
                /*
                skillqueue.Add(Convert.ToInt32(node.Attributes["queuePosition"].InnerText),
                    Convert.ToInt32(node.Attributes["typeID"].InnerText),
                    Convert.ToInt32(node.Attributes["level"].InnerText),
                    Convert.ToInt32(node.Attributes["startSP"].InnerText),
                    Convert.ToInt32(node.Attributes["endSP"].InnerText),
                    Convert.ToDateTime(node.Attributes["startTime"].InnerText),
                    Convert.ToDateTime(node.Attributes["endTime"].InnerText));
                 */
            }
            skillqueue.SkillList = skills.ToArray();
            return skillqueue;
        }
    }
}
