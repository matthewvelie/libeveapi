using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class StarbaseDetailTests
    {
        [Test]
        public void GetStarbaseDetail()
        {
            ResponseCache.Clear();
            StarbaseDetail starbaseDetail = EveApi.GetStarbaseDetail("userId", "characterId", "fullApiKey", "itemId");

            Assert.AreEqual("3", starbaseDetail.UsageFlags);
            Assert.AreEqual("0", starbaseDetail.DeployFlags);
            Assert.AreEqual(true, starbaseDetail.AllowCorporationMembers);
            Assert.AreEqual(false, starbaseDetail.AllowAllianceMembers);
            Assert.AreEqual(false, starbaseDetail.claimSovereignty);

            Assert.AreEqual(false, starbaseDetail.OnStandingDropEnabled);
            Assert.AreEqual("0", starbaseDetail.OnStandingDropStanding);
            Assert.AreEqual(false, starbaseDetail.OnStatusDropEnabled);
            Assert.AreEqual("0", starbaseDetail.OnStatusDropStanding);
            Assert.AreEqual(false, starbaseDetail.OnAgressionEnabled);
            Assert.AreEqual(false, starbaseDetail.OnCorporationWarEnabled);

            Assert.AreEqual("3689", starbaseDetail.FuelList[0].TypeId);
            Assert.AreEqual(710, starbaseDetail.FuelList[0].Quantity);
        }

        [Test]
        public void StarbaseDetailPersist()
        {
            ResponseCache.Clear();
            StarbaseDetail starbaseDetail = EveApi.GetStarbaseDetail("userId", "characterId", "fullApiKey", "itemId");

            ResponseCache.SaveToFile("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.LoadFromFile("ResponseCache.xml");

            StarbaseDetail cachedStarbaseDetail = ResponseCache.Get(starbaseDetail.Url) as StarbaseDetail;

            Assert.AreEqual(starbaseDetail.UsageFlags, cachedStarbaseDetail.UsageFlags);
            Assert.AreEqual(starbaseDetail.DeployFlags, cachedStarbaseDetail.DeployFlags);
            Assert.AreEqual(starbaseDetail.AllowCorporationMembers, cachedStarbaseDetail.AllowCorporationMembers);
            Assert.AreEqual(starbaseDetail.AllowAllianceMembers, cachedStarbaseDetail.AllowAllianceMembers);
            Assert.AreEqual(starbaseDetail.claimSovereignty, cachedStarbaseDetail.claimSovereignty);

            Assert.AreEqual(starbaseDetail.OnStandingDropEnabled, cachedStarbaseDetail.OnStandingDropEnabled);
            Assert.AreEqual(starbaseDetail.OnStandingDropStanding, cachedStarbaseDetail.OnStandingDropStanding);
            Assert.AreEqual(starbaseDetail.OnStatusDropEnabled, cachedStarbaseDetail.OnStatusDropEnabled);
            Assert.AreEqual(starbaseDetail.OnStatusDropStanding, cachedStarbaseDetail.OnStatusDropStanding);
            Assert.AreEqual(starbaseDetail.OnAgressionEnabled, cachedStarbaseDetail.OnAgressionEnabled);
            Assert.AreEqual(starbaseDetail.OnCorporationWarEnabled, cachedStarbaseDetail.OnCorporationWarEnabled);

            for (int i = 0; i < starbaseDetail.FuelList.Length; i++)
            {
                Assert.AreEqual(starbaseDetail.FuelList[i].TypeId, cachedStarbaseDetail.FuelList[i].TypeId);
                Assert.AreEqual(starbaseDetail.FuelList[i].Quantity, cachedStarbaseDetail.FuelList[i].Quantity);
            }
        }
    }
}