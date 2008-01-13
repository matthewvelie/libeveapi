using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class CharacterListTests
    {
        [Test]
        public void GetCharacterList()
        {
            EveApi eveApi = new EveApi();
            CharacterList characterList = eveApi.GetAccountCharacters("asdf", "asdf");

            Assert.AreEqual(3, characterList.Characters.Length);

            Assert.AreEqual("Mary", characterList.Characters[0].Name);
            Assert.AreEqual("150267069", characterList.Characters[0].CharacterId);
            Assert.AreEqual("Starbase Anchoring Corp", characterList.Characters[0].CorporationName);
            Assert.AreEqual("150279367", characterList.Characters[0].CorporationId);
        }
    }
}
