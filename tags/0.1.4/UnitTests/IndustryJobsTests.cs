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

            Assert.AreEqual(444, jobList.IndustryJobListItems[0].JobID);
            Assert.AreEqual(60010783, jobList.IndustryJobListItems[0].ContainerID);
            Assert.AreEqual(60010783, jobList.IndustryJobListItems[0].InstalledItemLocationID);
        }

        [Test]
        public void GetCorpIndustryJobsTest()
        {
            IndustryJobList jobList = EveApi.GetIndustryJobList(IndustryJobListType.Corporation, "userID", "characterID", "fullApiKey");

            Assert.AreEqual(22, jobList.IndustryJobListItems.Length);

            Assert.AreEqual(444, jobList.IndustryJobListItems[0].JobID);
            Assert.AreEqual(60010783, jobList.IndustryJobListItems[0].ContainerID);
            Assert.AreEqual(60010783, jobList.IndustryJobListItems[0].InstalledItemLocationID);
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
                Assert.AreEqual(industryJobList.IndustryJobListItems[i].JobID, cachedIndustryJobList.IndustryJobListItems[i].JobID);
                Assert.AreEqual(industryJobList.IndustryJobListItems[i].AssemblyLineID, cachedIndustryJobList.IndustryJobListItems[i].AssemblyLineID);
                Assert.AreEqual(industryJobList.IndustryJobListItems[i].Completed, cachedIndustryJobList.IndustryJobListItems[i].Completed);
            }
            
        }
    }
}
