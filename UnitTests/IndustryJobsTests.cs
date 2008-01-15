using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class IndustryJobsTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetCharIndustryJobsTest()
        {
            IndustryJobList jobList = EveApi.GetIndustryJobList(IndustryJobListType.Character, "userID", "characterID", "fullApiKey");

            Assert.AreEqual(22, jobList.IndustryJobListItems.Length);

            Assert.AreEqual(444, jobList.IndustryJobListItems[0].jobID);
            Assert.AreEqual(60010783, jobList.IndustryJobListItems[0].containerID);
            Assert.AreEqual(60010783, jobList.IndustryJobListItems[0].installedItemLocationID);
        }

        [Test]
        public void GetCorpIndustryJobsTest()
        {
            IndustryJobList jobList = EveApi.GetIndustryJobList(IndustryJobListType.Corporation, "userID", "characterID", "fullApiKey");

            Assert.AreEqual(22, jobList.IndustryJobListItems.Length);

            Assert.AreEqual(444, jobList.IndustryJobListItems[0].jobID);
            Assert.AreEqual(60010783, jobList.IndustryJobListItems[0].containerID);
            Assert.AreEqual(60010783, jobList.IndustryJobListItems[0].installedItemLocationID);
        }

        [Test]
        public void IndustryJobsPersist()
        {
            ResponseCache.Clear();

            IndustryJobList industryJobList = EveApi.GetIndustryJobList(IndustryJobListType.Corporation, "userId", "charId", "apiKey");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            IndustryJobList cachedIndustryJobList = EveApi.GetIndustryJobList(IndustryJobListType.Corporation, "userId", "charId", "apiKey");

            Assert.AreEqual(industryJobList.CachedUntilLocal, cachedIndustryJobList.CachedUntilLocal);

            
            for (int i = 0; i < industryJobList.IndustryJobListItems.Length; i++)
            {
                Assert.AreEqual(industryJobList.IndustryJobListItems[i].jobID, cachedIndustryJobList.IndustryJobListItems[i].jobID);
                Assert.AreEqual(industryJobList.IndustryJobListItems[i].assemblyLineID, cachedIndustryJobList.IndustryJobListItems[i].assemblyLineID);
                Assert.AreEqual(industryJobList.IndustryJobListItems[i].completed, cachedIndustryJobList.IndustryJobListItems[i].completed);
            }
            
        }
    }
}
