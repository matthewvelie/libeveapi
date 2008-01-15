using System;
using System.Collections.Generic;
using System.Text;

namespace libeveapi
{
    public class Constants
    {
        public static string ApiPrefix = "http://api.eve-online.com";
        public static string CharacterAccountBalance = "/char/AccountBalance.xml.aspx";
        public static string CorpAccountBalance = "/corp/AccountBalance.xml.aspx";
        public static string CharacterList = "/account/Characters.xml.aspx";
        public static string StarbaseDetails = "/corp/StarbaseDetail.xml.aspx";
        public static string StarbaseList = "/corp/StarbaseList.xml.aspx";
        public static string ErrorList = "/eve/ErrorList.xml.aspx";
        public static string CharAssetList = "/char/AssetList.xml.aspx";
        public static string CorpAssetList = "/corp/AssetList.xml.aspx";
        public static string CharIndustryJobs = "/char/IndustryJobs.xml.aspx";
        public static string CorpIndustryJobs = "/corp/IndustryJobs.xml.aspx";
        public static string CharJournalEntries = "/char/JournalEntries.xml.aspx";
        public static string CorpJournalEntries = "/corp/JournalEntries.xml.aspx";
        public static string CharWalletTransactions = "/char/WalletTransactions.xml.aspx";
        public static string CorpWalletTransactions = "/corp/WalletTransactions.xml.aspx";
        public static string CharMarketOrders = "/char/MarketOrders.xml.aspx";
        public static string CorpMarketOrders = "/corp/MarketOrders.xml.aspx";
        public static string RefTypesList = "/eve/RefTypes.xml.aspx";
        public static string MemberTracking = "/corp/MemberTracking.xml.aspx";
        public static string CharacterIDName = "/eve/CharacterID.xml.aspx";
        public static string CharacterSheet = "/char/CharacterSheet.xml.aspx";
        public static string AllianceList = "/eve/AllianceList.xml.aspx";
        public static string MapJumps = "/map/Jumps.xml.aspx";
        public static string MapKills = "/map/Kills.xml.aspx";
        public static string MapSoveignty = "/map/Sovereignty.xml.aspx";
        public static string ConquerableStationOutput = "/eve/ConquerableStationList.xml.aspx";
        public static string CorporationSheet = "/corp/CorporationSheet.xml.aspx";
        public static string KillLog = "/char/Killlog.xml.aspx";
        public static string SkillInTraining = "/char/SkillInTraining.xml.aspx";
        public static string SkillTree = "/eve/SkillTree.xml.aspx";

        public static string ImageFullURL = "http://img.eve.is/serv.asp";

        // Not part of the eve-api - used for unit tests
        public static string ExampleError = "/Error.xml.aspx";
    }
}
