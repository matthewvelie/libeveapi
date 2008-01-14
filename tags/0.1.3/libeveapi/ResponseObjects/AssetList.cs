using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class AssetList : ApiResponse
    {
        public AssetListItem[] AssetListItems = new AssetListItem[0];

        /// <summary>
        /// Create an AssetList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static AssetList FromXmlDocument(XmlDocument xmlDoc)
        {
            AssetList assetList = new AssetList();
            assetList.ParseCommonElements(xmlDoc);

            List<AssetListItem> assets = new List<AssetListItem>();
            foreach (XmlNode node in xmlDoc.SelectNodes("//rowset[@name='assets']/row"))
            {
                assets.Add(ParseAssetRow(node));
            }
            assetList.AssetListItems = assets.ToArray();

            return assetList;
        }

        /// <summary>
        /// Create an AssetListItem by parsing a single row
        /// Recursively parses all contained assets
        /// </summary>
        /// <param name="assetRow"></param>
        /// <returns></returns>
        protected static AssetListItem ParseAssetRow(XmlNode assetRow)
        {
            AssetListItem assetListItem = new AssetListItem();
            assetListItem.ItemId = assetRow.Attributes["itemID"].InnerText;
            assetListItem.TypeId = assetRow.Attributes["typeID"].InnerText;
            assetListItem.Quantity = Convert.ToInt64(assetRow.Attributes["quantity"].InnerText);
            assetListItem.Singleton = Convert.ToBoolean(Convert.ToInt32(assetRow.Attributes["singleton"].InnerText));

            int flagValue = Convert.ToInt32(assetRow.Attributes["flag"].InnerText);
            if (Enum.IsDefined(typeof(InventoryFlagType), flagValue))
            {
                assetListItem.Flag = (InventoryFlagType)Enum.ToObject(typeof(InventoryFlagType), flagValue);
            }
            else
            {
                assetListItem.Flag = InventoryFlagType.FlagUnkown;
            }

            if (assetRow.Attributes.GetNamedItem("locationID") != null)
            {
                assetListItem.LocationId = assetRow.Attributes["locationID"].InnerText;
            }
            

            // Parse any contained assets and add them to this item's contents
            List<AssetListItem> containedAssets = new List<AssetListItem>();
            foreach (XmlNode containedAssetRow in assetRow.SelectNodes("./rowset[@name='contents']/row"))
            {
                containedAssets.Add(ParseAssetRow(containedAssetRow));
            }
            assetListItem.Contents = containedAssets.ToArray();

            return assetListItem;
        }
    }

    public class AssetListItem
    {
        /// <summary>
        /// Unique ID for this item. This is only guaranteed to be unique within 
        /// this page load. IDs are recycled over time and it is possible for this 
        /// to happen. Also, items are not guaranteed to maintain the same itemID 
        /// over time. When they are repackaged, stacks are split or merged, when 
        /// they're assembled, and other actions can cause itemIDs to change.
        /// </summary>
        public string ItemId;

        /// <summary>
        /// References a solar system or station. Note that this column is not present in 
        /// the sub-asset lists, i.e. for things inside of other things.
        /// </summary>
        public string LocationId;

        /// <summary>
        /// The type of this item. References the invTypes table.
        /// </summary>
        public string TypeId;

        /// <summary>
        /// How many items are in this stack.
        /// </summary>
        public long Quantity;

        /// <summary>
        /// Indicates something about this item's storage location. The flag 
        /// is used to differentiate between hangar divisions, drone bay, 
        /// fitting location, and similar. Please see the <see cref="InventoryFlagTypes" />.
        /// </summary>
        public InventoryFlagType Flag;

        /// <summary>
        /// If true, indicates that this item is a singleton. This means that 
        /// the item is not packaged.
        /// </summary>
        public bool Singleton;

        /// <summary>
        /// The items contained in this item if any
        /// </summary>
        public AssetListItem[] Contents = new AssetListItem[0];
    }

    /// <summary>
    /// EVE stores items in a location with a value we call the "flag." 
    /// This value is used to indicate more data about the item's location. 
    /// For example, instead of having different locations for each of the 
    /// modules, we instead have the single location (the ship) with many flags. 
    /// The flags indicate if the item is in cargo or fitted, and if fitted, to which slot.
    /// </summary>
    public enum InventoryFlagType
    {
        FlagUnkown = 999,
        FlagAutoFit = 0, 	
        FlagBonus = 86, 	
        FlagBooster = 88, 	
        FlagBriefcase = 6, 	
        FlagCapsule = 56, 

	    /// <summary>
	    /// general purpose cargo in a ship
	    /// </summary>
        FlagCargo = 5, 
	
        /// <summary>
        /// deliveries hangar
        /// </summary>
        FlagCorpMarket = 62,

        FlagDroneBay = 87, 	
        FlagFactoryOperation = 100, 	
        FlagFixedSlot = 35,
        FlagImplant = 89,
        FlagNone = 0,	
        FlagPilot = 57, 	
        FlagReward = 8,
        FlagShipHangar = 90, 	
        FlagShipOffline = 91, 	
        FlagSkill = 7, 	
        FlagSkillInTraining = 61, 	
        FlagSlotFirst = 11, 	
        FlagSlotLast = 35,
        FlagLocked = 63,
        FlagUnlocked = 64, 	
        FlagWallet = 1,

        #region Hangar Divisions
        /// <summary>
        /// hangar division 1 / personal hanger
        /// </summary>
        FlagHangar = 4,

        /// <summary>
        /// hangar division 2
        /// </summary>
        FlagCorpSAG2 = 116,

        /// <summary>
        /// hangar division 3
        /// </summary>
        FlagCorpSAG3 = 117,

        /// <summary>
        /// hangar division 4
        /// </summary>
        FlagCorpSAG4 = 118,

        /// <summary>
        /// hangar division 5
        /// </summary>
        FlagCorpSAG5 = 119,

        /// <summary>
        /// hangar division 6
        /// </summary>
        FlagCorpSAG6 = 120,

        /// <summary>
        /// hangar division 7
        /// </summary>
        FlagCorpSAG7 = 121,
        #endregion
        # region Fitted Low Slots
        /// <summary>
        /// Fitted in Low Slot 0
        /// </summary>
        FlagLoSlot0 = 11,

        /// <summary>
        /// Fitted in Low Slot 1
        /// </summary>
        FlagLoSlot1 = 12,

        /// <summary>
        /// Fitted in Low Slot 2
        /// </summary>
        FlagLoSlot2 = 13,

        /// <summary>
        /// Fitted in Low Slot 3
        /// </summary>
        FlagLoSlot3 = 14,

        /// <summary>
        /// Fitted in Low Slot 4
        /// </summary>
        FlagLoSlot4 = 15,

        /// <summary>
        /// Fitted in Low Slot 5
        /// </summary>
        FlagLoSlot5 = 16,

        /// <summary>
        /// Fitted in Low Slot 6
        /// </summary>
        FlagLoSlot6 = 17,

        /// <summary>
        /// Fitted in Low Slot 7
        /// </summary>
        FlagLoSlot7 = 18,
                #endregion
        #region Fitted Medium Slots
        /// <summary>
        /// Fitted in Medium Slot 0
        /// </summary>
        FlagMedSlot0 = 19,

        /// <summary>
        /// Fitted in Medium Slot 1
        /// </summary>
        FlagMedSlot1 = 20,

        /// <summary>
        /// Fitted in Medium Slot 2
        /// </summary>
        FlagMedSlot2 = 21,

        /// <summary>
        /// Fitted in Medium Slot 3
        /// </summary>
        FlagMedSlot3 = 22,

        /// <summary>
        /// Fitted in Medium Slot 4
        /// </summary>
        FlagMedSlot4 = 23,

        /// <summary>
        /// Fitted in Medium Slot 5
        /// </summary>
        FlagMedSlot5 = 24,

        /// <summary>
        /// Fitted in Medium Slot 6
        /// </summary>
        FlagMedSlot6 = 25,

        /// <summary>
        /// Fitted in Medium Slot 7
        /// </summary>
        FlagMedSlot7 = 26,
                #endregion
        #region Fitted High Slots
        /// <summary>
        /// Fitted in high slot 0
        /// </summary>
        FlagHiSlot0 = 27,

        /// <summary>
        /// Fitted in high slot 0
        /// </summary>
        FlagHiSlot1 = 28,

        /// <summary>
        /// Fitted in high slot 0
        /// </summary>
        FlagHiSlot2 = 29,

        /// <summary>
        /// Fitted in high slot 0
        /// </summary>
        FlagHiSlot3 = 30,

        /// <summary>
        /// Fitted in high slot 0
        /// </summary>
        FlagHiSlot4 = 31,

        /// <summary>
        /// Fitted in high slot 0
        /// </summary>
        FlagHiSlot5 = 32,

        /// <summary>
        /// Fitted in high slot 0
        /// </summary>
        FlagHiSlot6 = 33,

        /// <summary>
        /// Fitted in high slot 0
        /// </summary>
        FlagHiSlot7 = 34,
                #endregion
        #region Fitted Rig Slots
        /// <summary>
        /// Fitted in rig slot 0
        /// </summary>
        FlagRigSlot0 = 92,

        /// <summary>
        /// Fitted in rig slot 1
        /// </summary>
        FlagRigSlot1 = 93,

        /// <summary>
        /// Fitted in rig slot 2
        /// </summary>
        FlagRigSlot2 = 94,

        /// <summary>
        /// Fitted in rig slot 3
        /// </summary>
        FlagRigSlot3 = 95,

        /// <summary>
        /// Fitted in rig slot 4
        /// </summary>
        FlagRigSlot4 = 96,

        /// <summary>
        /// Fitted in rig slot 5
        /// </summary>
        FlagRigSlot5 = 97,

        /// <summary>
        /// Fitted in rig slot 6
        /// </summary>
        FlagRigSlot6 = 98,

        /// <summary>
        /// Fitted in rig slot 7
        /// </summary>
        FlagRigSlot7 = 99
           #endregion

    } 

    public enum AssetListType
    {
        Corporation,
        Character
    }
}
