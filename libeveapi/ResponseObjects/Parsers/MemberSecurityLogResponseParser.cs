using System; 
 using System.Collections.Generic; 
 using System.Globalization; 
 using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="MemberSecurityLog"/>. 
     ///</summary> 
     internal class MemberSecurityLogResponseParser : IApiResponseParser<MemberSecurityLog> 
     {
        /// <summary> 
        /// Create a MemberSecurityLog Object by parsing an XML Document 
        /// </summary> 
        /// <param name="xmlDocument">XML Doc containing the MemberSecurityLog data</param> 
        /// <returns>An object containing MemberSecurityLog</returns> 
		public MemberSecurityLog Parse(XmlDocument xmlDocument) 
		{ 
			this.CheckVersion(xmlDocument);
			MemberSecurityLog obj = new MemberSecurityLog();
            MemberSecurityLog.ChangeLogEntry item;
            obj.ParseCommonElements(xmlDocument);
            string nodeID;
            
            List<MemberSecurityLog.ChangeLogEntry> list = new List<MemberSecurityLog.ChangeLogEntry>();
			foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='roleHistory'/row")) 
			{
                item = new MemberSecurityLog.ChangeLogEntry();
                nodeID = node.Attributes["changeTime"].InnerText;
                item.ChangeTime = Convert.ToDateTime(node.Attributes["changeTime"].InnerText, CultureInfo.InvariantCulture);
                item.CharacterID = Convert.ToInt32(node.Attributes["characterID"].InnerText, CultureInfo.InvariantCulture);
                item.CharacterName = node.Attributes["characterName"].InnerText;
                item.IssuerID = Convert.ToInt32(node.Attributes["issuerID"].InnerText, CultureInfo.InvariantCulture);
                item.IssuerName = node.Attributes["issuerName"].InnerText;
                item.RoleLocationType = node.Attributes["roleLocationType"].InnerText;

                item.OldRoles = ParseSection(xmlDocument, string.Format("//row[@changeTime='{0}'].rowset[@name='oldRoles']/row",nodeID));
                item.NewRoles = ParseSection(xmlDocument, string.Format("//row[@changeTime='{0}'].rowset[@name='newRoles']/row",nodeID));

                list.Add(item);
			} 
            obj.ChangeLog = list.ToArray();
            return obj; 
		}

        private static MemberSecurity.MemberSecurityItem[] ParseSection(XmlDocument xmlDocument, string xpath)
        {
			List<MemberSecurity.MemberSecurityItem> list = new List<MemberSecurity.MemberSecurityItem>(); 
			foreach (XmlNode node in xmlDocument.SelectNodes(xpath)) 
			{ 
				list.Add(ParseRow(node)); 
			} 
			return list.ToArray(); 
        }
        
        private static MemberSecurity.MemberSecurityItem ParseRow(XmlNode row)
        {
            MemberSecurity.MemberSecurityItem item = new MemberSecurity.MemberSecurityItem();
            
            item.ID = Convert.ToInt32(row.Attributes["roleID"].InnerText, CultureInfo.InvariantCulture);
            item.Name = row.Attributes["roleName"].InnerText;

            return item;
        }
        
        ///<summary> 
        /// Check if the version of the object matches the EveApi response version 
        ///</summary> 
        /// <param name="xmlDocument">XML Document to parse</param> 
        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (MemberSecurityLog.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(MemberSecurityLog.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, MemberSecurityLog.API_VERSION);
                }
            }
        }
     } 
 } 
 