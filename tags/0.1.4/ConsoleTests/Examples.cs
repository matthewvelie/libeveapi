using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using libeveapi;

namespace ConsoleTests
{
    class Examples
    {
        public static void Main(String[] args)
        {
            UseLocalUrls();

        }

        public static void UseLocalUrls()
        {
            Constants.ApiPrefix = "http://localhost/eveapi";
        }

        public static void PrintStarbaseList()
        {
            StarbaseList starbaseList = EveApi.GetStarbaseList("userId", "characterId", "fullApiKey");
            foreach (StarbaseListItem sli in starbaseList.StarbaseListItems)
            {
                Console.WriteLine("ItemID: {0} LocationID: {1} State: {2}", sli.ItemId, sli.LocationId, sli.State);
            }
        }

        public static void PrintStarbaseDetail()
        {
            StarbaseDetail starbaseDetail = EveApi.GetStarbaseDetail("userId", "characterId", "fullApiKey", "itemId");
            Console.WriteLine("usageFlags: {0} deployFlags: {1}", starbaseDetail.UsageFlags, starbaseDetail.DeployFlags);
            
            foreach (FuelListItem fli in starbaseDetail.FuelList)
            {
                Console.WriteLine("TypeID: {0} Quantity: {1}", fli.TypeId, fli.Quantity);
            }
        }

        public static void ErrorListExample()
        {
            ErrorList errorList = EveApi.GetErrorList();
            Console.WriteLine("{0}", errorList.GetMessageForErrorCode("100"));
        }

        public static void PrintAllAssets()
        {
            AssetList assetList = EveApi.GetAssetList(AssetListType.Corporation, "userId", "characterId", "fullApiKey");
            foreach (AssetList.AssetListItem ali in assetList.AssetListItems)
            {
                PrintAsset(ali);
            }
        }

        public static void PrintAsset(AssetList.AssetListItem ali)
        {
            Console.WriteLine("itemID: {0} quantity: {1}", ali.ItemId, ali.Quantity);
            foreach (AssetList.AssetListItem childAsset in ali.Contents)
            {
                PrintAsset(childAsset);
            }
        }
    }
}
