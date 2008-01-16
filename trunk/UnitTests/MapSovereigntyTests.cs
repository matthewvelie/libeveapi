using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class MapSovereigntyTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void JumpsPersist()
        {
            ResponseCache.Clear();

            MapSovereignty mapSovereignty = EveApi.GetMapSovereignty();
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            MapSovereignty cachedMapSovereignty = EveApi.GetMapSovereignty();

            Assert.AreEqual(mapSovereignty.CachedUntilLocal, cachedMapSovereignty.CachedUntilLocal);

            for (int i = 0; i < mapSovereignty.MapSystemSovereignty.Length; i++)
            {
                Assert.AreEqual(mapSovereignty.MapSystemSovereignty[i].ConstellationSovereignty, cachedMapSovereignty.MapSystemSovereignty[i].ConstellationSovereignty);
                Assert.AreEqual(mapSovereignty.MapSystemSovereignty[i].AllianceID, cachedMapSovereignty.MapSystemSovereignty[i].AllianceID);
            }
        }
    }
}
