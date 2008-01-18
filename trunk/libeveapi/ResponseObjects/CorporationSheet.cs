using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Detailed information about a corporation
    /// </summary>
    public class CorporationSheet : ApiResponse
    {
        /// <summary>
        /// Unique identifier for the corporation
        /// </summary>
        public int CorporationId;

        /// <summary>
        /// Name of the corporation
        /// </summary>
        public string CorporationName;

        /// <summary>
        /// Stock ticker symbol for the corporation
        /// </summary>
        public string Ticker;

        /// <summary>
        /// The characterId of the character that is CEO of the corporation
        /// </summary>
        public int CeoId;

        /// <summary>
        /// The name of the character that is CEO of the corporation
        /// </summary>
        public string CeoName;

        /// <summary>
        /// The unique id of the station where the corporation is based
        /// </summary>
        public int StationId;

        /// <summary>
        /// The name of the station where the corporation is based
        /// </summary>
        public string StationName;

        /// <summary>
        /// A description of the corporation as set by the corporation
        /// </summary>
        public string Description;

        /// <summary>
        /// A url to the corporation's web site
        /// </summary>
        public string Url;

        /// <summary>
        ///  	 The unique identifier of this corporation's alliance
        /// </summary>
        public int AllianceId;

        /// <summary>
        /// The name of this corporation's alliance
        /// </summary>
        public string AllianceName;

        /// <summary>
        /// The tax rate of the corporation
        /// </summary>
        public double TaxRate;

        /// <summary>
        /// The current number of pilots in the corporation
        /// </summary>
        public int MemberCount;

        /// <summary>
        /// The current maximum number of pilots the corporation can contain
        /// </summary>
        public int MemberLimit;

        /// <summary>
        /// The current number of outstanding shares of the corporation
        /// </summary>
        public long Shares;

        /// <summary>
        /// 
        /// </summary>
        public Division[] Divisions = new Division[0];

        /// <summary>
        /// 
        /// </summary>
        public WalletDivision[] WalletDivisions = new WalletDivision[0];

        /// <summary>
        /// An object describing the corporation logo
        /// </summary>
        public CorpLogo Logo = new CorpLogo();

        internal static CorporationSheet FromXmlDocument(XmlDocument xmlDoc)
        {
            CorporationSheet corporationSheet = new CorporationSheet();
            corporationSheet.ParseCommonElements(xmlDoc);

            corporationSheet.CorporationId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/corporationID").InnerText);
            corporationSheet.CorporationName = xmlDoc.SelectSingleNode("//result/corporationName").InnerText;
            corporationSheet.Ticker = xmlDoc.SelectSingleNode("//result/ticker").InnerText;
            corporationSheet.CeoId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/ceoID").InnerText);
            corporationSheet.CeoName = xmlDoc.SelectSingleNode("//result/ceoName").InnerText;
            corporationSheet.StationId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/stationID").InnerText);
            corporationSheet.StationName = xmlDoc.SelectSingleNode("//result/stationName").InnerText;
            corporationSheet.Description = xmlDoc.SelectSingleNode("//result/description").InnerText;
            corporationSheet.Url = xmlDoc.SelectSingleNode("//result/url").InnerText;
            corporationSheet.AllianceId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/allianceID").InnerText);
            corporationSheet.AllianceName = xmlDoc.SelectSingleNode("//result/allianceName").InnerText;
            corporationSheet.TaxRate = Convert.ToDouble(xmlDoc.SelectSingleNode("//result/taxRate").InnerText);
            corporationSheet.MemberCount = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/memberCount").InnerText);
            corporationSheet.MemberLimit = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/memberLimit").InnerText);
            corporationSheet.Shares = Convert.ToInt64(xmlDoc.SelectSingleNode("//result/shares").InnerText);

            List<Division> parsedDivisions = new List<Division>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='divisions']/row"))
            {
                Division division = new Division();
                division.AccountKey = Convert.ToInt32(row.Attributes["accountKey"].InnerText);
                division.Description = row.Attributes["description"].InnerText;
                parsedDivisions.Add(division);
            }
            corporationSheet.Divisions = parsedDivisions.ToArray();

            List<WalletDivision> parsedWalletDivisions = new List<WalletDivision>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='walletDivisions']/row"))
            {
                WalletDivision walletDivision = new WalletDivision();
                walletDivision.AccountKey = Convert.ToInt32(row.Attributes["accountKey"].InnerText);
                walletDivision.Description = row.Attributes["description"].InnerText;
                parsedWalletDivisions.Add(walletDivision);
            }
            corporationSheet.WalletDivisions = parsedWalletDivisions.ToArray();

            corporationSheet.Logo.GraphicId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/graphicID").InnerText);
            corporationSheet.Logo.Shape1 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/shape1").InnerText);
            corporationSheet.Logo.Shape2 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/shape2").InnerText);
            corporationSheet.Logo.Shape3 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/shape3").InnerText);
            corporationSheet.Logo.Color1 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/color1").InnerText);
            corporationSheet.Logo.Color2 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/color2").InnerText);
            corporationSheet.Logo.Color3 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/color3").InnerText);

            return corporationSheet;
        }

        public class Division
        {
            public int AccountKey;
            public string Description;
        }

        public class WalletDivision
        {
            public int AccountKey;
            public string Description;
        }

        public class CorpLogo
        {
            public int GraphicId;
            public int Shape1;
            public int Shape2;
            public int Shape3;
            public int Color1;
            public int Color2;
            public int Color3;
        }
    }
}
