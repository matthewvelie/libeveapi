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

            Assert.AreEqual(3, characterList.CharacterListItems.Length);

            Assert.AreEqual("Mary", characterList.CharacterListItems[0].Name);
            Assert.AreEqual("150267069", characterList.CharacterListItems[0].CharacterId);
            Assert.AreEqual("Starbase Anchoring Corp", characterList.CharacterListItems[0].CorporationName);
            Assert.AreEqual("150279367", characterList.CharacterListItems[0].CorporationId);
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

            Assert.AreEqual(cachedCharacterList.CharacterListItems.Length, characterList.CharacterListItems.Length);

            for (int i = 0; i < characterList.CharacterListItems.Length; i++)
            {
                Assert.AreEqual(characterList.CharacterListItems[i].Name, cachedCharacterList.CharacterListItems[i].Name);
                Assert.AreEqual(characterList.CharacterListItems[i].CharacterId, cachedCharacterList.CharacterListItems[i].CharacterId);
                Assert.AreEqual(characterList.CharacterListItems[i].CorporationName, cachedCharacterList.CharacterListItems[i].CorporationName);
                Assert.AreEqual(characterList.CharacterListItems[i].CorporationId, cachedCharacterList.CharacterListItems[i].CorporationId);
            }
        }
    }
}
