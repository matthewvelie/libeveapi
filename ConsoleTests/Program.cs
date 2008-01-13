using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using libeveapi;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = Network.GetXml("http://localhost/eveapi/Characters.xml");
            CharacterList characterList = CharacterList.FromXmlDocument(xmlDoc);
            Console.WriteLine(characterList.CachedUntil);
            foreach (Character character in characterList.Characters)
            {
                Console.WriteLine(character.Name);
            }

            xmlDoc = Network.GetXml("http://localhost/eveapi/Error.xml");
            characterList = CharacterList.FromXmlDocument(xmlDoc);
        }
    }
}
