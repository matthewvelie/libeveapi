using System; 
 using System.Collections.Generic; 
 using System.Globalization; 
 using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="Shareholders"/>. 
     ///</summary> 
     internal class ShareholdersResponseParser : IApiResponseParser<Shareholders> 
     {
        /// <summary> 
        /// Create a Shareholder Object by parsing an XML Document 
        /// </summary> 
        /// <param name="xmlDocument">XML Doc containing the Shareholder data</param> 
        /// <returns>An object containing shareholders</returns> 
		public Shareholders Parse(XmlDocument xmlDocument) 
		{ 
			this.CheckVersion(xmlDocument);
			Shareholders shareholder = new Shareholders(); 
			shareholder.ParseCommonElements(xmlDocument); 

			List<Shareholders.CharacterShareholder> shareholderList = new List<Shareholders.CharacterShareholder>(); 
			foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='characters']/row")) 
			{ 
				shareholderList.Add((Shareholders.CharacterShareholder)ParseRow(node, new Shareholders.CharacterShareholder() )); 
			} 
			shareholder.CharacterShares = shareholderList.ToArray(); 

			List<Shareholders.CorporationShareholder> shareholderList1 = new List<Shareholders.CorporationShareholder>(); 
			foreach (XmlNode node in xmlDocument.SelectNodes("//rowset[@name='corporation']/row")) 
			{ 
				shareholderList1.Add((Shareholders.CorporationShareholder)ParseRow(node, new Shareholders.CorporationShareholder() )); 
			} 
            shareholder.CorporationShares = shareholderList1.ToArray(); 
            return shareholder; 
		}

        private static object ParseRow(XmlNode shareholderRow, object shareholder)
        {
            Shareholders.ShareholderItem shareholderItems = null;
            if(shareholder is Shareholders.CharacterShareholder)
                shareholderItems = shareholder as Shareholders.CharacterShareholder;
            else if(shareholder is Shareholders.CorporationShareholder)
                shareholderItems = shareholder as Shareholders.CorporationShareholder;
            else
                throw new NotImplementedException("Needs to be fixed");
            // FIXME Need a better exception thrown

            shareholderItems.ShareholderID = Convert.ToInt32(shareholderRow.Attributes["shareholderID"].InnerText, CultureInfo.InvariantCulture); 
            shareholderItems.ShareholderName = shareholderRow.Attributes["shareholderName"].InnerText; 
            shareholderItems.Shares = Convert.ToInt32(shareholderRow.Attributes["shares"].InnerText, CultureInfo.InvariantCulture); 

            //These are only present in the Character Row
            if (shareholderRow.Attributes.GetNamedItem("shareholderCorporationID") != null) 
            { 
                ((Shareholders.CharacterShareholder)shareholderItems).ShareholderCorporationID = Convert.ToInt32(shareholderRow.Attributes["shareholderCorporationID"].InnerText, CultureInfo.InvariantCulture); 
            } 
            if (shareholderRow.Attributes.GetNamedItem("shareholderCorporationName") != null) 
            { 
                ((Shareholders.CharacterShareholder)shareholderItems).ShareholderCorporationName = shareholderRow.Attributes["shareholderCorporationName"].InnerText; 
            } 

            return shareholderItems; 
        }
        ///<summary> 
        /// Check if the version of the object matches the EveApi response version 
        ///</summary> 
        /// <param name="xmlDocument">XML Document to parse</param> 
        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (Shareholders.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(Shareholders.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, Shareholders.API_VERSION);
                }
            }
        }
     } 
 } 
 