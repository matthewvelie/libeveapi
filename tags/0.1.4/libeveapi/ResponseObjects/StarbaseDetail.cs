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
        /// <summary>
        /// 
        /// </summary>
        public string UsageFlags;
        /// <summary>
        /// 
        /// </summary>
        public string DeployFlags;
        /// <summary>
        /// Allow corporation members inside the force field
        /// </summary>
        public bool AllowCorporationMembers;
        /// <summary>
        /// Allow alliance members inside the force field
        /// </summary>
        public bool AllowAllianceMembers;
        /// <summary>
        /// Is the starbase claiming sovernty (only in 0.0 space)
        /// http://myeve.eve-online.com/devblog.asp?a=blog&bid=477
        /// </summary>
        public bool ClaimSovereignty;

        /// <summary>
        /// Shoot on standing drop
        /// </summary>
        public bool OnStandingDropEnabled;
        /// <summary>
        /// What target standing makes them a valid target
        /// </summary>
        public string OnStandingDropStanding;
        /// <summary>
        /// Shoot on status drop
        /// </summary>
        public bool OnStatusDropEnabled;
        /// <summary>
        /// What target security make them a valid target
        /// </summary>
        public string OnStatusDropStanding;
        /// <summary>
        /// Shoot on target agression
        /// </summary>
        public bool OnAgressionEnabled;
        /// <summary>
        /// Shoot if at war with target
        /// </summary>
        public bool OnCorporationWarEnabled;

        /// <summary>
        /// 
        /// </summary>
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