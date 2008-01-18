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
            MemberTrackingExample();
        }

        public static void UseLocalUrls()
        {
            Constants.ApiPrefix = "http://localhost/eveapi";
        }


public static void MemberTrackingExample()
{
    MemberTracking memberTracking = EveApi.GetMemberTracking("userId", "characterId", "fullApiKey");
    
    // Output the name and location of all corporation directors
    foreach (MemberTracking.Member member in memberTracking.Members)
    {
        if (member.Roles.HasRole(RoleTypes.Director))
        {
            Console.WriteLine("Director Name: {0} Location: {1}", member.Name, member.Location);
        }
    }
}

        public static void CorporationSheetExample()
        {
            CorporationSheet corporationSheet = EveApi.GetCorporationSheet("userId", "characterId", "apiKey");
            Console.WriteLine("Corporation Name: {0} Ticker: {1}", corporationSheet.CorporationName, corporationSheet.Ticker);
            Console.WriteLine("Logo GraphicId: {0}", corporationSheet.Logo.GraphicId);

            foreach (CorporationSheet.Division division in corporationSheet.Divisions)
            {
                Console.WriteLine("Division AccountKey: {0} Description: {1}", division.AccountKey, division.Description);
            }

            foreach (CorporationSheet.WalletDivision walletDivision in corporationSheet.WalletDivisions)
            {
                Console.WriteLine("Wallet Division AccountKey: {0} Description: {1}", walletDivision.AccountKey, walletDivision.Description);
            }
        }

        public static void CharacterSheetExample()
        {
            CharacterSheet characterSheet = EveApi.GetCharacterSheet("userId", "characterId", "apiKey");
            
            long totalSkillpoints = 0;
            foreach (CharacterSheet.SkillItem skillItem in characterSheet.SkillItemList)
            {
                totalSkillpoints += skillItem.Skillpoints;
            }

            Console.WriteLine("Character Name: {0} Total Skillpoints: {1}", characterSheet.Name, totalSkillpoints);
        }

        public static void PrintAllianceList()
        {
            AllianceList allianceList = EveApi.GetAllianceList();
            foreach (AllianceList.AllianceListItem ali in allianceList.AllianceListItems)
            {
                Console.WriteLine("Alliance name: {0} members: {1}", ali.Name, ali.MemberCount);
                foreach (AllianceList.CorporationListItem cli in ali.CorporationListItems)
                {
                    Console.WriteLine("Member Corporation Id: {0} Started: {1}", cli.CorporationId, cli.StartDate);
                }
            }
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
