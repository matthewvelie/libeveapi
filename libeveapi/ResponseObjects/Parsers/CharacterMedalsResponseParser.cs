using System; 
 using System.Collections.Generic; 
 using System.Globalization; 
 using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="CharacterMedals"/>. 
     ///</summary> 
     internal class CharacterMedalsResponseParser : IApiResponseParser<CharacterMedals> 
     { 
         ///<summary> 
         /// XML Document Parser
         ///</summary> 
         /// <param name="xmlDocument">XML Document to parse</param> 
         /// <returns>Object containing data from the parsed XML Doc</returns> 
         public CharacterMedals Parse(XmlDocument xmlDocument) 
         { 
             this.CheckVersion(xmlDocument);
             CharacterMedals medals = new CharacterMedals(); 
             medals.ParseCommonElements(xmlDocument); 
  
             List<CharacterMedals.MedalItem> medalList = new List<CharacterMedals.MedalItem>(); 
             foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='currentCorporation']/row")) 
             { 
				medalList.Add(ParseRow(node)); 
             } 
             medals.Medals = medalList.ToArray(); 
  
             foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='otherCorporations']/row")) 
             { 
				medalList.Add(ParseRow(node)); 
             } 
             medals.Medals = medalList.ToArray(); 
             return medals; 
         } 
  
         /// <summary> 
         /// Create a MedalItems by parsing a single row 
         /// </summary> 
         /// <param name="medalItemRow">XmlNode containing the CharacterMedals data</param> 
         /// <returns>A CharacterMedal</returns> 
         private static CharacterMedals.MedalItem ParseRow(XmlNode medalItemRow) 
         { 
			CharacterMedals.MedalItem medalItem = new CharacterMedals.MedalItem();
			
			medalItem.MedalID = Convert.ToInt32(medalItemRow.Attributes["medalID"].InnerText, CultureInfo.InvariantCulture); 
			medalItem.Reason = medalItemRow.Attributes["reason"].InnerText; 
			medalItem.Status = medalItemRow.Attributes["status"].InnerText; 
			medalItem.IssuerID = Convert.ToInt32(medalItemRow.Attributes["issuerID"].InnerText, CultureInfo.InvariantCulture);
			medalItem.Issued = Convert.ToDateTime(medalItemRow.Attributes["issued"].InnerText, CultureInfo.InvariantCulture); 

			//These are only present in the otherCorporations rowset
			if (medalItemRow.Attributes.GetNamedItem("corporationID") != null) 
			{ 
				medalItem.CorporationID = Convert.ToInt32(medalItemRow.Attributes["corporationID"].InnerText, CultureInfo.InvariantCulture); 
			} 
			if (medalItemRow.Attributes.GetNamedItem("title") != null) 
			{ 
				medalItem.Title = medalItemRow.Attributes["title"].InnerText; 
			} 
			if (medalItemRow.Attributes.GetNamedItem("description") != null) 
			{ 
				medalItem.Description = medalItemRow.Attributes["description"].InnerText; 
			} 
  
             return medalItem; 
         } 
         
        ///<summary> 
        /// Check if the version of the object matches the EveApi response version 
        ///</summary> 
        /// <param name="xmlDocument">XML Document to parse</param> 
        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (CharacterMedals.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(CharacterMedals.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, CharacterMedals.API_VERSION);
                }
            }
        }
     } 
 } 
 