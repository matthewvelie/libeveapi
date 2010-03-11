using System; 
 using System.Collections.Generic; 
 using System.Globalization; 
 using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="Research"/>. 
     ///</summary> 
     internal class ResearchResponseParser : IApiResponseParser<Research> 
     { 
         public Research Parse(XmlDocument xmlDocument) 
         { 
             this.CheckVersion(xmlDocument);
             Research research = new Research();
             research.ParseCommonElements(xmlDocument); 
  
             List<Research.ResearchItem> researchList = new List<Research.ResearchItem>(); 
             foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='research']/row")) 
             { 
				researchList.Add(ParseTransactionRow(node)); 
             } 
             research.ResearchItems = researchList.ToArray(); 
  
             return research; 
         } 
  
         /// <summary> 
         /// Create a ResearchItem by parsing a single row 
         /// </summary> 
         /// <param name="researchRow">XmlNode containing the ResearchItem data</param> 
         /// <returns></returns> 
         private static Research.ResearchItem ParseTransactionRow(XmlNode researchRow) 
         { 
             Research.ResearchItem researchItem = new Research.ResearchItem(); 

             researchItem.AgentID = Convert.ToInt32(researchRow.Attributes["agentID"].InnerText, CultureInfo.InvariantCulture); 
             researchItem.SkillTypeID = Convert.ToInt32(researchRow.Attributes["skillTypeID"].InnerText, CultureInfo.InvariantCulture); 
             researchItem.ResearchStartDate = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(researchRow.Attributes["researchStartDate"].InnerText); 
             researchItem.ResearchStartDateLocal = TimeUtilities.ConvertCCPToLocalTime(researchItem.ResearchStartDate); 
             researchItem.PointsPerDay = Convert.ToDecimal(researchRow.Attributes["pointsPerDay"].InnerText, CultureInfo.InvariantCulture); 
             researchItem.RemainderPoints = (float)Convert.ToDouble(researchRow.Attributes["remainderPoints"].InnerText, CultureInfo.InvariantCulture); 
  
             return researchItem; 
         }
         
        /// <summary> 
        /// Compares the object version to the EveApi response version 
        /// </summary> 
        /// <param name="xmlDocument">XML docuemnt to compare version against</param> 
        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (Research.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(Research.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, Research.API_VERSION);
                }
            }
        }
     } 
 } 
 