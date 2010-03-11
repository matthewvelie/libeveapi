using System; 
 using System.Collections.Generic; 
 using System.Globalization; 
 using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="ContainerLog"/>. 
     ///</summary> 
     internal class CorporationMedalsResponseParser : IApiResponseParser<CorporationMedals> 
     {
        /// <summary> 
        /// Create a ContainerLog Object by parsing an XML Document 
        /// </summary> 
        /// <param name="xmlDocument">XML Doc containing the ContainerLog data</param> 
        /// <returns>An object containing ContainerLog entries</returns> 
		public CorporationMedals Parse(XmlDocument xmlDocument) 
		{ 
			this.CheckVersion(xmlDocument);
            CorporationMedals medals = new CorporationMedals(); 
			medals.ParseCommonElements(xmlDocument);

			List<CorporationMedals.MedalItem> medalsItemList = new List<CorporationMedals.MedalItem>(); 
			foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='medals']/row")) 
			{ 
				medalsItemList.Add(ParseRow(node)); 
			} 
			medals.MedalItems = medalsItemList.ToArray(); 

            return medals; 
		}
       
        private static CorporationMedals.MedalItem ParseRow(XmlNode containerItemRow)
        {
            CorporationMedals.MedalItem logItem = 
                new CorporationMedals.MedalItem(
                    Convert.ToInt32(containerItemRow.Attributes["medalID"].InnerText, CultureInfo.InvariantCulture),
                    containerItemRow.Attributes["title"].InnerText,
                    containerItemRow.Attributes["description"].InnerText,
                    Convert.ToInt32(containerItemRow.Attributes["creatorID"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToDateTime(containerItemRow.Attributes["created"].InnerText, CultureInfo.InvariantCulture));

            return logItem; 
        }
        
        ///<summary> 
        /// Check if the version of the object matches the EveApi response version 
        ///</summary> 
        /// <param name="xmlDocument">XML Document to parse</param> 
        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (CorporationMedals.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(CorporationMedals.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, CorporationMedals.API_VERSION);
                }
            }
        }
     } 
 } 
 