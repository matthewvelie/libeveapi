using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents a industry jobs that have been performed and are currently in progress response from the eve api
    /// http://wiki.eve-dev.net/APIv2_Char_IndustryJobs_XML
    /// </summary>
    public class IndustryJobList : ApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public IndustryJobListItem[] IndustryJobListItems = new IndustryJobListItem[0];

        /// <summary>
        /// Create an IndustryJobList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc">An XML File containing the science and industry job list</param>
        /// <returns><see cref="IndustryJobList"/></returns>
        public static IndustryJobList FromXmlDocument(XmlDocument xmlDoc)
        {
            IndustryJobList IndustryJobList = new IndustryJobList();
            IndustryJobList.ParseCommonElements(xmlDoc);

            List<IndustryJobListItem> jobs = new List<IndustryJobListItem>();
            foreach (XmlNode node in xmlDoc.SelectNodes("//rowset[@name='jobs']/row"))
            {
                jobs.Add(ParseIndustryJobRow(node));
            }
            IndustryJobList.IndustryJobListItems = jobs.ToArray();

            return IndustryJobList;
        }

        /// <summary>
        /// Create an IndustryJobListItem by parsing a single row
        /// </summary>
        /// <param name="industryJobRow">An xml row containing an industry job</param>
        /// <returns></returns>
        protected static IndustryJobListItem ParseIndustryJobRow(XmlNode industryJobRow)
        {
            IndustryJobListItem IndustryJobListItem = new IndustryJobListItem();

            IndustryJobListItem.JobId = Convert.ToInt32(industryJobRow.Attributes["jobID"].InnerText);
            IndustryJobListItem.AssemblyLineId = Convert.ToInt64(industryJobRow.Attributes["assemblyLineID"].InnerText);
            IndustryJobListItem.ContainerId = Convert.ToInt64(industryJobRow.Attributes["containerID"].InnerText);
            IndustryJobListItem.InstalledItemId = Convert.ToInt64(industryJobRow.Attributes["installedItemID"].InnerText);
            IndustryJobListItem.InstalledItemLocationId = Convert.ToInt64(industryJobRow.Attributes["installedItemLocationID"].InnerText);
            IndustryJobListItem.InstalledItemQuantity = Convert.ToInt32(industryJobRow.Attributes["installedItemQuantity"].InnerText);
            IndustryJobListItem.InstalledItemProductivityLevel = Convert.ToInt32(industryJobRow.Attributes["installedItemProductivityLevel"].InnerText);
            IndustryJobListItem.InstalledItemMaterialLevel = Convert.ToInt32(industryJobRow.Attributes["installedItemMaterialLevel"].InnerText);
            IndustryJobListItem.InstalledItemLicensedProductionRunsRemaining = Convert.ToInt32(industryJobRow.Attributes["installedItemLicensedProductionRunsRemaining"].InnerText);
            IndustryJobListItem.OutputLocationId = Convert.ToInt64(industryJobRow.Attributes["outputLocationID"].InnerText);
            IndustryJobListItem.InstallerId = Convert.ToInt64(industryJobRow.Attributes["installerID"].InnerText);
            IndustryJobListItem.Runs = Convert.ToInt32(industryJobRow.Attributes["runs"].InnerText);
            IndustryJobListItem.LicensedProductionRuns = Convert.ToInt32(industryJobRow.Attributes["licensedProductionRuns"].InnerText);
            IndustryJobListItem.InstalledInSolarSystemId = Convert.ToInt64(industryJobRow.Attributes["installedInSolarSystemID"].InnerText);
            IndustryJobListItem.ContainerLocationId = Convert.ToInt64(industryJobRow.Attributes["containerLocationID"].InnerText);
            IndustryJobListItem.MaterialMultiplier = (float)Convert.ToDouble(industryJobRow.Attributes["materialMultiplier"].InnerText);
            IndustryJobListItem.CharMaterialMultiplier = (float)Convert.ToDouble(industryJobRow.Attributes["charMaterialMultiplier"].InnerText);
            IndustryJobListItem.TimeMultiplier = (float)Convert.ToDouble(industryJobRow.Attributes["timeMultiplier"].InnerText);
            IndustryJobListItem.CharTimeMultiplier = (float)Convert.ToDouble(industryJobRow.Attributes["charTimeMultiplier"].InnerText);
            IndustryJobListItem.InstalledItemTypeId = Convert.ToInt64(industryJobRow.Attributes["installedItemTypeID"].InnerText);
            IndustryJobListItem.OutputTypeId = Convert.ToInt64(industryJobRow.Attributes["outputTypeID"].InnerText);
            IndustryJobListItem.ContainerTypeId = Convert.ToInt64(industryJobRow.Attributes["containerTypeID"].InnerText);
            IndustryJobListItem.InstalledItemCopy = Convert.ToInt32(industryJobRow.Attributes["installedItemCopy"].InnerText);
            IndustryJobListItem.Completed = Convert.ToBoolean(Convert.ToInt32(industryJobRow.Attributes["completed"].InnerText));
            IndustryJobListItem.CompletedSuccessfully = Convert.ToBoolean(Convert.ToInt32(industryJobRow.Attributes["completedSuccessfully"].InnerText));
            IndustryJobListItem.InstalledItemFlag = Convert.ToInt32(industryJobRow.Attributes["installedItemFlag"].InnerText);
            IndustryJobListItem.OutputFlag = Convert.ToInt32(industryJobRow.Attributes["outputFlag"].InnerText);
            IndustryJobListItem.ActivityId = Convert.ToInt32(industryJobRow.Attributes["activityID"].InnerText);
            IndustryJobListItem.CompletedStatus = Convert.ToInt32(industryJobRow.Attributes["completedStatus"].InnerText);
            IndustryJobListItem.InstallTime = Convert.ToDateTime(industryJobRow.Attributes["installTime"].InnerText);
            IndustryJobListItem.BeginProductionTime = Convert.ToDateTime(industryJobRow.Attributes["beginProductionTime"].InnerText);
            IndustryJobListItem.EndProductionTime = Convert.ToDateTime(industryJobRow.Attributes["endProductionTime"].InnerText);
            IndustryJobListItem.PauseProductionTime = Convert.ToDateTime(industryJobRow.Attributes["pauseProductionTime"].InnerText);

            return IndustryJobListItem;
        }
    }

    /// <summary>
    /// A representation of an industry job
    /// </summary>
    public class IndustryJobListItem
    {
        /// <summary>
        /// This is the unique job id that is assigned 
        /// to the job by the eve system
        /// </summary>
        public int JobId;

        /// <summary>
        /// This is the assembly line that it is installed into if in a station
        /// </summary>
        public long AssemblyLineId;

        /// <summary>
        /// 
        /// </summary>
        public long ContainerId;

        /// <summary>
        /// This is the itemId of the item that was
        /// installed for whatever factory job was happening, this
        /// isnt really useful as it can change, but it will link back
        /// to something in your asset list (hopefully)
        /// </summary>
        public long InstalledItemId;

        /// <summary>
        /// This is the locationId of where the item was installed
        /// </summary>
        public long InstalledItemLocationId;

        /// <summary>
        /// This is how many of the item were installed, (usually 1)
        /// </summary>
        public int InstalledItemQuantity;

        /// <summary>
        /// This is the blueprints Productivity Level (TE)
        /// </summary>
        public int InstalledItemProductivityLevel;

        /// <summary>
        /// This is the blueprints Material Level (ME)
        /// </summary>
        public int InstalledItemMaterialLevel;

        /// <summary>
        /// This is how many production runs are left on the
        /// blueprint that was installed.  A -1 represents a BPO
        /// with unlimited copies left.
        /// </summary>
        public int InstalledItemLicensedProductionRunsRemaining;


        /// <summary>
        /// This is where the output of the job will be placed
        /// </summary>
        public long OutputLocationId;

        /// <summary>
        /// The characterId of the person who installed the job
        /// </summary>
        public long InstallerId;


        /// <summary>
        /// This is how many runs of the object are being made.
        /// </summary>
        public int Runs;


        /// <summary>
        /// 
        /// </summary>
        public int LicensedProductionRuns;


        /// <summary>
        /// This is the solarsystemId of where the job was installed
        /// </summary>
        public long InstalledInSolarSystemId;


        /// <summary>
        /// Where the container is located at, usually a moon or station.
        /// </summary>
        public long ContainerLocationId;


        /// <summary>
        /// This is the ME multiplier from the installation place.
        /// </summary>
        public float MaterialMultiplier;


        /// <summary>
        /// This is the ME multiplier that id done by the character's skills
        /// </summary>
        public float CharMaterialMultiplier;


        /// <summary>
        /// This is the TE multiplier of the station
        /// </summary>
        public float TimeMultiplier;


        /// <summary>
        /// The TE multiplier that id done by the character's skills
        /// </summary>
        public float CharTimeMultiplier;


        /// <summary>
        /// This is the typeId of the item that was installed (a blueprint)
        /// </summary>
        public long InstalledItemTypeId;


        /// <summary>
        /// This is the typeId of what will be outputted when the item
        /// is finished doing whatever it is doing.  For research this will
        /// be the blueprint itself, for manufacturing this will be the item
        /// </summary>
        public long OutputTypeId;


        /// <summary>
        /// This is the lab the items are currently in
        /// Can be looked up like any typeId, usually a mobile lab 
        /// or something similar
        /// </summary>
        public long ContainerTypeId;

        /// <summary>
        /// 
        /// </summary>
        public int InstalledItemCopy;

        /// <summary>
        /// This is a boolean value if the item has completed or not
        /// </summary>
        public bool Completed;

        /// <summary>
        /// Boolean value if the job completed successfully or not
        /// </summary>
        public bool CompletedSuccessfully;

        /// <summary>
        /// Flags, same as used in the assets
        /// </summary>
        public int InstalledItemFlag;

        /// <summary>
        /// Flags, same as used in the assets
        /// </summary>
        public int OutputFlag;

        /// <summary>
        /// This is what kind of activity was going on with the item
        /// 3 = Time Efficiency, 4 = Material Research
        /// </summary>
        public int ActivityId;

        /// <summary>
        /// 1 = delivered, 2 = aborted, 3 = GM aborted, 4 = inflight unanchored, 5 = destroyed, 0 = failed
        /// </summary>
        public int CompletedStatus;

        /// <summary>
        /// When this item was installed
        /// </summary>
        public DateTime InstallTime;

        /// <summary>
        /// When production time started (different than install time if a queue)
        /// </summary>
        public DateTime BeginProductionTime;

        /// <summary>
        /// When the job will be finished
        /// </summary>
        public DateTime EndProductionTime;

        /// <summary>
        /// 
        /// </summary>
        public DateTime PauseProductionTime;
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
}
