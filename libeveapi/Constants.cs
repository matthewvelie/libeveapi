using System;
using System.Collections.Generic;
using System.Text;

namespace libeveapi
{
    /// <summary>
    /// These are the different contants needed throughout the program
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// This is the main domain name that is the prefix for all requests.
        /// To change what server is being used for testing, this URL would be
        /// changed to a test server.
        /// </summary>
        public static string ApiPrefix = "http://api.eve-online.com";
        /// <summary>
        /// The location of the character account balance xml file
        /// </summary>
        public static string CharacterAccountBalance = "/char/AccountBalance.xml.aspx";
        /// <summary>
        /// The location of the corporation account balance xml file
        /// </summary>
        public static string CorpAccountBalance = "/corp/AccountBalance.xml.aspx";
        /// <summary>
        /// The location of the character list xml file
        /// </summary>
        public static string CharacterList = "/account/Characters.xml.aspx";
        /// <summary>
        /// The location of the corporation's starbase details xml file
        /// </summary>
        public static string StarbaseDetails = "/corp/StarbaseDetail.xml.aspx";
        /// <summary>
        /// The location of the corporation's starbase list xml file
        /// </summary>
        public static string StarbaseList = "/corp/StarbaseList.xml.aspx";
        /// <summary>
        /// The location of the error list
        /// </summary>
        public static string ErrorList = "/eve/ErrorList.xml.aspx";
        /// <summary>
        /// The location of the character's asset list xml file
        /// </summary>
        public static string CharAssetList = "/char/AssetList.xml.aspx";
        /// <summary>
        /// The location of the corporation asset list xml file
        /// </summary>
        public static string CorpAssetList = "/corp/AssetList.xml.aspx";
        /// <summary>
        /// The location of the character's industrial jobs xml file
        /// </summary>
        public static string CharIndustryJobs = "/char/IndustryJobs.xml.aspx";
        /// <summary>
        /// The location of the corporation's industrial jobs xml file
        /// </summary>
        public static string CorpIndustryJobs = "/corp/IndustryJobs.xml.aspx";
        /// <summary>
        /// The location of the character's journal entries xml file
        /// </summary>
        public static string CharJournalEntries = "/char/WalletJournal.xml.aspx";
        /// <summary>
        /// The location of the corporation's journal entries xml file
        /// </summary>
        public static string CorpJournalEntries = "/corp/WalletJournal.xml.aspx";
        /// <summary>
        /// The location of the character's wallet transaction xml file
        /// </summary>
        public static string CharWalletTransactions = "/char/WalletTransactions.xml.aspx";
        /// <summary>
        /// The location of the corporation's wallet transactions xml file
        /// </summary>
        public static string CorpWalletTransactions = "/corp/WalletTransactions.xml.aspx";
        /// <summary>
        /// The location of the character's market order xml file
        /// </summary>
        public static string CharMarketOrders = "/char/MarketOrders.xml.aspx";
        /// <summary>
        /// The location of the corporation's market order xml file
        /// </summary>
        public static string CorpMarketOrders = "/corp/MarketOrders.xml.aspx";
        /// <summary>
        /// The location of the reference type list xml file
        /// </summary>
        public static string RefTypesList = "/eve/RefTypes.xml.aspx";
        /// <summary>
        /// The location of the member tracking xml file
        /// </summary>
        public static string MemberTracking = "/corp/MemberTracking.xml.aspx";
        /// <summary>
        /// The location of the characterid and name conversion xml file
        /// </summary>
        public static string CharacterIdName = "/eve/CharacterID.xml.aspx";
        /// <summary>
        /// The location of the character sheet xml file
        /// </summary>
        public static string CharacterSheet = "/char/CharacterSheet.xml.aspx";
        /// <summary>
        /// The location of the alliance list xml file
        /// </summary>
        public static string AllianceList = "/eve/AllianceList.xml.aspx";
        /// <summary>
        /// The location of the map jump statistics xml file
        /// </summary>
        public static string MapJumps = "/map/Jumps.xml.aspx";
        /// <summary>
        /// The location of the map kills statistics xml file
        /// </summary>
        public static string MapKills = "/map/Kills.xml.aspx";
        /// <summary>
        /// The location of the map sovernty statistics xml file
        /// </summary>
        public static string MapSoveignty = "/map/Sovereignty.xml.aspx";
        /// <summary>
        /// The location of the conquerable stations and outpost statistics xml file
        /// </summary>
        public static string ConquerableStationOutpost = "/eve/ConquerableStationList.xml.aspx";
        /// <summary>
        /// The location of the coporation sheet xml file
        /// </summary>
        public static string CorporationSheet = "/corp/CorporationSheet.xml.aspx";
        /// <summary>
        /// The location of the characters killlog xml file
        /// </summary>
        public static string CharKillLog = "/char/Killlog.xml.aspx";
        /// <summary>
        /// The location of the corporation killlog xml file
        /// </summary>
        public static string CorpKillLog = "/corp/Killlog.xml.aspx";
        /// <summary>
        /// The location of the characters current skill in training xml file
        /// </summary>
        public static string SkillInTraining = "/char/SkillInTraining.xml.aspx";
        /// <summary>
        /// The location of the current eve skill tree xml file
        /// </summary>
        public static string SkillTree = "/eve/SkillTree.xml.aspx";
        /// <summary>
        /// The FULL PATH to the image generator
        /// </summary>
        public static string ImageFullURL = "http://img.eve.is/serv.asp";
        /// <summary>
        /// The location of the current eve skill tree xml file
        /// </summary>
        public static string ServerStatus = "/Server/ServerStatus.xml.aspx";
        /// <summary>
        /// A list of contestable solar systems and the NPD faction currently occupying them
        /// </summary>
        public static string MapFactionWarSystems = "/map/FacWarSystems.xml.aspx";
        /// <summary>
        /// Not part of the eve-api - used for unit tests
        /// </summary>
        public static string ExampleError = "/Error.xml.aspx";
    }
}
