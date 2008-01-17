using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class CharacterIdTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void TestCharNameToId()
        {
            CharacterID charId = EveApi.GetCharacterIDName(1234);

            Assert.AreEqual(797400947, charId.CharacterIDItems[0].CharacterID);
            Assert.AreEqual("CCP Garthagk", charId.CharacterIDItems[0].Name);
        }

        [Test]
        public void TestCharIdToName()
        {
            CharacterID charId = EveApi.GetCharacterIDName("test123");

            Assert.AreEqual(797400947, charId.CharacterIDItems[0].CharacterID);
            Assert.AreEqual("CCP Garthagk", charId.CharacterIDItems[0].Name);
        }

        [Test]
        public void PersistCharacterId()
        {
            ResponseCache.Clear();
            CharacterID cid = EveApi.GetCharacterIDName("test");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            CharacterID ccid = EveApi.GetCharacterIDName("test");

            Assert.AreEqual(cid.CachedUntilLocal, ccid.CachedUntilLocal);

            Assert.AreEqual(cid.CharacterIDItems[0].Name, ccid.CharacterIDItems[0].Name);
            Assert.AreEqual(cid.CharacterIDItems[0].CharacterID, ccid.CharacterIDItems[0].CharacterID);
        }
    }
}
