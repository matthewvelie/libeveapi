using System; 
 using System.Collections.Generic; 
 using System.Globalization; 
 using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="MemberSecurity"/>. 
     ///</summary> 
     internal class MemberSecurityResponseParser : IApiResponseParser<MemberSecurity> 
     {
        /// <summary> 
        /// Create a MemberSecurity Object by parsing an XML Document 
        /// </summary> 
        /// <param name="xmlDocument">XML Doc containing the MemberSecurity data</param> 
        /// <returns>An object containing MemberSecurity</returns> 
		public MemberSecurity Parse(XmlDocument xmlDocument) 
		{ 
			this.CheckVersion(xmlDocument);
			MemberSecurity obj = new MemberSecurity();
            MemberSecurity.MemberSecurityRole item;
            obj.ParseCommonElements(xmlDocument);

            List<MemberSecurity.MemberSecurityRole> list = new List<MemberSecurity.MemberSecurityRole>();
			foreach (XmlNode node in xmlDocument.SelectNodes("//member")) 
			{
                item = new MemberSecurity.MemberSecurityRole();
                item.CharacterID = Convert.ToInt32(node.Attributes["characterID"].InnerText, CultureInfo.InvariantCulture);
                item.Name = node.Attributes["name"].InnerText;
                item.Roles = ParseSection(xmlDocument, string.Format("//member[@characterID='{0}'].rowset[@name='roles']/row",item.CharacterID));
                item.GrantableRoles = ParseSection(xmlDocument, string.Format("//member[@characterID='{0}'].rowset[@name='grantableRoles']/row",item.CharacterID));
                item.RolesAtHQ = ParseSection(xmlDocument, string.Format("//member[@characterID='{0}'].rowset[@name='rolesAtHQ']/row",item.CharacterID));
                item.GrantableRolesAtHQ = ParseSection(xmlDocument, string.Format("//member[@characterID='{0}'].rowset[@name='grantableRolesAtHQ']/row",item.CharacterID));
                item.RolesAtBase = ParseSection(xmlDocument, string.Format("//member[@characterID='{0}'].rowset[@name='rolesAtBase']/row",item.CharacterID));
                item.GrantableRolesAtBase = ParseSection(xmlDocument, string.Format("//member[@characterID='{0}'].rowset[@name='grantableRolesAtBase']/row",item.CharacterID));
                item.RolesAtOther = ParseSection(xmlDocument, string.Format("//member[@characterID='{0}'].rowset[@name='rolesAtOther']/row",item.CharacterID));
                item.GrantableRolesAtOther = ParseSection(xmlDocument, string.Format("//member[@characterID='{0}'].rowset[@name='grantableRolesAtOther']/row",item.CharacterID));
                item.Titles = ParseSection(xmlDocument, string.Format("//member[@characterID='{0}'].rowset[@name='titles']/row",item.CharacterID));
                list.Add(item);
			} 
            obj.MemberSecurityRoles = list.ToArray();
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
            
            if (row.Attributes.GetNamedItem("roleID") != null)
                item.ID = Convert.ToInt32(row.Attributes["roleID"].InnerText, CultureInfo.InvariantCulture);
            else if (row.Attributes.GetNamedItem("titleID") != null)
                item.ID = Convert.ToInt32(row.Attributes["titleID"].InnerText, CultureInfo.InvariantCulture);
            
            if (row.Attributes.GetNamedItem("roleName") != null)
                item.Name = row.Attributes["roleName"].InnerText;
            else if (row.Attributes.GetNamedItem("titleName") != null)
                item.Name = row.Attributes["titleName"].InnerText;

            return item; 
        }
        
        ///<summary> 
        /// Check if the version of the object matches the EveApi response version 
        ///</summary> 
        /// <param name="xmlDocument">XML Document to parse</param> 
        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (MemberSecurity.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(MemberSecurity.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, MemberSecurity.API_VERSION);
                }
            }
        }
     } 
 } 
 