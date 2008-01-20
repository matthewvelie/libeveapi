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
            WalletTransactionsExample();
        }

        public static void UseLocalUrls()
        {
            Constants.ApiPrefix = "http://localhost/eveapi";
        }

        public static void WalletTransactionsExample()
        {
            bool done = false;
            int lastEntrySeen = 0;

            while (!done)
            {
                WalletTransactions transactions = EveApi.GetWalletTransactionsList(WalletTransactionListType.Character, 0, 0, "fullApiKey", lastEntrySeen);
                DisplayWalletTransactions(transactions);
                lastEntrySeen += transactions.WalletTransactionItems.Length;
                if (transactions.WalletTransactionItems.Length < 1000)
                {
                    done = true;
                }
            }
        }

        public static void DisplayWalletTransactions(WalletTransactions transactions)
        {
            foreach (WalletTransactionItem transaction in transactions.WalletTransactionItems)
            {
                Console.WriteLine("Date: {0} Quantity: {1} Price: {2}", transaction.TransactionDateTimeLocal, transaction.Quantity, transaction.Price);
            }
        }

        public static void JournalExample()
        {
            bool done = false;
            int lastEntrySeen = 0;

            while (!done)
            {
                JournalEntries entries = EveApi.GetJournalEntryList(JournalEntryType.Character, 0, 0, "fullApiKey", lastEntrySeen);
                DisplayJournalEntries(entries);
                lastEntrySeen += entries.JournalEntryItems.Length;
                if (entries.JournalEntryItems.Length < 1000)
                {
                    done = true;
                }
            }
        }

        public static void DisplayJournalEntries(JournalEntries entries)
        {
            foreach (JournalEntryItem item in entries.JournalEntryItems)
            {
                Console.WriteLine("Date: {0} Amount: {1} Balance: {2}", item.DateLocal, item.Amount, item.Balance);
            }
        }

        public static void SkillInTrainingExample()
        {
            SkillInTraining skillInTraining = EveApi.GetSkillInTraining("userId", "characterId", "apiKey");
            if (skillInTraining.SkillCurrentlyInTraining)
            {
                Console.WriteLine("Training of skill: {0} will finish at {1}", skillInTraining.TrainingTypeId, skillInTraining.TrainingEndTimeLocal);
            }
            else
            {
                Console.WriteLine("You should start a skill training!");
            }
        }
        public static void IndustryJobListExample()
        {
            IndustryJobList ijl = EveApi.GetIndustryJobList(IndustryJobListType.Corporation, "userId", "characterId", "fullApiKey");
            foreach (IndustryJobListItem item in ijl.IndustryJobListItems)
            {
                if (item.Completed)
                {
                    Console.WriteLine("Completed JobId: {0} Installed at location: {1}", item.JobId, item.InstalledItemLocationId);
                }
            }
        }

        public static void ConquerableStationListExample()
        {
            ConquerableStationList csl = EveApi.GetConquerableStationList();
            foreach (ConquerableStationList.ConquerableStation station in csl.ConquerableStations)
            {
                Console.WriteLine("Station Name: {0} Corporation Name: {1}", station.StationName, station.CorporationName);
            }
        }

        /// <summary>
        /// Display a skill and its required skills
        /// </summary>
        public static void SkillTreeExample()
        {
            SkillTree skillTree = EveApi.GetSkillTree();

            // Get skill 3344 and display its name
            SkillTree.Skill targetSkill = GetSkillByTypeId(3344, skillTree);
            Console.WriteLine("Skill Name: {0}", targetSkill.TypeName);

            // Display the name and level of each required skill
            foreach (SkillTree.RequiredSkill requiredSkill in targetSkill.RequiredSkills)
            {
                SkillTree.Skill requiredSkillInfo = GetSkillByTypeId(requiredSkill.TypeId, skillTree);
                Console.WriteLine("Required Skill: {0} Level: {1}", requiredSkillInfo.TypeName, requiredSkill.SkillLevel);
            }
        }

        /// <summary>
        /// Find a Skill in the SkillTree by TypeId
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="skillTree"></param>
        /// <returns></returns>
        private static SkillTree.Skill GetSkillByTypeId(int typeId, SkillTree skillTree)
        {
            foreach (SkillTree.Skill skill in skillTree.Skills)
            {
                if (skill.TypeId == typeId)
                {
                    return skill;
                }
            }

            return null;
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

        public static void KillLogExample()
        {
            KillLog killLog = EveApi.GetKillLog(KillLogType.Character, "userId", "characterId", "apiKey");
            Console.WriteLine("Total Kills: {0}", killLog.Kills.Length);
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
