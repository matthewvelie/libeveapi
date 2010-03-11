using System;
using System.Reflection;

namespace libeveapi
{
    /// <summary>
    /// Returns the message headers for notifications.
    /// http://wiki.eve-id.net/APIv2_Char_Notifications_XML
    /// </summary>
	/// <remarks>
	/// This method is cached according to the Modified Short Cache Style. 
	/// The first request returns the latest 200 notifications received by the character within the last week. 
	/// Subsequent requests return only the new items recieved since the last request. 
	/// You can request new items every 30 minutes. 
	/// If you want to re-set the timer and get the first-request bulk again, you'll have to wait 6 hours. 
	/// </remarks>
    public class Notifications : ApiResponse
    {
        /// <summary>
        /// API Version Compatibility
        /// </summary>
		public const string API_VERSION = "2";
		private NotificationItem[] notification = new NotificationItem[0];

        public Notifications(){throw new NotImplementedException("Object has not been tested against true data");}

        /// <summary>
        /// Array of Medals
        /// </summary>
        public NotificationItem[] NotificationItems
        {
            get { return notification; }
            set { notification = value; }
        }

        /// <summary>
        /// A Notification
        /// </summary>
        public class NotificationItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// This should match the list of field names contained in this object
            /// </summary>
			public static string Columns="notificationID,typeID,senderID,sentDate,read";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string Key = "notificationID";
            /// <summary>
            /// Full Constructor
            /// </summary>
			public NotificationItem(int notificationID, int typeID, int senderID, DateTime sentDate, bool read)
			{
				this.notificationID = notificationID;
				this.typeID = typeID;
				this.senderID = senderID;
				this.sentDate = sentDate;
				this.read = read;
                this.notificationDescription = Description.GetDescription<NotificationType>((NotificationType)typeID);
			}

			private int notificationID;
			private int typeID;
			private int senderID;
			private DateTime sentDate;
			private bool read;
            private string notificationDescription;

			#region Properties
            /// <summary>
            /// Unique ID
            /// </summary>
            public int NotificationID
            {
                get { return notificationID; }
                set { notificationID = value; }
            }
            /// <summary>
            /// Notification Type
            /// Use <see cref="NotificationType"/> to lookup the Notification Description by TypeID
            /// </summary>
            public int TypeID
            {
                get { return typeID; }
                set { typeID = value; }
            }
            /// <summary>
            /// Description as entered by the Creater
            /// </summary>
            public int SenderID
            {
                get { return senderID; }
                set { senderID = value; }
            }
            /// <summary>
            /// Date Created
            /// </summary>
            public DateTime SentDate
            {
                get { return sentDate; }
                set { sentDate = value; }
            }
            /// <summary>
            /// Creaters Character ID
            /// </summary>
            public bool Read
            {
                get { return read; }
                set { read = value; }
            }
            /// <summary>
            /// Description of Notification
            /// </summary>
            public string NotificationDescription
            {
                get { return notificationDescription; }
                set { notificationDescription = value; }
            }
			#endregion Properties
		}
    }
    
    /// <summary>
    /// Notification Types
    /// </summary>
    public enum NotificationType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("Character deleted")]
        CharDeleted = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("Give medal to character ")]
        CharMedalRecieved = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("Alliance maintenance bill ")]
        AllyMaintenanceBill = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("Alliance war declared ")]
        AllyWarDeclared = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("Alliance war surrender ")]
        AllyWarSurrender = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("Alliance war retracted ")]
        AllyWarRetracted = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("Alliance war invalidated by Concord ")]
        AllyWarInvalidated = 8,


        /// <summary>
        /// 
        /// </summary>
        
        [Description("Bill issued to a character ")]
        CharBillIssued = 9,

        /// <summary>
        /// 
        /// </summary>
        
        [Description("Bill issued to corporation or alliance ")]
        CorpAllyBillIssued = 10,

        /// <summary>
        /// 
        /// </summary>
        
        [Description("Bill not paid because there's not enough ISK available ")]
        InsufficientISK = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description("Bill, issued by a character, paid ")]
        CharBillPaid = 12,

        /// <summary>
        /// 
        /// </summary>
        [Description("Bill, issued by a corporation or alliance, paid ")]
        CorpAllyBillPaid = 13,

        /// <summary>
        /// 
        /// </summary>
        [Description("Bounty claimed ")]
        BountyClaimed = 14,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Clone activated ")]
        CloneActiviated = 15,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("New corp member application ")]
        CorpNewApp = 16,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp application rejected ")]
        CorpAppRejected = 17,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp application accepted ")]
        CorpAppAccepted = 18,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp tax rate changed ")]
        CorpTaxChange = 19,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp news report, typically for shareholders ")]
        CorpNewsReport = 20,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Player leaves corp ")]
        CorpPlayerLeft = 21,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp news, new CEO ")]
        CorpnewsCEO = 22,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp dividend/liquidation, sent to shareholders ")]
        CorpDividendLiquidationPaid = 23,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp dividend payout, sent to shareholders ")]
        CorpDividendPaid = 24,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp vote created ")]
        CorpVoteCreated = 25,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp CEO votes revoked during voting ")]
        CorpCeoVotesRevoked = 26,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp declares war ")]
        CorpDeclaresWar = 27,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp war has started ")]
        CorpStartedWar = 28,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp surrenders war ")]
        CorpSurrendersWar = 29,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp retracts war ")]
        CorpRetractsWar = 30,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp war invalidated by Concord ")]
        CorpWarInvalidated = 31,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Container password retrieval ")]
        ContainerPasswordRetrived = 32,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Contraband or low standings cause an attack or items being confiscated ")]
        ContrabandOrStandingCauseAttack = 33,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("First ship insurance ")]
        InsuranceFirstShip = 34,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Ship destroyed, insurance payed ")]
        InsurancePaid = 35,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Insurance contract invalidated/runs out ")]
        InsuranceInvalid = 36,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty claim fails (alliance) ")]
        SovereigntyAllyClaimFails = 37,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty claim fails (corporation) ")]
        SovereigntyCorpClaimFails = 38,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty bill late (alliance) ")]
        SovereigntyAllyBillLate = 39,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty bill late (corporation) ")]
        SovereigntyCorpBillLate = 40,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty claim lost (alliance) ")]
        SovereigntyAllyClaimLost = 41,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty claim lost (corporation) ")]
        SovereigntyCorpClaimLost = 42,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty claim acquired (alliance) ")]
        SovereigntyAllyClaimAcquired = 43,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty claim acquired (corporation) ")]
        SovereigntycorpClaimAcquired = 44,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Alliance anchoring alert ")]
        AllyAchoringAlert = 45,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Alliance structure turns vulnerable ")]
        AllyStructureVulnerable = 46,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Alliance structure turns invulnerable ")]
        AllyStructureInvulnerable = 47,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty disruptor anchored ")]
        SovereigntyDisruptorAchored = 48,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Structure won/lost ")]
        StructureWonOrLost = 49,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp office lease expiration notice ")]
        CorpOfficeLeaseExpired = 50,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Clone contract revoked by station manager ")]
        CloneContractRevoked = 51,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corp member clones moved between stations ")]
        CorpMemberCloneMoved = 52,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Clone contract revoked by station manager ")]
        CloneContractRevoked2 = 53,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Insurance contract expired ")]
        InsuranceExpired = 54,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Insurance contract issued ")]
        InsuranceIssued = 55,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Jump clone destroyed ")]
        JumpCloneDestroyed = 56,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Jump clone destroyed ")]
        JumpCloneDestroyed2 = 57,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corporation joining factional warfare ")]
        CorpFacWarJoin = 58,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corporation leaving factional warfare ")]
        CorpFacWarLeave = 59,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corporation kicked from factional warfare on startup because of too low standing to the faction ")]
        CorpFactWarKicked = 60,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Character kicked from factional warfare on startup because of too low standing to the faction ")]
        CharFactWarKicked = 61,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Character in factional warfare warned on startup because of too low standing to the faction ")]
        CorpFacWarWarn = 62,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Character in factional warfare warned on startup because of too low standing to the faction ")]
        CharFacWarWarn = 63,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Character loses factional warfare rank ")]
        CharFacWarRankLoss = 64,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Character gains factional warfare rank ")]
        CharFacWarRankGain = 65,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Agent has moved ")]
        AgentMoved = 66,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Mass transaction reversal message ")]
        TransactionReversal = 67,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Reimbursement message ")]
        Reimbursement = 68,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Agent locates a character ")]
        AgentLocatesChar = 69,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Research mission becomes available from an agent ")]
        AgentResearchMissionAvail = 70,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Agent mission offer expires ")]
        AgentMissionOfferExpired = 71,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Agent mission times out ")]
        AgentMissionTimeOut = 72,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Agent offers a storyline mission ")]
        AgenStroylineMissionAvail = 73,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Tutorial message sent on character creation ")]
        TutorialMessage = 74,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Tower alert ")]
        TowerAlert = 75,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Tower resource alert ")]
        TowerResourceAlert = 76,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Station aggression message ")]
        StationAggression = 77,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Station state change message ")]
        StationStateChanged = 78,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Station conquered message ")]
        StationConquered = 79,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Station aggression message ")]
        StationAggression2 = 80,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corporation requests joining factional warfare ")]
        CorpFacWarJoinRequest = 81,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corporation requests leaving factional warfare ")]
        CorpFacWarLeaveRequest = 82,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corporation withdrawing a request to join factional warfare ")]
        CorpWithdrawlFacWarJoinRequest = 83,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corporation withdrawing a request to leave factional warfare ")]
        CorpWithdrawlFacWarLeaveRequest = 84,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Corporation liquidation ")]
        CorpLiquidation = 85,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Territorial Claim Unit under attack ")]
        TerritorialClaimUnderAttack = 86,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Sovereignty Blockade Unit under attack ")]
        SovereigntyBlockadeUnderAttack = 87,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Infrastructure Hub under attack ")]
        InfrastructureHubUnderAttack = 88
    }
}
