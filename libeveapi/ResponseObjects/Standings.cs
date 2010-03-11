using System;

namespace libeveapi
{
    /// <summary>
    /// Contains the standings for a Character or Corporation.
    /// http://wiki.eve-id.net/APIv2_Char_Standings_XML
    /// http://wiki.eve-id.net/APIv2_Corp_Standings_XML
    /// </summary>
    public class Standings : ApiResponse
    {
        /// <summary>
        /// API Version Compatibility
        /// </summary>
		public const string API_VERSION = "2";

        public Standings(){throw new NotImplementedException("Object has not been tested against true data");}
        
        private CharacterStandings character = new CharacterStandings();
        private CorporationStandings corporation = new CorporationStandings();
        private AllianceStandings alliance = new AllianceStandings();
        
        /// <summary>
        /// Character Standings
        /// </summary>
        public CharacterStandings Character {get {return character;}set{character = value;}}
        /// <summary>
        /// Corporation Standings
        /// </summary>
        public CorporationStandings Corporation {get {return corporation;}set{corporation = value;}}
        /// <summary>
        /// Alliance Standings
        /// </summary>
        public AllianceStandings Alliance {get {return alliance;}set{alliance = value;}}
        
        /// <summary>
        /// Contains Character Standings
        /// </summary>
        public sealed class CharacterStandings
        {
            private StandingsItem[] toCharacters;
            private StandingsItem[] toCorporations;
            private StandingsItem[] fromAgents;
            private StandingsItem[] fromNPCCoporations;
            private StandingsItem[] fromFactions;
            
            /// <summary>
            /// Standing toward Characters
            /// </summary>
            public StandingsItem[] ToCharacters
            {
                get { return toCharacters; }
                set { toCharacters = value; }
            }
            /// <summary>
            /// Standing toward Corporations
            /// </summary>
            public StandingsItem[] ToCorporations
            {
                get { return toCorporations; }
                set { toCorporations = value; }
            }
            /// <summary>
            /// Standing from Agents
            /// </summary>
            public StandingsItem[] FromAgents
            {
                get { return fromAgents; }
                set { fromAgents = value; }
            }
            /// <summary>
            /// Standing from NPC Corporation
            /// </summary>
            public StandingsItem[] FromNPCCoporations
            {
                get { return fromNPCCoporations; }
                set { fromNPCCoporations = value; }
            }
            /// <summary>
            /// Standing from Factions
            /// </summary>
            public StandingsItem[] FromFactions
            {
                get { return fromFactions; }
                set { fromFactions = value; }
            }
        }
        
        /// <summary>
        /// Contains Corporation Standings
        /// </summary>
        public sealed class CorporationStandings
        {
            private StandingsItem[] toCharacters;
            private StandingsItem[] toCorporations;
            private StandingsItem[] toAlliances;
            private StandingsItem[] fromAgents;
            private StandingsItem[] fromNPCCoporations;
            private StandingsItem[] fromFactions;
            
            /// <summary>
            /// Standing toward Characters
            /// </summary>
            public StandingsItem[] ToCharacters
            {
                get { return toCharacters; }
                set { toCharacters = value; }
            }
            /// <summary>
            /// Standing toward Corporations
            /// </summary>
            public StandingsItem[] ToCorporations
            {
                get { return toCorporations; }
                set { toCorporations = value; }
            }
            /// <summary>
            /// Standing toward Alliances
            /// </summary>
            public StandingsItem[] ToAlliances
            {
                get { return toAlliances; }
                set { toAlliances = value; }
            }
            /// <summary>
            /// Standing from Agents
            /// </summary>
            public StandingsItem[] FromAgents
            {
                get { return fromAgents; }
                set { fromAgents = value; }
            }
            /// <summary>
            /// Standing from NPC Corporation
            /// </summary>
            public StandingsItem[] FromNPCCoporations
            {
                get { return fromNPCCoporations; }
                set { fromNPCCoporations = value; }
            }
            /// <summary>
            /// Standing from Factions
            /// </summary>
            public StandingsItem[] FromFactions
            {
                get { return fromFactions; }
                set { fromFactions = value; }
            }
        }
        
        /// <summary>
        /// Contains Alliance Standings
        /// </summary>
        public sealed class AllianceStandings
        {
            private StandingsItem[] toCorporations;
            private StandingsItem[] toAlliances;
            
            /// <summary>
            /// Standing toward Corporations
            /// </summary>
            public StandingsItem[] ToCorporations
            {
                get { return toCorporations; }
                set { toCorporations = value; }
            }
            /// <summary>
            /// Standing toward Alliances
            /// </summary>
            public StandingsItem[] ToAlliances
            {
                get { return toAlliances; }
                set { toAlliances = value; }
            }
        }
        
        /// <summary>
        /// Contains Medal Information
        /// </summary>
        public class StandingsItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string ColumnsTo="toNameID,toName,standing";
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string ColumnsFrom="fromID,fromName,standing";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string KeyTo = "toNameID";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string KeyFrom = "fromID";
			
            /// <summary>
            /// Full Constructor
            /// </summary>
			public StandingsItem(int id, string name, double standing)
			{
				this.id = id;
				this.name = name;
				this.standing = standing;
			}

			private int id;
			private string name;
			private double standing;

            /// <summary>
            /// Unique ID
            /// </summary>
            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            /// <summary>
			/// Name of entity the standing applies to
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            /// <summary>
            /// Standing
            /// </summary>
            public double Standing
            {
                get { return standing; }
                set { standing = value; }
            }
		}
    }
	/// <summary>
    /// Identifies Character or Corporation Standings
    /// </summary>
    public enum StandingType
    {
        /// <summary>
        /// A corporation's standings
        /// </summary>
        Corporation,
        /// <summary>
        /// A character's standings
        /// </summary>
        Character
    }

}
