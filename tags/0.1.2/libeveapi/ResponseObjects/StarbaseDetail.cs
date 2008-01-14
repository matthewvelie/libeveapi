using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Shows the settings and fuel status of a starbase
    /// </summary>
    public class StarbaseDetail : ApiResponse
    {
        public string UsageFlags;
        public string DeployFlags;
        public bool AllowCorporationMembers;
        public bool AllowAllianceMembers;
        public bool ClaimSovereignty;

        public bool OnStandingDropEnabled;
        public string OnStandingDropStanding;
        public bool OnStatusDropEnabled;
        public string OnStatusDropStanding;
        public bool OnAgressionEnabled;
        public bool OnCorporationWarEnabled;

        public FuelListItem[] FuelList = new FuelListItem[0];

        /// <summary>
        /// Create a StarbaseDetail by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static StarbaseDetail FromXmlDocument(XmlDocument xmlDoc)
        {
            StarbaseDetail starbaseDetail = new StarbaseDetail();
            starbaseDetail.ParseCommonElements(xmlDoc);

            starbaseDetail.UsageFlags = xmlDoc.SelectSingleNode("//generalSettings/usageFlags").InnerText;
            starbaseDetail.DeployFlags = xmlDoc.SelectSingleNode("//generalSettings/deployFlags").InnerText;
            starbaseDetail.AllowCorporationMembers = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//generalSettings/allowCorporationMembers").InnerText));
            starbaseDetail.AllowAllianceMembers = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//generalSettings/allowAllianceMembers").InnerText));
            starbaseDetail.ClaimSovereignty = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//generalSettings/claimSovereignty").InnerText));

            starbaseDetail.OnStandingDropEnabled = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//combatSettings/onStandingDrop").Attributes["enabled"].InnerText));
            starbaseDetail.OnStandingDropStanding = xmlDoc.SelectSingleNode("//combatSettings/onStandingDrop").Attributes["standing"].InnerText;
            starbaseDetail.OnStatusDropEnabled = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//combatSettings/onStatusDrop").Attributes["enabled"].InnerText));
            starbaseDetail.OnStatusDropStanding = xmlDoc.SelectSingleNode("//combatSettings/onStatusDrop").Attributes["standing"].InnerText;
            starbaseDetail.OnAgressionEnabled = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//combatSettings/onAggression").Attributes["enabled"].InnerText));
            starbaseDetail.OnCorporationWarEnabled = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//combatSettings/onCorporationWar").Attributes["enabled"].InnerText));
            
            List<FuelListItem> fuelList = new List<FuelListItem>();
            foreach (XmlNode fuelNode in xmlDoc.SelectNodes("//rowset[@name='fuel']/row"))
            {
                FuelListItem fli = new FuelListItem();
                fli.TypeId = fuelNode.Attributes["typeID"].InnerText;
                fli.Quantity = Convert.ToInt64(fuelNode.Attributes["quantity"].InnerText);
                fuelList.Add(fli);
            }
            starbaseDetail.FuelList = fuelList.ToArray();

            return starbaseDetail;
        }
    }

    /// <summary>
    /// Represents a type of fuel present in the starbase
    /// </summary>
    public class FuelListItem
    {
        /// <summary>
        /// Type ID of the fuel
        /// </summary>
        public string TypeId;

        /// <summary>
        /// Number of units of the fuel remaining
        /// </summary>
        public long Quantity;
    }
}
