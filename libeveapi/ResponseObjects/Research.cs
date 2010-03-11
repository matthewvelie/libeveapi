using System;

namespace libeveapi
{
    /// <summary>
    /// Returns a list of research projects transactions for a character.
    /// http://wiki.eve-id.net/APIv2_Char_Research_XML
    /// </summary>
    public class Research : ApiResponse
    {
        /// <summary>
        /// API Version Compatibility
        /// </summary>
        public const string API_VERSION = "2";
        private ResearchItem[] researchItems = new ResearchItem[0];

        /// <summary>
        /// Array of Research projects
        /// </summary>
        public ResearchItem[] ResearchItems
        {
            get { return researchItems; }
            set { researchItems = value; }
        }

        /// <summary>
        /// Contains information about one research project
        /// </summary>
        public class ResearchItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string Columns = "agentID,skillTypeID,researchStartDate,pointsPerDay,remainderPoints";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string Key = "agentID";
			
            /// <summary>
            /// Default Constructor
            /// </summary>
			public ResearchItem(){}
            /// <summary>
            /// Full Constructor
            /// </summary>
			public ResearchItem(int agentID,int skillTypeID,DateTime researchStartDate,DateTime researchStartDateLocal,decimal pointsPerDay,float remainderPoints)
			{
				this.agentID = agentID;
				this.skillTypeID = skillTypeID;
				this.researchStartDate = researchStartDate;
				this.researchStartDateLocal = researchStartDateLocal;
				this.pointsPerDay = pointsPerDay;
				this.remainderPoints = remainderPoints;
			}
			
            private int agentID;
            private int skillTypeID;
            private DateTime researchStartDate;
			private DateTime researchStartDateLocal;
            private decimal pointsPerDay;
            private float remainderPoints;

			#region Properties
            /// <summary>
            /// This is the agentID
            /// </summary>
            public int AgentID
            {
                get { return agentID; }
                set { agentID = value; }
            }

            /// <summary>
            /// SkillID used for the reasearch
            /// </summary>
            public int SkillTypeID
            {
                get { return skillTypeID; }
                set { skillTypeID = value; }
            }
            /// <summary>
            /// Date the character began the research with the agent at the current pointsPerDay.
			/// Each change in pointsPerDay will update the ResearchStartDate
            /// </summary>
            public DateTime ResearchStartDate
            {
                get { return researchStartDate; }
                set { researchStartDate = value; }
            }

            /// <summary>
			/// Local Time for ResearchStartDate
            /// </summary>
            public DateTime ResearchStartDateLocal
            {
                get { return researchStartDateLocal; }
                set { researchStartDateLocal = value; }
            }

            /// <summary>
            /// Number of points generated per day
            /// </summary>
            public decimal PointsPerDay
            {
                get { return pointsPerDay; }
                set { pointsPerDay = value; }
            }

            /// <summary>
            /// The number of points remaining since last datacore purchase and/or pointsPerDay update. Mission RP is also added to this value. 
            /// </summary>
            public float RemainderPoints
            {
                get { return remainderPoints; }
                set { remainderPoints = value; }
            }
			#endregion Properties
        }
    }
}
