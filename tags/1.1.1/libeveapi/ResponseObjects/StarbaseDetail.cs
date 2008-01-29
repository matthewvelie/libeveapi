using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Shows the settings and fuel status of a starbase
    /// </summary>
    public class StarbaseDetail : ApiResponse
    {
        private string usageFlags;
        private string deployFlags;
        private bool allowCorporationMembers;
        private bool allowAllianceMembers;
        private bool claimSovereignty;
        private bool onStandingDropEnabled;
        private string onStandingDropStanding;
        private bool onStatusDropEnabled;
        private string onStatusDropStanding;
        private bool onAgressionEnabled;
        private bool onCorporationWarEnabled;
        private FuelListItem[] fuelList = new FuelListItem[0];

        /// <summary>
        /// 
        /// </summary>
        public string UsageFlags
        {
            get { return usageFlags; }
            set { usageFlags = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeployFlags
        {
            get { return deployFlags; }
            set { deployFlags = value; }
        }
        /// <summary>
        /// Allow corporation members inside the force field
        /// </summary>
        public bool AllowCorporationMembers
        {
            get { return allowCorporationMembers; }
            set { allowCorporationMembers = value; }
        }
        /// <summary>
        /// Allow alliance members inside the force field
        /// </summary>
        public bool AllowAllianceMembers
        {
            get { return allowAllianceMembers; }
            set { allowAllianceMembers = value; }
        }
        /// <summary>
        /// Is the starbase claiming sovernty (only in 0.0 space)
        /// </summary>
        public bool ClaimSovereignty
        {
            get { return claimSovereignty; }
            set { claimSovereignty = value; }
        }

        /// <summary>
        /// Shoot on standing drop
        /// </summary>
        public bool OnStandingDropEnabled
        {
            get { return onStandingDropEnabled; }
            set { onStandingDropEnabled = value; }
        }
        /// <summary>
        /// What target standing makes them a valid target
        /// </summary>
        public string OnStandingDropStanding
        {
            get { return onStandingDropStanding; }
            set { onStandingDropStanding = value; }
        }
        /// <summary>
        /// Shoot on status drop
        /// </summary>
        public bool OnStatusDropEnabled
        {
            get { return onStatusDropEnabled; }
            set { onStatusDropEnabled = value; }
        }
        /// <summary>
        /// What target security make them a valid target
        /// </summary>
        public string OnStatusDropStanding
        {
            get { return onStatusDropStanding; }
            set { onStatusDropStanding = value; }
        }
        /// <summary>
        /// Shoot on target agression
        /// </summary>
        public bool OnAgressionEnabled
        {
            get { return onAgressionEnabled; }
            set { onAgressionEnabled = value; }
        }
        /// <summary>
        /// Shoot if at war with target
        /// </summary>
        public bool OnCorporationWarEnabled
        {
            get { return onCorporationWarEnabled; }
            set { onCorporationWarEnabled = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public FuelListItem[] FuelList
        {
            get { return fuelList; }
            set { fuelList = value; }
        }

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
            starbaseDetail.AllowCorporationMembers = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//generalSettings/allowCorporationMembers").InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            starbaseDetail.AllowAllianceMembers = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//generalSettings/allowAllianceMembers").InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            starbaseDetail.ClaimSovereignty = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//generalSettings/claimSovereignty").InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);

            starbaseDetail.OnStandingDropEnabled = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//combatSettings/onStandingDrop").Attributes["enabled"].InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            starbaseDetail.OnStandingDropStanding = xmlDoc.SelectSingleNode("//combatSettings/onStandingDrop").Attributes["standing"].InnerText;
            starbaseDetail.OnStatusDropEnabled = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//combatSettings/onStatusDrop").Attributes["enabled"].InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            starbaseDetail.OnStatusDropStanding = xmlDoc.SelectSingleNode("//combatSettings/onStatusDrop").Attributes["standing"].InnerText;
            starbaseDetail.OnAgressionEnabled = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//combatSettings/onAggression").Attributes["enabled"].InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            starbaseDetail.OnCorporationWarEnabled = Convert.ToBoolean(Convert.ToInt32(xmlDoc.SelectSingleNode("//combatSettings/onCorporationWar").Attributes["enabled"].InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            
            List<FuelListItem> fuelList = new List<FuelListItem>();
            foreach (XmlNode fuelNode in xmlDoc.SelectNodes("//rowset[@name='fuel']/row"))
            {
                FuelListItem fli = new FuelListItem();
                fli.TypeId = fuelNode.Attributes["typeID"].InnerText;
                fli.Quantity = Convert.ToInt64(fuelNode.Attributes["quantity"].InnerText, CultureInfo.InvariantCulture);
                fuelList.Add(fli);
            }
            starbaseDetail.FuelList = fuelList.ToArray();

            return starbaseDetail;
        }

        /// <summary>
        /// Represents a type of fuel present in the starbase
        /// </summary>
        public class FuelListItem
        {
            private string typeId;
            private long quantity;

            /// <summary>
            /// Type Id of the fuel
            /// </summary>
            public string TypeId
            {
                get { return typeId; }
                set { typeId = value; }
            }

            /// <summary>
            /// Number of units of the fuel remaining
            /// </summary>
            public long Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
        }
    }
}
