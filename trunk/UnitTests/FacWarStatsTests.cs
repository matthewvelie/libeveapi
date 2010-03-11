using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    class FacWarStatsTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetCharFacWarStatsTests()
        {
/*
            FacWarStats stats = new FacWarStats();
            stats.CharacterFactionWarStats = EveApi.GetCharacterFactionWarStats(123, 456, "apiKey");

            Assert.AreEqual(500001, stats.CharacterFactionWarStats.FactionID);
            Assert.AreEqual("Caldari State", stats.CharacterFactionWarStats.FactionName);
            Assert.AreEqual(new DateTime(2008, 06, 10, 22, 10, 00), stats.CharacterFactionWarStats.Enlisted);
            Assert.AreEqual(4, stats.CharacterFactionWarStats.CurrentRank);
            
            Assert.AreEqual(4, stats.CharacterFactionWarStats.HighestRank);
            Assert.AreEqual(0, stats.CharacterFactionWarStats.KillsYesterday);
            Assert.AreEqual(0, stats.CharacterFactionWarStats.KillsLastWeek);
            Assert.AreEqual(0, stats.CharacterFactionWarStats.KillsTotal);
            Assert.AreEqual(0, stats.CharacterFactionWarStats.VictoryPointsYesterday);
            Assert.AreEqual(1044, stats.CharacterFactionWarStats.VictoryPointsLastWeek);
            Assert.AreEqual(0, stats.CharacterFactionWarStats.VictoryPointsTotal);
*/
        }

        [Test]
        public void FacWarStatsTestsPersist()
        {
            ResponseCache.Clear();
/*

            FacWarStats stats = new FacWarStats();
            stats.CharacterFactionWarStats = EveApi.GetCharacterFactionWarStats(123, 456, "apiKey");

            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            FacWarStats statsCached = new FacWarStats();
            statsCached.CharacterFactionWarStats = EveApi.GetCharacterFactionWarStats(987, 654, "apiKey");

            Assert.AreEqual(stats.CharacterFactionWarStats.CachedUntilLocal, statsCached.CachedUntilLocal);

            Assert.AreEqual(stats.CharacterFactionWarStats.FactionID, statsCached.CharacterFactionWarStats.FactionID);
            Assert.AreEqual(stats.CharacterFactionWarStats.FactionName, statsCached.CharacterFactionWarStats.FactionName);
            Assert.AreEqual(stats.CharacterFactionWarStats.Enlisted, statsCached.CharacterFactionWarStats.Enlisted);
            Assert.AreEqual(stats.CharacterFactionWarStats.CurrentRank, statsCached.CharacterFactionWarStats.CurrentRank);
            Assert.AreEqual(stats.CharacterFactionWarStats.KillsYesterday, statsCached.CharacterFactionWarStats.KillsYesterday);
            Assert.AreEqual(stats.CharacterFactionWarStats.KillsLastWeek, statsCached.CharacterFactionWarStats.KillsLastWeek);
            Assert.AreEqual(stats.CharacterFactionWarStats.KillsTotal, statsCached.CharacterFactionWarStats.KillsTotal);
            Assert.AreEqual(stats.CharacterFactionWarStats.VictoryPointsYesterday, statsCached.CharacterFactionWarStats.VictoryPointsYesterday);
            Assert.AreEqual(stats.CharacterFactionWarStats.VictoryPointsLastWeek, statsCached.CharacterFactionWarStats.VictoryPointsLastWeek);
            Assert.AreEqual(stats.CharacterFactionWarStats.VictoryPointsTotal, statsCached.CharacterFactionWarStats.VictoryPointsTotal);
*/
        }

    }
}
