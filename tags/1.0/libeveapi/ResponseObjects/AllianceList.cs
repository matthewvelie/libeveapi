using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class AllianceList : ApiResponse
    {
        /// <summary>
        /// List of alliances
        /// </summary>
        public AllianceListItem[] AllianceListItems = new AllianceListItem[0];

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

        public class AllianceListItem
        {
            /// <summary>
            /// full name of the alliance
            /// </summary>
            public string Name;

            /// <summary>
            /// ticker name of the alliance
            /// </summary>
            public string ShortName;

            /// <summary>
            /// unique identifier for this alliance
            /// </summary>
            public int AllianceId;

            /// <summary>
            /// unique identifier of executor corporation
            /// </summary>
            public int ExecutorCorpId;

            /// <summary>
            /// Current number of pilots in the alliance
            /// </summary>
            public int MemberCount;

            /// <summary>
            /// Date the alliance was created in CCP time
            /// </summary>
            public DateTime StartDate;

            /// <summary>
            /// Date the alliance was created in local time
            /// </summary>
            public DateTime StartDateLocal;

            /// <summary>
            /// List of member corporations
            /// </summary>
            public CorporationListItem[] CorporationListItems;
        }

        public class CorporationListItem
        {
            /// <summary>
            /// unique identifier for the corporation
            /// </summary>
            public int CorporationId;

            /// <summary>
            /// date the corporation joined the alliance in CCP time
            /// </summary>
            public DateTime StartDate;

            /// <summary>
            /// date the corporation joined the alliance in local time
            /// </summary>
            public DateTime StartDateLocal;
        }
    }
}
