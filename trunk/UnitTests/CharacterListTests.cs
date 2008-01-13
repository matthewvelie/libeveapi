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
            CharacterList characterList = EveApi.GetAccountCharacters("asdf", "asdf");

            Assert.AreEqual(3, characterList.Characters.Length);

            Assert.AreEqual("Mary", characterList.Characters[0].Name);
            Assert.AreEqual("150267069", characterList.Characters[0].CharacterId);
            Assert.AreEqual("Starbase Anchoring Corp", characterList.Characters[0].CorporationName);
            Assert.AreEqual("150279367", characterList.Characters[0].CorporationId);
        }

        [Test]
        public void CharacterListPersist()
        {
            ResponseCache.Clear();
            CharacterList characterList = EveApi.GetAccountCharacters("asdf", "asdf");

            ResponseCache.SaveToFile("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.LoadFromFile("ResponseCache.xml");

            CharacterList cachedCharacterList = ResponseCache.Get(characterList.Url) as CharacterList;

            Assert.AreEqual(cachedCharacterList.Characters.Length, characterList.Characters.Length);

            for (int i = 0; i < characterList.Characters.Length; i++)
            {
                Assert.AreEqual(characterList.Characters[i].Name, cachedCharacterList.Characters[i].Name);
                Assert.AreEqual(characterList.Characters[i].CharacterId, cachedCharacterList.Characters[i].CharacterId);
                Assert.AreEqual(characterList.Characters[i].CorporationName, cachedCharacterList.Characters[i].CorporationName);
                Assert.AreEqual(characterList.Characters[i].CorporationId, cachedCharacterList.Characters[i].CorporationId);
            }
        }
    }
}
