using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents a industry jobs that have been performed and are currently in progress response from the eve api
    /// http://wiki.eve-dev.net/APIv2_Char_IndustryJobs_XML
    /// </summary>
    public class IndustryJobList : ApiResponse
    {
        private IndustryJobListItem[] industryJobListItems = new IndustryJobListItem[0];

        /// <summary>
        /// 
        /// </summary>
        public IndustryJobListItem[] IndustryJobListItems
        {
            get { return industryJobListItems; }
            set { industryJobListItems = value; }
        }

        /// <summary>
        /// Create an IndustryJobList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc">An XML File containing the science and industry job list</param>
        /// <returns><see cref="IndustryJobList"/></returns>
        public static IndustryJobList FromXmlDocument(XmlDocument xmlDoc)
        {
            IndustryJobList industryJobList = new IndustryJobList();
            industryJobList.ParseCommonElements(xmlDoc);

            List<IndustryJobListItem> jobs = new List<IndustryJobListItem>();
            foreach (XmlNode node in xmlDoc.SelectNodes("//rowset[@name='jobs']/row"))
            {
                jobs.Add(ParseIndustryJobRow(node, industryJobList));
            }
            industryJobList.IndustryJobListItems = jobs.ToArray();

            return industryJobList;
        }

        /// <summary>
        /// Create an IndustryJobListItem by parsing a single row
        /// </summary>
        /// <param name="industryJobRow">An xml row containing an industry job</param>
        /// <param name="industryJobList"></param>
        /// <returns></returns>
        protected static IndustryJobListItem ParseIndustryJobRow(XmlNode industryJobRow, IndustryJobList industryJobList)
        {
            IndustryJobListItem IndustryJobListItem = new IndustryJobListItem();

            IndustryJobListItem.JobId = Convert.ToInt32(industryJobRow.Attributes["jobID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.AssemblyLineId = Convert.ToInt32(industryJobRow.Attributes["assemblyLineID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.ContainerId = Convert.ToInt32(industryJobRow.Attributes["containerID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledItemId = Convert.ToInt32(industryJobRow.Attributes["installedItemID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledItemLocationId = Convert.ToInt32(industryJobRow.Attributes["installedItemLocationID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledItemQuantity = Convert.ToInt32(industryJobRow.Attributes["installedItemQuantity"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledItemProductivityLevel = Convert.ToInt32(industryJobRow.Attributes["installedItemProductivityLevel"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledItemMaterialLevel = Convert.ToInt32(industryJobRow.Attributes["installedItemMaterialLevel"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledItemLicensedProductionRunsRemaining = Convert.ToInt32(industryJobRow.Attributes["installedItemLicensedProductionRunsRemaining"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.OutputLocationId = Convert.ToInt32(industryJobRow.Attributes["outputLocationID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstallerId = Convert.ToInt32(industryJobRow.Attributes["installerID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.Runs = Convert.ToInt32(industryJobRow.Attributes["runs"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.LicensedProductionRuns = Convert.ToInt32(industryJobRow.Attributes["licensedProductionRuns"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledInSolarSystemId = Convert.ToInt32(industryJobRow.Attributes["installedInSolarSystemID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.ContainerLocationId = Convert.ToInt32(industryJobRow.Attributes["containerLocationID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.MaterialMultiplier = Convert.ToDouble(industryJobRow.Attributes["materialMultiplier"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.CharMaterialMultiplier = Convert.ToDouble(industryJobRow.Attributes["charMaterialMultiplier"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.TimeMultiplier = Convert.ToDouble(industryJobRow.Attributes["timeMultiplier"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.CharTimeMultiplier = Convert.ToDouble(industryJobRow.Attributes["charTimeMultiplier"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledItemTypeId = Convert.ToInt32(industryJobRow.Attributes["installedItemTypeID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.OutputTypeId = Convert.ToInt32(industryJobRow.Attributes["outputTypeID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.ContainerTypeId = Convert.ToInt32(industryJobRow.Attributes["containerTypeID"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledItemCopy = Convert.ToBoolean(Convert.ToInt32(industryJobRow.Attributes["installedItemCopy"].InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            IndustryJobListItem.Completed = Convert.ToBoolean(Convert.ToInt32(industryJobRow.Attributes["completed"].InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            IndustryJobListItem.CompletedSuccessfully = Convert.ToBoolean(Convert.ToInt32(industryJobRow.Attributes["completedSuccessfully"].InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            IndustryJobListItem.InstalledItemFlag = Convert.ToInt32(industryJobRow.Attributes["installedItemFlag"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.OutputFlag = Convert.ToInt32(industryJobRow.Attributes["outputFlag"].InnerText, CultureInfo.InvariantCulture);
            IndustryJobListItem.ActivityId = Convert.ToInt32(industryJobRow.Attributes["activityID"].InnerText, CultureInfo.InvariantCulture);

            switch (Convert.ToInt32(industryJobRow.Attributes["activityID"].InnerText, CultureInfo.InvariantCulture))
            {
                case 1:
                    IndustryJobListItem.Activity = Activities.Manufacturing;
                    break;
                case 2:
                    IndustryJobListItem.Activity = Activities.TechnologyResearch;
                    break;
                case 3:
                    IndustryJobListItem.Activity = Activities.TimeEfficiency;
                    break;
                case 4:
                    IndustryJobListItem.Activity = Activities.MaterialEfficiency;
                    break;
                case 5:
                    IndustryJobListItem.Activity = Activities.Copying;
                    break;
                case 6:
                    IndustryJobListItem.Activity = Activities.Duplicating;
                    break;
                case 7:
                    IndustryJobListItem.Activity = Activities.ReverseEngineering;
                    break;
                case 8:
                    IndustryJobListItem.Activity = Activities.Invention;
                    break;
                default:
                    IndustryJobListItem.Activity = Activities.Unknown;
                    break;
            }

            switch (Convert.ToInt32(industryJobRow.Attributes["completedStatus"].InnerText, CultureInfo.InvariantCulture))
            {
                case 0:
                    IndustryJobListItem.CompletedStatus = IndustryJobCompletedStatuses.Failed;
                    break;
                case 1:
                    IndustryJobListItem.CompletedStatus = IndustryJobCompletedStatuses.Delivered;
                    break;
                case 2:
                    IndustryJobListItem.CompletedStatus = IndustryJobCompletedStatuses.Aborted;
                    break;
                case 3:
                    IndustryJobListItem.CompletedStatus = IndustryJobCompletedStatuses.GM_Aborted;
                    break;
                case 4:
                    IndustryJobListItem.CompletedStatus = IndustryJobCompletedStatuses.Unachored;
                    break;
                case 5:
                    IndustryJobListItem.CompletedStatus = IndustryJobCompletedStatuses.Destroyed;
                    break;
                default:
                    break;
            }
            
            IndustryJobListItem.InstallTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(industryJobRow.Attributes["installTime"].InnerText);
            IndustryJobListItem.BeginProductionTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(industryJobRow.Attributes["beginProductionTime"].InnerText);
            IndustryJobListItem.EndProductionTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(industryJobRow.Attributes["endProductionTime"].InnerText);
            IndustryJobListItem.PauseProductionTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(industryJobRow.Attributes["pauseProductionTime"].InnerText);

            IndustryJobListItem.InstallTimeLocal = TimeUtilities.ConvertCCPToLocalTime(IndustryJobListItem.InstallTime);
            IndustryJobListItem.BeginProductionTimeLocal = TimeUtilities.ConvertCCPToLocalTime(IndustryJobListItem.BeginProductionTime);
            IndustryJobListItem.EndProductionTimeLocal = TimeUtilities.ConvertCCPToLocalTime(IndustryJobListItem.EndProductionTime);
            IndustryJobListItem.PauseProductionTimeLocal = TimeUtilities.ConvertCCPToLocalTime(IndustryJobListItem.PauseProductionTime);

            return IndustryJobListItem;
        }

        /// <summary>
        /// A representation of an industry job
        /// </summary>
        public class IndustryJobListItem
        {
            private int jobId;
            private int assemblyLineId;
            private int containerId;
            private int installedItemId;
            private int installedItemLocationId;
            private int installedItemQuantity;
            private int installedItemProductivityLevel;
            private int installedItemMaterialLevel;
            private int installedItemLicensedProductionRunsRemaining;
            private int outputLocationId;
            private int installerId;
            private int runs;
            private int licensedProductionRuns;
            private int installedInSolarSystemId;
            private int containerLocationId;
            private double materialMultiplier;
            private double charMaterialMultiplier;
            private double timeMultiplier;
            private double charTimeMultiplier;
            private int installedItemTypeId;
            private int outputTypeId;
            private int containerTypeId;
            private bool installedItemCopy;
            private bool completed;
            private bool completedSuccessfully;
            private int installedItemFlag;
            private int outputFlag;
            private int activityId;
            private Activities activity;
            private IndustryJobCompletedStatuses completedStatus;
            private DateTime installTime;
            private DateTime beginProductionTime;
            private DateTime endProductionTime;
            private DateTime pauseProductionTime;
            private DateTime installTimeLocal;
            private DateTime beginProductionTimeLocal;
            private DateTime endProductionTimeLocal;
            private DateTime pauseProductionTimeLocal;

            /// <summary>
            /// This is the unique job id that is assigned 
            /// to the job by the eve system
            /// </summary>
            public int JobId
            {
                get { return jobId; }
                set { jobId = value; }
            }

            /// <summary>
            /// This is the assembly line that it is installed into if in a station
            /// </summary>
            public int AssemblyLineId
            {
                get { return assemblyLineId; }
                set { assemblyLineId = value; }
            }

            /// <summary>
            /// 
            /// </summary>
            public int ContainerId
            {
                get { return containerId; }
                set { containerId = value; }
            }

            /// <summary>
            /// This is the itemId of the item that was
            /// installed for whatever factory job was happening, this
            /// isnt really useful as it can change, but it will link back
            /// to something in your asset list (hopefully)
            /// </summary>
            public int InstalledItemId
            {
                get { return installedItemId; }
                set { installedItemId = value; }
            }

            /// <summary>
            /// This is the locationId of where the item was installed
            /// </summary>
            public int InstalledItemLocationId
            {
                get { return installedItemLocationId; }
                set { installedItemLocationId = value; }
            }

            /// <summary>
            /// This is how many of the item were installed, (usually 1)
            /// </summary>
            public int InstalledItemQuantity
            {
                get { return installedItemQuantity; }
                set { installedItemQuantity = value; }
            }

            /// <summary>
            /// This is the blueprints Productivity Level (TE)
            /// </summary>
            public int InstalledItemProductivityLevel
            {
                get { return installedItemProductivityLevel; }
                set { installedItemProductivityLevel = value; }
            }

            /// <summary>
            /// This is the blueprints Material Level (ME)
            /// </summary>
            public int InstalledItemMaterialLevel
            {
                get { return installedItemMaterialLevel; }
                set { installedItemMaterialLevel = value; }
            }

            /// <summary>
            /// This is how many production runs are left on the
            /// blueprint that was installed.  A -1 represents a BPO
            /// with unlimited copies left.
            /// </summary>
            public int InstalledItemLicensedProductionRunsRemaining
            {
                get { return installedItemLicensedProductionRunsRemaining; }
                set { installedItemLicensedProductionRunsRemaining = value; }
            }

            /// <summary>
            /// This is where the output of the job will be placed
            /// </summary>
            public int OutputLocationId
            {
                get { return outputLocationId; }
                set { outputLocationId = value; }
            }

            /// <summary>
            /// The characterId of the person who installed the job
            /// </summary>
            public int InstallerId
            {
                get { return installerId; }
                set { installerId = value; }
            }


            /// <summary>
            /// This is how many runs of the object are being made.
            /// </summary>
            public int Runs
            {
                get { return runs; }
                set { runs = value; }
            }


            /// <summary>
            /// 
            /// </summary>
            public int LicensedProductionRuns
            {
                get { return licensedProductionRuns; }
                set { licensedProductionRuns = value; }
            }


            /// <summary>
            /// This is the solarsystemId of where the job was installed
            /// </summary>
            public int InstalledInSolarSystemId
            {
                get { return installedInSolarSystemId; }
                set { installedInSolarSystemId = value; }
            }


            /// <summary>
            /// Where the container is located at, usually a moon or station.
            /// </summary>
            public int ContainerLocationId
            {
                get { return containerLocationId; }
                set { containerLocationId = value; }
            }


            /// <summary>
            /// This is the ME multiplier from the installation place.
            /// </summary>
            public double MaterialMultiplier
            {
                get { return materialMultiplier; }
                set { materialMultiplier = value; }
            }


            /// <summary>
            /// This is the ME multiplier that id done by the character's skills
            /// </summary>
            public double CharMaterialMultiplier
            {
                get { return charMaterialMultiplier; }
                set { charMaterialMultiplier = value; }
            }


            /// <summary>
            /// This is the TE multiplier of the station
            /// </summary>
            public double TimeMultiplier
            {
                get { return timeMultiplier; }
                set { timeMultiplier = value; }
            }


            /// <summary>
            /// The TE multiplier that id done by the character's skills
            /// </summary>
            public double CharTimeMultiplier
            {
                get { return charTimeMultiplier; }
                set { charTimeMultiplier = value; }
            }


            /// <summary>
            /// This is the typeId of the item that was installed (a blueprint)
            /// </summary>
            public int InstalledItemTypeId
            {
                get { return installedItemTypeId; }
                set { installedItemTypeId = value; }
            }


            /// <summary>
            /// This is the typeId of what will be outputted when the item
            /// is finished doing whatever it is doing.  For research this will
            /// be the blueprint itself, for manufacturing this will be the item
            /// </summary>
            public int OutputTypeId
            {
                get { return outputTypeId; }
                set { outputTypeId = value; }
            }


            /// <summary>
            /// This is the lab the items are currently in
            /// Can be looked up like any typeId, usually a mobile lab 
            /// or something similar
            /// </summary>
            public int ContainerTypeId
            {
                get { return containerTypeId; }
                set { containerTypeId = value; }
            }

            /// <summary>
            /// This is a bool value if the blueprint installed is a copy or not
            /// </summary>
            public bool InstalledItemCopy
            {
                get { return installedItemCopy; }
                set { installedItemCopy = value; }
            }

            /// <summary>
            /// This is a boolean value if the item has completed or not
            /// </summary>
            public bool Completed
            {
                get { return completed; }
                set { completed = value; }
            }

            /// <summary>
            /// Boolean value if the job completed successfully or not
            /// </summary>
            public bool CompletedSuccessfully
            {
                get { return completedSuccessfully; }
                set { completedSuccessfully = value; }
            }

            /// <summary>
            /// Flags, same as used in the assets
            /// </summary>
            public int InstalledItemFlag
            {
                get { return installedItemFlag; }
                set { installedItemFlag = value; }
            }

            /// <summary>
            /// Flags, same as used in the assets
            /// </summary>
            public int OutputFlag
            {
                get { return outputFlag; }
                set { outputFlag = value; }
            }

            /// <summary>
            /// This is what kind of activity was going on with the item
            /// (use enum Activities)
            /// </summary>
            public int ActivityId
            {
                get { return activityId; }
                set { activityId = value; }
            }

            /// <summary>
            /// ENUM of what activity is currently being done
            /// </summary>
            public Activities Activity
            {
                get { return activity; }
                set { activity = value; }
            }

            /// <summary>
            /// Status of the item when it was completed
            /// </summary>
            public IndustryJobCompletedStatuses CompletedStatus
            {
                get { return completedStatus; }
                set { completedStatus = value; }
            }

            /// <summary>
            /// When this item was installed in ccp time
            /// </summary>
            public DateTime InstallTime
            {
                get { return installTime; }
                set { installTime = value; }
            }

            /// <summary>
            /// When production time started in ccp time (different than install time if a queue)
            /// </summary>
            public DateTime BeginProductionTime
            {
                get { return beginProductionTime; }
                set { beginProductionTime = value; }
            }

            /// <summary>
            /// When the job will be finished in ccp time.
            /// </summary>
            public DateTime EndProductionTime
            {
                get { return endProductionTime; }
                set { endProductionTime = value; }
            }

            /// <summary>
            /// 
            /// </summary>
            public DateTime PauseProductionTime
            {
                get { return pauseProductionTime; }
                set { pauseProductionTime = value; }
            }

            /// <summary>
            /// When this item was installed in local time.
            /// </summary>
            public DateTime InstallTimeLocal
            {
                get { return installTimeLocal; }
                set { installTimeLocal = value; }
            }

            /// <summary>
            /// When production time started in local time (different than install time if a queue)
            /// </summary>
            public DateTime BeginProductionTimeLocal
            {
                get { return beginProductionTimeLocal; }
                set { beginProductionTimeLocal = value; }
            }

            /// <summary>
            /// When the job will be finished in local time.
            /// </summary>
            public DateTime EndProductionTimeLocal
            {
                get { return endProductionTimeLocal; }
                set { endProductionTimeLocal = value; }
            }

            /// <summary>
            /// 
            /// </summary>
            public DateTime PauseProductionTimeLocal
            {
                get { return pauseProductionTimeLocal; }
                set { pauseProductionTimeLocal = value; }
            }
        }
    }

    /// <summary>
    /// Is this a corporation or character type of job
    /// </summary>
    public enum IndustryJobListType
    {
        /// <summary>
        /// This is a job for the Corporation
        /// </summary>
        Corporation,
        /// <summary>
        /// This is a personal job for the Character
        /// </summary>
        Character
    }

    /// <summary>
    /// This represents the status of a job once completed
    /// </summary>
    public enum IndustryJobCompletedStatuses
    {
        /// <summary>
        /// It was completed; however, the job failed (invention)
        /// </summary>
        Failed = 0,
        /// <summary>
        /// The job was completed and delivered successfully
        /// </summary>
        Delivered = 1,
        /// <summary>
        /// The job was completed, because it was aborted
        /// </summary>
        Aborted = 2,
        /// <summary>
        /// A GM Completed/Aborted the job
        /// </summary>
        GM_Aborted = 3,
        /// <summary>
        /// The job was completed because the item it was in was unanchored
        /// </summary>
        Unachored = 4,
        /// <summary>
        /// The job is considered completed because the item was destroyed (mobile lab, etc).
        /// </summary>
        Destroyed = 5
    }

    /// <summary>
    /// The different activities that can occur for an Science and Industry job
    /// </summary>
    public enum Activities
    {
        /// <summary>
        /// Manufacturing
        /// </summary>
        Manufacturing = 1,
        /// <summary>
        /// Researching Technology (not in game at current)
        /// </summary>
        TechnologyResearch = 2,
        /// <summary>
        /// Time Efficiency Research
        /// </summary>
        TimeEfficiency = 3,
        /// <summary>
        /// Material Efficiency Research
        /// </summary>
        MaterialEfficiency = 4,
        /// <summary>
        /// Blueprint Copying
        /// </summary>
        Copying = 5,
        /// <summary>
        /// Blueprint Duplication (not in gate at current)
        /// </summary>
        Duplicating = 6,
        /// <summary>
        /// Reverse Engineering (not in game at current)
        /// </summary>
        ReverseEngineering = 7,
        /// <summary>
        /// Blueprint Invention
        /// </summary>
        Invention = 8,
        /// <summary>
        /// Unknown type of job
        /// </summary>
        Unknown = 0
    }
}
