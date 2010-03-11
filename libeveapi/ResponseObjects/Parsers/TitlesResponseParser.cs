using System; 
 using System.Collections.Generic; 
 using System.Globalization; 
 using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="Titles"/>. 
     ///</summary> 
     internal class TitlesResponseParser : IApiResponseParser<Titles> 
     {
        /// <summary> 
        /// Create a Titles Object by parsing an XML Document 
        /// </summary> 
        /// <param name="xmlDocument">XML Doc containing the Titles data</param> 
        /// <returns>An object containing Titles</returns> 
		public Titles Parse(XmlDocument xmlDocument) 
		{ 
			this.CheckVersion(xmlDocument);
			Titles obj = new Titles();
            Titles.TitleItem item;
            obj.ParseCommonElements(xmlDocument);

            List<Titles.TitleItem> list = new List<Titles.TitleItem>();
			foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='titles']/row")) 
			{
                item = new Titles.TitleItem();
                item.ID = Convert.ToInt32(node.Attributes["titleID"].InnerText, CultureInfo.InvariantCulture);
                item.Name = node.Attributes["titleName"].InnerText;
                item.Roles = ParseSection(xmlDocument, string.Format("//row[@titleID='{0}'].rowset[@name='roles']/row",item.ID));
                item.GrantableRoles = ParseSection(xmlDocument, string.Format("//row[@titleID='{0}'].rowset[@name='grantableRoles']/row",item.ID));
                item.RolesAtHQ = ParseSection(xmlDocument, string.Format("//row[@titleID='{0}'].rowset[@name='rolesAtHQ']/row",item.ID));
                item.GrantableRolesAtHQ = ParseSection(xmlDocument, string.Format("//row[@titleID='{0}'].rowset[@name='grantableRolesAtHQ']/row",item.ID));
                item.RolesAtBase = ParseSection(xmlDocument, string.Format("//row[@titleID='{0}'].rowset[@name='rolesAtBase']/row",item.ID));
                item.GrantableRolesAtBase = ParseSection(xmlDocument, string.Format("//row[@titleID='{0}'].rowset[@name='grantableRolesAtBase']/row",item.ID));
                item.RolesAtOther = ParseSection(xmlDocument, string.Format("//row[@titleID='{0}'].rowset[@name='rolesAtOther']/row",item.ID));
                item.GrantableRolesAtOther = ParseSection(xmlDocument, string.Format("//row[@titleID='{0}'].rowset[@name='grantableRolesAtOther']/row",item.ID));
                list.Add(item);
			} 
            obj.TitleItems = list.ToArray();
            return obj; 
		}

        private static Titles.TitleRole[] ParseSection(XmlDocument xmlDocument, string xpath)
        {
			List<Titles.TitleRole> list = new List<Titles.TitleRole>(); 
			foreach (XmlNode node in xmlDocument.SelectNodes(xpath)) 
			{ 
				list.Add(ParseRow(node)); 
			} 
			return list.ToArray(); 
        }
        
        private static Titles.TitleRole ParseRow(XmlNode row)
        {
            Titles.TitleRole item = new Titles.TitleRole();
            
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
            if (Titles.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(Titles.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, Titles.API_VERSION);
                }
            }
        }
     } 
 } 
 