using System; 
 using System.Collections.Generic; 
 using System.Globalization; 
 using System.Xml; 
  
 namespace libeveapi.ResponseObjects.Parsers 
 { 
     ///<summary> 
     /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="Standings"/>. 
     ///</summary> 
     internal class StandingsResponseParser : IApiResponseParser<Standings> 
     {
        private StandingType type = StandingType.Character;
        Standings standings; 

        /// <summary>
        /// Constructor, Assums StandingType.Character type
        /// </summary>
        public StandingsResponseParser() : this(StandingType.Character){}
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type">the StandingType of the Xml Document Corporation/Character (Default)</param> 
        public StandingsResponseParser(StandingType type)
        {
            this.type = type;
            standings = new Standings();
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type">the StandingType of the Xml Document Corporation/Character (Default)</param> 
        /// <param name="standings">The object to fill</param> 
        public StandingsResponseParser(StandingType type, Standings standings)
        {
            this.type = type;
            this.standings = standings;
        }
        /// <summary> 
        /// Create a standings Object by parsing an XML Document 
        /// </summary> 
        /// <param name="xmlDocument">XML Doc containing the standings data</param> 
        /// <returns>An object containing Standings</returns> 
		public Standings Parse(XmlDocument xmlDocument) 
		{ 
			this.CheckVersion(xmlDocument);
			standings.ParseCommonElements(xmlDocument);

            if(type == StandingType.Character)
            {
                standings.Character.ToCharacters = ParseSection(xmlDocument, "//rowset[@name='characters']/row");
                standings.Character.ToCorporations = ParseSection(xmlDocument, "//rowset[@name='corporations']/row");
                standings.Character.FromAgents = ParseSection(xmlDocument, "//rowset[@name='agents']/row");
                standings.Character.FromNPCCoporations = ParseSection(xmlDocument, "//rowset[@name='NPCCorporations']/row");
                standings.Character.FromFactions = ParseSection(xmlDocument, "//rowset[@name='factions']/row");
            }
            else
            {
                standings.Corporation.ToCharacters = ParseSection(xmlDocument, "//corporationStandings.standingsTo.rowset[@name='characters']/row");
                standings.Corporation.ToCorporations = ParseSection(xmlDocument, "//corporationStandings.standingsTo.rowset[@name='corporations']/row");
                standings.Corporation.ToAlliances = ParseSection(xmlDocument, "//corporationStandings.standingsTo.rowset[@name='alliances']/row");
                standings.Corporation.FromAgents = ParseSection(xmlDocument, "//rowset[@name='agents']/row");
                standings.Corporation.FromNPCCoporations = ParseSection(xmlDocument, "//rowset[@name='NPCCorporations']/row");
                standings.Corporation.FromFactions = ParseSection(xmlDocument, "//rowset[@name='factions']/row");
                standings.Alliance.ToCorporations = ParseSection(xmlDocument, "//allianceStandings.standingsTo.rowset[@name='corporations']/row");
                standings.Alliance.ToAlliances = ParseSection(xmlDocument, "//allianceStandings.standingsTo.rowset[@name='alliances']/row");
            }
            return standings; 
		}

        private static Standings.StandingsItem[] ParseSection(XmlDocument xmlDocument, string xpath)
        {
			List<Standings.StandingsItem> standingsItemList = new List<Standings.StandingsItem>(); 
			foreach (XmlNode node in xmlDocument.SelectNodes(xpath)) 
			{ 
				standingsItemList.Add(ParseRow(node)); 
			} 
			return standingsItemList.ToArray(); 
        }
        
        private static Standings.StandingsItem ParseRow(XmlNode standingsRow)
        {
            Standings.StandingsItem standingsItem = 
                new Standings.StandingsItem(
                    Convert.ToInt32(standingsRow.Attributes["standingsID"].InnerText, CultureInfo.InvariantCulture),
                    standingsRow.Attributes["standingsName"].InnerText,
                    Convert.ToDouble(standingsRow.Attributes["shares"].InnerText, CultureInfo.InvariantCulture));

            return standingsItem; 
        }
        
        ///<summary> 
        /// Check if the version of the object matches the EveApi response version 
        ///</summary> 
        /// <param name="xmlDocument">XML Document to parse</param> 
        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (Standings.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(Standings.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, Standings.API_VERSION);
                }
            }
        }
     } 
 } 
 