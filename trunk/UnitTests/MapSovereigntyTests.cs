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

            for (int i = 0; i < mapSovereignty.MapSystemSovereigntyItems.Length; i++)
            {
                // FIXME
                //Assert.AreEqual(mapSovereignty.MapSystemSovereigntyItems[i].ConstellationSovereignty, cachedMapSovereignty.MapSystemSovereigntyItems[i].ConstellationSovereignty);
                Assert.AreEqual(mapSovereignty.MapSystemSovereigntyItems[i].AllianceId, cachedMapSovereignty.MapSystemSovereigntyItems[i].AllianceId);
            }
        }
    }
}
