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
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
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

            IndustryJobListItem.jobID = Convert.ToInt32(industryJobRow.Attributes["jobID"].InnerText);
            IndustryJobListItem.assemblyLineID = Convert.ToInt64(industryJobRow.Attributes["assemblyLineID"].InnerText);
            IndustryJobListItem.containerID = Convert.ToInt64(industryJobRow.Attributes["containerID"].InnerText);
            IndustryJobListItem.installedItemID = Convert.ToInt64(industryJobRow.Attributes["installedItemID"].InnerText);
            IndustryJobListItem.installedItemLocationID = Convert.ToInt64(industryJobRow.Attributes["installedItemLocationID"].InnerText);
            IndustryJobListItem.installedItemQuantity = Convert.ToInt32(industryJobRow.Attributes["installedItemQuantity"].InnerText);
            IndustryJobListItem.installedItemProductivityLevel = Convert.ToInt32(industryJobRow.Attributes["installedItemProductivityLevel"].InnerText);
            IndustryJobListItem.installedItemMaterialLevel = Convert.ToInt32(industryJobRow.Attributes["installedItemMaterialLevel"].InnerText);
            IndustryJobListItem.installedItemLicensedProductionRunsRemaining = Convert.ToInt32(industryJobRow.Attributes["installedItemLicensedProductionRunsRemaining"].InnerText);
            IndustryJobListItem.outputLocationID = Convert.ToInt64(industryJobRow.Attributes["outputLocationID"].InnerText);
            IndustryJobListItem.installerID = Convert.ToInt64(industryJobRow.Attributes["installerID"].InnerText);
            IndustryJobListItem.runs = Convert.ToInt32(industryJobRow.Attributes["runs"].InnerText);
            IndustryJobListItem.licensedProductionRuns = Convert.ToInt32(industryJobRow.Attributes["licensedProductionRuns"].InnerText);
            IndustryJobListItem.installedInSolarSystemID = Convert.ToInt64(industryJobRow.Attributes["installedInSolarSystemID"].InnerText);
            IndustryJobListItem.containerLocationID = Convert.ToInt64(industryJobRow.Attributes["containerLocationID"].InnerText);
            IndustryJobListItem.materialMultiplier = (float)Convert.ToDouble(industryJobRow.Attributes["materialMultiplier"].InnerText);
            IndustryJobListItem.charMaterialMultiplier = (float)Convert.ToDouble(industryJobRow.Attributes["charMaterialMultiplier"].InnerText);
            IndustryJobListItem.timeMultiplier = (float)Convert.ToDouble(industryJobRow.Attributes["timeMultiplier"].InnerText);
            IndustryJobListItem.charTimeMultiplier = (float)Convert.ToDouble(industryJobRow.Attributes["charTimeMultiplier"].InnerText);
            IndustryJobListItem.installedItemTypeID = Convert.ToInt64(industryJobRow.Attributes["installedItemTypeID"].InnerText);
            IndustryJobListItem.outputTypeID = Convert.ToInt64(industryJobRow.Attributes["outputTypeID"].InnerText);
            IndustryJobListItem.containerTypeID = Convert.ToInt64(industryJobRow.Attributes["containerTypeID"].InnerText);
            IndustryJobListItem.installedItemCopy = Convert.ToInt32(industryJobRow.Attributes["installedItemCopy"].InnerText);
            IndustryJobListItem.completed = Convert.ToBoolean(Convert.ToInt32(industryJobRow.Attributes["completed"].InnerText));
            IndustryJobListItem.completedSuccessfully = Convert.ToBoolean(Convert.ToInt32(industryJobRow.Attributes["completedSuccessfully"].InnerText));
            IndustryJobListItem.installedItemFlag = Convert.ToInt32(industryJobRow.Attributes["installedItemFlag"].InnerText);
            IndustryJobListItem.outputFlag = Convert.ToInt32(industryJobRow.Attributes["outputFlag"].InnerText);
            IndustryJobListItem.activityID = Convert.ToInt32(industryJobRow.Attributes["activityID"].InnerText);
            IndustryJobListItem.completedStatus = Convert.ToInt32(industryJobRow.Attributes["completedStatus"].InnerText);
            IndustryJobListItem.installTime = Convert.ToDateTime(industryJobRow.Attributes["installTime"].InnerText);
            IndustryJobListItem.beginProductionTime = Convert.ToDateTime(industryJobRow.Attributes["beginProductionTime"].InnerText);
            IndustryJobListItem.endProductionTime = Convert.ToDateTime(industryJobRow.Attributes["endProductionTime"].InnerText);
            IndustryJobListItem.pauseProductionTime = Convert.ToDateTime(industryJobRow.Attributes["pauseProductionTime"].InnerText);

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
        public int jobID;

        /// <summary>
        /// This is the assembly line that it is installed into if in a station
        /// </summary>
        public long assemblyLineID;

        /// <summary>
        /// 
        /// </summary>
        public long containerID;

        /// <summary>
        /// This is the itemID of the item that was
        /// installed for whatever factory job was happening, this
        /// isnt really useful as it can change, but it will link back
        /// to something in your asset list (hopefully)
        /// </summary>
        public long installedItemID;

        /// <summary>
        /// This is the locationID of where the item was installed
        /// </summary>
        public long installedItemLocationID;

        /// <summary>
        /// This is how many of the item were installed, (usually 1)
        /// </summary>
        public int installedItemQuantity;

        /// <summary>
        /// This is the blueprints Productivity Level (TE)
        /// </summary>
        public int installedItemProductivityLevel;

        /// <summary>
        /// This is the blueprints Material Level (ME)
        /// </summary>
        public int installedItemMaterialLevel;

        /// <summary>
        /// This is how many production runs are left on the
        /// blueprint that was installed.  A -1 represents a BPO
        /// with unlimited copies left.
        /// </summary>
        public int installedItemLicensedProductionRunsRemaining;


        /// <summary>
        /// This is where the output of the job will be placed
        /// </summary>
        public long outputLocationID;

        /// <summary>
        /// The characterID of the person who installed the job
        /// </summary>
        public long installerID;


        /// <summary>
        /// This is how many runs of the object are being made.
        /// </summary>
        public int runs;


        /// <summary>
        /// 
        /// </summary>
        public int licensedProductionRuns;


        /// <summary>
        /// This is the solarsystemID of where the job was installed
        /// </summary>
        public long installedInSolarSystemID;


        /// <summary>
        /// Where the container is located at, usually a moon or station.
        /// </summary>
        public long containerLocationID;


        /// <summary>
        /// This is the ME multiplier from the installation place.
        /// </summary>
        public float materialMultiplier;


        /// <summary>
        /// This is the ME multiplier that id done by the character's skills
        /// </summary>
        public float charMaterialMultiplier;


        /// <summary>
        /// This is the TE multiplier of the station
        /// </summary>
        public float timeMultiplier;


        /// <summary>
        /// The TE multiplier that id done by the character's skills
        /// </summary>
        public float charTimeMultiplier;


        /// <summary>
        /// This is the typeID of the item that was installed (a blueprint)
        /// </summary>
        public long installedItemTypeID;


        /// <summary>
        /// This is the typeID of what will be outputted when the item
        /// is finished doing whatever it is doing.  For research this will
        /// be the blueprint itself, for manufacturing this will be the item
        /// </summary>
        public long outputTypeID;


        /// <summary>
        /// This is the lab the items are currently in
        /// Can be looked up like any typeID, usually a mobile lab 
        /// or something similar
        /// </summary>
        public long containerTypeID;

        /// <summary>
        /// 
        /// </summary>
        public int installedItemCopy;

        /// <summary>
        /// This is a boolean value if the item has completed or not
        /// </summary>
        public bool completed;

        /// <summary>
        /// Boolean value if the job completed successfully or not
        /// </summary>
        public bool completedSuccessfully;

        /// <summary>
        /// Flags, same as used in the assets
        /// </summary>
        public int installedItemFlag;

        /// <summary>
        /// Flags, same as used in the assets
        /// </summary>
        public int outputFlag;

        /// <summary>
        /// This is what kind of activity was going on with the item
        /// 3 = Time Efficiency, 4 = Material Research
        /// </summary>
        public int activityID;

        /// <summary>
        /// 1 = delivered, 2 = aborted, 3 = GM aborted, 4 = inflight unanchored, 5 = destroyed, 0 = failed
        /// </summary>
        public int completedStatus;

        /// <summary>
        /// When this item was installed
        /// </summary>
        public DateTime installTime;

        /// <summary>
        /// When production time started (different than install time if a queue)
        /// </summary>
        public DateTime beginProductionTime;

        /// <summary>
        /// When the job will be finished
        /// </summary>
        public DateTime endProductionTime;

        /// <summary>
        /// 
        /// </summary>
        public DateTime pauseProductionTime;
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
