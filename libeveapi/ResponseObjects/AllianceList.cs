using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class AllianceList : ApiResponse
    {
        private AllianceListItem[] allianceListItems = new AllianceListItem[0];

        /// <summary>
        /// List of alliances
        /// </summary>
        public AllianceListItem[] AllianceListItems
        {
            get { return allianceListItems; }
            set { allianceListItems = value; }
        }

        internal static AllianceList FromXmlDocument(XmlDocument xmlDoc)
        {
            AllianceList allianceList = new AllianceList();
            allianceList.ParseCommonElements(xmlDoc);

            List<AllianceListItem> parsedAllianceListItems = new List<AllianceListItem>();
            foreach (XmlNode allianceRow in xmlDoc.SelectNodes("//rowset[@name='alliances']/row"))
            {
                AllianceListItem ali = new AllianceListItem();
                ali.Name = allianceRow.Attributes["name"].InnerText;
                ali.ShortName = allianceRow.Attributes["shortName"].InnerText;
                ali.AllianceId = Convert.ToInt32(allianceRow.Attributes["allianceID"].InnerText);
                ali.ExecutorCorpId = Convert.ToInt32(allianceRow.Attributes["executorCorpID"].InnerText);
                ali.MemberCount = Convert.ToInt32(allianceRow.Attributes["memberCount"].InnerText);
                ali.StartDate = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(allianceRow.Attributes["startDate"].InnerText);
                ali.StartDateLocal = TimeUtilities.ConvertCCPToLocalTime(ali.StartDate);

                List<CorporationListItem> parsedCorporationListItems = new List<CorporationListItem>();
                foreach (XmlNode corpRow in allianceRow.SelectNodes("rowset[@name='memberCorporations']/row"))
                {
                    CorporationListItem cli = new CorporationListItem();
                    cli.CorporationId = Convert.ToInt32(corpRow.Attributes["corporationID"].InnerText);
                    cli.StartDate = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(corpRow.Attributes["startDate"].InnerText);
                    cli.StartDateLocal = TimeUtilities.ConvertCCPToLocalTime(cli.StartDate);

                    parsedCorporationListItems.Add(cli);
                }
                ali.CorporationListItems = parsedCorporationListItems.ToArray();

                parsedAllianceListItems.Add(ali);
            }

            allianceList.AllianceListItems = parsedAllianceListItems.ToArray();
            return allianceList;
        }

        /// <summary>
        /// Represents an alliance
        /// </summary>
        public class AllianceListItem
        {
            private string name;
            private string shortName;
            private int allianceId;
            private int executorCorpId;
            private int memberCount;
            private DateTime startDate;
            private DateTime startDateLocal;
            private CorporationListItem[] corporationListItems = new CorporationListItem[0];

            /// <summary>
            /// full name of the alliance
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            /// <summary>
            /// ticker name of the alliance
            /// </summary>
            public string ShortName
            {
                get { return shortName; }
                set { shortName = value; }
            }

            /// <summary>
            /// unique identifier for this alliance
            /// </summary>
            public int AllianceId
            {
                get { return allianceId; }
                set { allianceId = value; }
            }

            /// <summary>
            /// unique identifier of executor corporation
            /// </summary>
            public int ExecutorCorpId
            {
                get { return executorCorpId; }
                set { executorCorpId = value; }
            }

            /// <summary>
            /// Current number of pilots in the alliance
            /// </summary>
            public int MemberCount
            {
                get { return memberCount; }
                set { memberCount = value; }
            }

            /// <summary>
            /// Date the alliance was created in CCP time
            /// </summary>
            public DateTime StartDate
            {
                get { return startDate; }
                set { startDate = value; }
            }

            /// <summary>
            /// Date the alliance was created in local time
            /// </summary>
            public DateTime StartDateLocal
            {
                get { return startDateLocal; }
                set { startDateLocal = value; }
            }

            /// <summary>
            /// List of member corporations
            /// </summary>
            public CorporationListItem[] CorporationListItems
            {
                get { return corporationListItems; }
                set { corporationListItems = value; }
            }
        }

        /// <summary>
        /// Represents a member corporation
        /// </summary>
        public class CorporationListItem
        {
            private int corporationId;
            private DateTime startDate;
            private DateTime startDateLocal;

            /// <summary>
            /// unique identifier for the corporation
            /// </summary>
            public int CorporationId
            {
                get { return corporationId; }
                set { corporationId = value; }
            }

            /// <summary>
            /// date the corporation joined the alliance in CCP time
            /// </summary>
            public DateTime StartDate
            {
                get { return startDate; }
                set { startDate = value; }
            }

            /// <summary>
            /// date the corporation joined the alliance in local time
            /// </summary>
            public DateTime StartDateLocal
            {
                get { return startDateLocal; }
                set { startDateLocal = value; }
            }
        }
    }
}
