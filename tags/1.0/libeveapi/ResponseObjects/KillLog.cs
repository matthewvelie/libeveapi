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
                tmpKill.KillId = Convert.ToInt32(Kill.Attributes["killID"].InnerText);
                tmpKill.SolarSystemId = Convert.ToInt32(Kill.Attributes["solarSystemID"].InnerText);
                tmpKill.KillTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(Kill.Attributes["killTime"].InnerText);
                tmpKill.KillTimeLocal = TimeUtilities.ConvertCCPToLocalTime(tmpKill.KillTime);
                tmpKill.MoonId = Convert.ToInt32(Kill.Attributes["moonID"].InnerText);
                
                //Victim
                XmlNode victimNode = Kill.SelectSingleNode("./victim");
                tmpKill.Victim.CharacterId = Convert.ToInt32(victimNode.Attributes["characterID"].InnerText);
                tmpKill.Victim.CharacterName = victimNode.Attributes["characterName"].InnerText;
                tmpKill.Victim.CorporationId = Convert.ToInt32(victimNode.Attributes["corporationID"].InnerText);
                tmpKill.Victim.CorporationName = victimNode.Attributes["corporationName"].InnerText;
                tmpKill.Victim.AllianceId = Convert.ToInt32(victimNode.Attributes["allianceID"].InnerText);
                tmpKill.Victim.AllianceName = (victimNode.Attributes.GetNamedItem("allianceName") != null) ? victimNode.Attributes["allianceName"].InnerText : "";
                tmpKill.Victim.DamageTaken = Convert.ToInt32(victimNode.Attributes["damageTaken"].InnerText);
                tmpKill.Victim.ShipTypeId = Convert.ToInt32(victimNode.Attributes["shipTypeID"].InnerText);

                //Atackers
                List<Attacker> attackerList = new List<Attacker>();
                foreach (XmlNode attacker in Kill.SelectNodes("./rowset[@name='attackers']/row"))
                {
                    Attacker tmpAttacker = new Attacker();
                    tmpAttacker.CharacterId = Convert.ToInt32(attacker.Attributes["characterID"].InnerText);
                    tmpAttacker.CharacterName = attacker.Attributes["characterName"].InnerText;
                    tmpAttacker.CorporationId = Convert.ToInt32(attacker.Attributes["corporationID"].InnerText);
                    tmpAttacker.CorporationName = attacker.Attributes["corporationName"].InnerText;
                    tmpAttacker.AllianceId = Convert.ToInt32(attacker.Attributes["allianceID"].InnerText);
                    tmpAttacker.AllianceName = attacker.Attributes["allianceName"].InnerText;
                    tmpAttacker.SecurityStatus = (float)Convert.ToDouble(attacker.Attributes["securityStatus"].InnerText);
                    tmpAttacker.DamageDone = Convert.ToInt32(attacker.Attributes["damageDone"].InnerText);
                    tmpAttacker.FinalBlow = Convert.ToBoolean(Convert.ToInt32(attacker.Attributes["finalBlow"].InnerText));
                    tmpAttacker.WeaponTypeId = Convert.ToInt32(attacker.Attributes["weaponTypeID"].InnerText);
                    tmpAttacker.ShipTypeId = Convert.ToInt32(attacker.Attributes["shipTypeID"].InnerText);
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
            tmpItem.TypeId = Convert.ToInt32(ItemNode.Attributes["typeID"].InnerText);
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
            /// <summary>
            /// Unique kill ID for this kill. This is to be used as the input for 
            /// beforeKillID if you need to scroll back. This is globally unique 
            /// and can be used for uniquely identifying a kill to other killboards.
            /// </summary>
            public int KillId;

            /// <summary>
            /// The ID of the solar system this kill occurred in.
            /// </summary>
            public int SolarSystemId;

            /// <summary>
            /// What time the event occurred.
            /// </summary>
            public DateTime KillTime;

            /// <summary>
            /// What time the event occurred in local time.
            /// </summary>
            public DateTime KillTimeLocal;

            /// <summary>
            /// In some situations, this is present to define what moon a 
            /// kill occurred at. Note that this is generally only present 
            /// in situations where the loss is a POS structure. It is not
            /// guaranteed to be populated.
            /// </summary>
            public int MoonId;

            /// <summary>
            /// The victim of the attack
            /// </summary>
            public VictimPilot Victim = new VictimPilot();

            /// <summary>
            /// The attacking pilots
            /// </summary>
            public Attacker[] Attackers = new Attacker[0];

            /// <summary>
            /// The items lost / dropped in the attack
            /// </summary>
            public Item[] Items = new Item[0];
        }

        /// <summary>
        /// A pilot base class
        /// </summary>
        public class Pilot
        {
            /// <summary>
            /// Character's ID. Fairly self-explanatory. Can be 0 in which 
            /// case this kill was not done by a character and instead 
            /// was done by a corporation. In the victim case, this implies 
            /// it is a structure loss.
            /// </summary>
            public int CharacterId;

            /// <summary>
            /// If present, the name of the above characterID.
            /// </summary>
            public string CharacterName;

            /// <summary>
            /// The ID of the corporation. This will always be present, 
            /// as there is always a corporation behind the victim, 
            /// whether it is the corporation itself or simply someone 
            /// in that corporation.
            /// </summary>
            public int CorporationId;

            /// <summary>
            /// The name of the corporation associated with the kill.
            /// </summary>
            public string CorporationName;

            /// <summary>
            /// If not 0, this is the ID of the alliance the corporation belongs to.
            /// </summary>
            public int AllianceId;

            /// <summary>
            /// The name of the alliance associated with the kill.
            /// </summary>
            public string AllianceName;

            /// <summary>
            /// The item lost. This could be a ship as suggested by the name 
            /// but can potentially be anything that generates a kill event.
            /// </summary>
            public int ShipTypeId;
        }
        /// <summary>
        /// The victim pilot
        /// </summary>
        public class VictimPilot : Pilot
        {
            /// <summary>
            /// How much damage the victim took before 
            /// succumbing to fiery defeat and humiliation.
            /// Please note that this damage is calculated after resists. 
            /// It does give you a decent idea of how much 
            /// they were tanking, however.
            /// </summary>
            public int DamageTaken;
        }

        /// <summary>
        /// An Attacking pilot
        /// </summary>
        public class Attacker : Pilot
        {
            /// <summary>
            /// The security status of the aggressor at the time of this kill.
            /// </summary>
            public double SecurityStatus;

            /// <summary>
            /// The amount of damage done to the victim. This is post-resists damage done.
            /// </summary>
            public int DamageDone;

            /// <summary>
            /// Whether or not this aggressor is attributed with the so-called "final blow."
            /// </summary>
            public bool FinalBlow;

            /// <summary>
            /// What weapon we decided to show this person as using. Often a weapon, 
            /// sometimes a ship or missile, rarely a fish
            /// </summary>
            public int WeaponTypeId;
        }

        /// <summary>
        /// An Item from the killmail
        /// </summary>
        public class Item
        {
            /// <summary>
            /// The typeID of this item, references the invTypes table
            /// </summary>
            public int TypeId;

            /// <summary>
            /// See <see cref="InventoryFlagType" /> for full details.
            /// </summary>
            public InventoryFlagType Flag;

            /// <summary>
            /// How many of this item were dropped. 
            /// If the user had multiple stacks, we compress the total number of 
            /// dropped items to just one stack for space purposes
            /// </summary>
            public int QtyDropped;

            /// <summary>
            /// How many of this item fell victim to atomic
            /// dispersal and other sad little ends that such 
            /// things can meet.
            /// </summary>
            public int QtyDestroyed;

            /// <summary>
            /// True if the destroyed item contained other items.
            /// </summary>
            public bool Container;

            /// <summary>
            /// List of contained items.
            /// </summary>
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
