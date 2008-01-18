using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Log of 25 most recent kills for a character or 100 most recent for corporation
    /// </summary>
    public class KillLog : ApiResponse
    {
        /// <summary>
        /// Array containing all the kills returned from the api call 
        /// </summary>
        public Kill[] Kills = new Kill[0];

        /// <summary>
        /// Creates a KillLog object from the xml api response
        /// </summary>
        /// <param name="xmlDoc">XmlDocument Containing the api response</param>
        /// <returns></returns>
        public static KillLog FromXmlDocument(XmlDocument xmlDoc)
        {
            KillLog killLog = new KillLog();
            killLog.ParseCommonElements(xmlDoc);

            //Kills outer loop 
            List<Kill> killList = new List<Kill>();
            foreach (XmlNode Kill in xmlDoc.SelectNodes("//rowset[@name='kills']/row"))
            {
                Kill tmpKill = new Kill();
                
                //Kill Info
                tmpKill.KillID = Convert.ToInt32(Kill.Attributes["killID"].InnerText);
                tmpKill.SolarSystemID = Convert.ToInt32(Kill.Attributes["solarSystemID"].InnerText);
                tmpKill.KillTime = Convert.ToDateTime(Kill.Attributes["killTime"].InnerText);
                tmpKill.MoonID = Convert.ToInt32(Kill.Attributes["moonID"].InnerText);
                
                //Victim
                XmlNode victimNode = Kill.SelectSingleNode("./victim");
                tmpKill.Victim.CharacterID = Convert.ToInt32(victimNode.Attributes["characterID"].InnerText);
                tmpKill.Victim.CharacterName = victimNode.Attributes["characterName"].InnerText;
                tmpKill.Victim.CorporationID = Convert.ToInt32(victimNode.Attributes["corporationID"].InnerText);
                tmpKill.Victim.CorporationName = victimNode.Attributes["corporationName"].InnerText;
                tmpKill.Victim.AllianceID = Convert.ToInt32(victimNode.Attributes["allianceID"].InnerText);
                tmpKill.Victim.AllianceName = (victimNode.Attributes.GetNamedItem("allianceName") != null) ? victimNode.Attributes["allianceName"].InnerText : "";
                tmpKill.Victim.DamageTaken = Convert.ToInt32(victimNode.Attributes["damageTaken"].InnerText);
                tmpKill.Victim.ShipTypeID = Convert.ToInt32(victimNode.Attributes["shipTypeID"].InnerText);

                //Atackers
                List<Attacker> attackerList = new List<Attacker>();
                foreach (XmlNode attacker in Kill.SelectNodes("./rowset[@name='attackers']/row"))
                {
                    Attacker tmpAttacker = new Attacker();
                    tmpAttacker.CharacterID = Convert.ToInt32(attacker.Attributes["characterID"].InnerText);
                    tmpAttacker.CharacterName = attacker.Attributes["characterName"].InnerText;
                    tmpAttacker.CorporationID = Convert.ToInt32(attacker.Attributes["corporationID"].InnerText);
                    tmpAttacker.CorporationName = attacker.Attributes["corporationName"].InnerText;
                    tmpAttacker.AllianceID = Convert.ToInt32(attacker.Attributes["allianceID"].InnerText);
                    tmpAttacker.AllianceName = attacker.Attributes["allianceName"].InnerText;
                    tmpAttacker.SecurityStatus = (float)Convert.ToDouble(attacker.Attributes["securityStatus"].InnerText);
                    tmpAttacker.DamageDone = Convert.ToInt32(attacker.Attributes["damageDone"].InnerText);
                    tmpAttacker.FinalBlow = Convert.ToBoolean(Convert.ToInt32(attacker.Attributes["finalBlow"].InnerText));
                    tmpAttacker.WeaponTypeID = Convert.ToInt32(attacker.Attributes["weaponTypeID"].InnerText);
                    tmpAttacker.ShipTypeID = Convert.ToInt32(attacker.Attributes["shipTypeID"].InnerText);
                    attackerList.Add(tmpAttacker);
                }
                tmpKill.Attackers = attackerList.ToArray();

                //Items
                List<Item> itemList = new List<Item>();
                foreach (XmlNode item in Kill.SelectNodes("./rowset[@name='items']/row"))
                {
                    itemList.Add(ParseItemRow(item));
                }
                tmpKill.Items = itemList.ToArray();

                killList.Add(tmpKill);
            }
            killLog.Kills = killList.ToArray();
            return killLog;
        }

        /// <summary>
        /// This function allows you to recursively build the items list. 
        /// This is needed because the items can be infinitely nested in the killmail
        /// </summary>
        /// <param name="ItemNode">The XmlNode containing the item row you want to parse</param>
        /// <returns>The item with it's child items in it's ContainedItems array</returns>
        protected static Item ParseItemRow(XmlNode ItemNode)
        {
            Item tmpItem = new Item();
            tmpItem.TypeID = Convert.ToInt32(ItemNode.Attributes["typeID"].InnerText);
            tmpItem.QtyDropped = Convert.ToInt32(ItemNode.Attributes["qtyDropped"].InnerText);
            tmpItem.QtyDestroyed = Convert.ToInt32(ItemNode.Attributes["qtyDestroyed"].InnerText);

            int flagValue = Convert.ToInt32(ItemNode.Attributes["flag"].InnerText);
            if (Enum.IsDefined(typeof(InventoryFlagType), flagValue))
            {
                tmpItem.Flag = (InventoryFlagType)Enum.ToObject(typeof(InventoryFlagType), flagValue);
            }
            else
            {
                tmpItem.Flag = InventoryFlagType.FlagUnknown;
            }

            //Parse this Items contained items and add it to it's list
            if (ItemNode.HasChildNodes)
            {
                List<Item> itemList = new List<Item>();
                foreach (XmlNode item in ItemNode.SelectNodes("./rowset[@name='items']/row"))
                {
                    itemList.Add(ParseItemRow(item));
                }
                tmpItem.ContainedItems = itemList.ToArray();
            }
            return tmpItem;
        }

        /// <summary>
        /// A Kill contains a victim, list of attackers, and items lost
        /// </summary>
        public class Kill
        {
            public int KillID;
            public int SolarSystemID;
            public DateTime KillTime;
            public int MoonID;
            public VictimPilot Victim = new VictimPilot();
            public Attacker[] Attackers = new Attacker[0];
            public Item[] Items = new Item[0];
        }

        /// <summary>
        /// A pilot base class
        /// </summary>
        public class Pilot
        {
            public int CharacterID;
            public string CharacterName;
            public int CorporationID;
            public string CorporationName;
            public int AllianceID;
            public string AllianceName;
            public int ShipTypeID;
        }
        /// <summary>
        /// The victim pilot
        /// </summary>
        public class VictimPilot : Pilot
        {
            public int DamageTaken;
        }

        /// <summary>
        /// An Attacking pilot
        /// </summary>
        public class Attacker : Pilot
        {
            public float SecurityStatus;
            public int DamageDone;
            public bool FinalBlow;
            public int WeaponTypeID;
        }

        /// <summary>
        /// An Item from the killmail
        /// </summary>
        public class Item
        {
            public int TypeID;
            public InventoryFlagType Flag;
            public int QtyDropped;
            public int QtyDestroyed;
            public bool Container;
            public Item[] ContainedItems = new Item[0];
        }
    }

    /// <summary>
    /// Enum choice for Kill Log type
    /// </summary>
    public enum KillLogType
    {
        /// <summary>
        /// Corporation Kill Log
        /// </summary>
        Corporation,
        /// <summary>
        /// Character Kill Log
        /// </summary>
        Character
    }
}
