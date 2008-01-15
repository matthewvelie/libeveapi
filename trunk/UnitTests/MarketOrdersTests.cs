using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class MarketOrdersTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetCharMarketOrdersTest()
        {
            MarketOrder marketOrder = EveApi.GetMarketOrderList(MarketOrderType.Character, "userId", "charId", "apiKey");   

            Assert.AreEqual(9, marketOrder.MarketOrderItems.Length);
            Assert.AreEqual(150208955, marketOrder.MarketOrderItems[0].charID);
            Assert.AreEqual(60010783, marketOrder.MarketOrderItems[0].stationID);
            Assert.AreEqual(325.00, marketOrder.MarketOrderItems[0].price);

        }

        [Test]
        public void GetCorpMarketOrdersTest()
        {
            MarketOrder marketOrder = EveApi.GetMarketOrderList(MarketOrderType.Corporation, "userId", "charId", "apiKey");

            Assert.AreEqual(9, marketOrder.MarketOrderItems.Length);
            Assert.AreEqual(150208955, marketOrder.MarketOrderItems[0].charID);
            Assert.AreEqual(60010783, marketOrder.MarketOrderItems[0].stationID);
            Assert.AreEqual(325.00, marketOrder.MarketOrderItems[0].price);
        }

        [Test]
        public void MarketOrderPersist()
        {
            ResponseCache.Clear();

            MarketOrder marketOrder = EveApi.GetMarketOrderList(MarketOrderType.Corporation, "userId", "charId", "apiKey");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            MarketOrder cachedmarketOrder = EveApi.GetMarketOrderList(MarketOrderType.Corporation, "userId", "charId", "apiKey");

            Assert.AreEqual(marketOrder.CachedUntilLocal, cachedmarketOrder.CachedUntilLocal);


            for (int i = 0; i < marketOrder.MarketOrderItems.Length; i++)
            {
                Assert.AreEqual(marketOrder.MarketOrderItems[i].accountKey, cachedmarketOrder.MarketOrderItems[i].accountKey);
                Assert.AreEqual(marketOrder.MarketOrderItems[i].charID, cachedmarketOrder.MarketOrderItems[i].charID);
                Assert.AreEqual(marketOrder.MarketOrderItems[i].minVolume, cachedmarketOrder.MarketOrderItems[i].minVolume);
            }
            
        }
    }
}
