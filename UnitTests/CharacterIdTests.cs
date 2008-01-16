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

            Assert.AreEqual(797400947, charId.CharacterIDItems[0].characterID);
            Assert.AreEqual("CCP Garthagk", charId.CharacterIDItems[0].name);
        }

        [Test]
        public void TestCharIdToName()
        {
            CharacterID charId = EveApi.GetCharacterIDName("test123");

            Assert.AreEqual(797400947, charId.CharacterIDItems[0].characterID);
            Assert.AreEqual("CCP Garthagk", charId.CharacterIDItems[0].name);
        }
    }
}