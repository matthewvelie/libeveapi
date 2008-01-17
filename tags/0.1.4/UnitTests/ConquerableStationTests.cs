using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class ConquerableStationTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void StationData()
        {
            ConquerableStationList stationList = EveApi.GetConquerableStationList();

            Assert.AreEqual(233, stationList.conquerableStationList.Length);
            Assert.AreEqual(60014926, stationList.conquerableStationList[0].stationID);
            Assert.AreEqual("The Alamo", stationList.conquerableStationList[0].stationName);
            Assert.AreEqual(12295, stationList.conquerableStationList[0].stationTypeID);
        }

        [Test]
        public void StationPersist()
        {
            ResponseCache.Clear();

            ConquerableStationList stationList = EveApi.GetConquerableStationList();
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            ConquerableStationList cachedstationList = EveApi.GetConquerableStationList();

            Assert.AreEqual(stationList.CachedUntilLocal, cachedstationList.CachedUntilLocal);


            for (int i = 0; i < stationList.conquerableStationList.Length; i++)
            {
                Assert.AreEqual(stationList.conquerableStationList[i].corporationID, cachedstationList.conquerableStationList[i].corporationID);
                Assert.AreEqual(stationList.conquerableStationList[i].corporationName, cachedstationList.conquerableStationList[i].corporationName);
                Assert.AreEqual(stationList.conquerableStationList[i].solarSystemID, cachedstationList.conquerableStationList[i].solarSystemID);
            }
            
        }
    }
}
