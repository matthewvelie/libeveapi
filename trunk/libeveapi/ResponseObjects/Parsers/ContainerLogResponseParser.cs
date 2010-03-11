using System; 
 using System.Collections.Generic; 
 using System.Globalization; 
 using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="ContainerLog"/>. 
     ///</summary> 
     internal class ContainerLogResponseParser : IApiResponseParser<ContainerLog> 
     {
        /// <summary> 
        /// Create a ContainerLog Object by parsing an XML Document 
        /// </summary> 
        /// <param name="xmlDocument">XML Doc containing the ContainerLog data</param> 
        /// <returns>An object containing ContainerLog entries</returns> 
		public ContainerLog Parse(XmlDocument xmlDocument) 
		{ 
			this.CheckVersion(xmlDocument);
            ContainerLog log = new ContainerLog(); 
			log.ParseCommonElements(xmlDocument);

			List<ContainerLog.ContainerLogItem> logItemList = new List<ContainerLog.ContainerLogItem>(); 
			foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='agents']/row")) 
			{ 
				logItemList.Add(ParseRow(node)); 
			} 
			log.ContainerLogItems = logItemList.ToArray(); 

            return log; 
		}
       
        private static ContainerLog.ContainerLogItem ParseRow(XmlNode containerItemRow)
        {
            ContainerLog.ContainerLogItem logItem = 
                new ContainerLog.ContainerLogItem(
                    Convert.ToDateTime(containerItemRow.Attributes["logTime"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToInt32(containerItemRow.Attributes["itemID"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToInt32(containerItemRow.Attributes["itemTypeID"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToInt32(containerItemRow.Attributes["actorID"].InnerText, CultureInfo.InvariantCulture),
                    containerItemRow.Attributes["actorName"].InnerText,
                    Convert.ToInt32(containerItemRow.Attributes["flag"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToInt32(containerItemRow.Attributes["locationID"].InnerText, CultureInfo.InvariantCulture),
                    containerItemRow.Attributes["action"].InnerText,
                    containerItemRow.Attributes["passwordType"].InnerText,
                    Convert.ToInt32(containerItemRow.Attributes["typeID"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToInt32(containerItemRow.Attributes["quantity"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToInt32(containerItemRow.Attributes["oldConfiguration"].InnerText, CultureInfo.InvariantCulture),
                    Convert.ToInt32(containerItemRow.Attributes["newConfiguration"].InnerText, CultureInfo.InvariantCulture));

            return logItem; 
        }
        
        ///<summary> 
        /// Check if the version of the object matches the EveApi response version 
        ///</summary> 
        /// <param name="xmlDocument">XML Document to parse</param> 
        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (ContainerLog.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(ContainerLog.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, ContainerLog.API_VERSION);
                }
            }
        }
     } 
 } 
 