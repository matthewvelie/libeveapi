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
            EveApi eveApi = new EveApi();

            CharacterList characterList = eveApi.GetAccountCharacters("asdf", "asdf");
            Console.WriteLine(characterList.CachedUntil);
            foreach (Character character in characterList.Characters)
            {
                Console.WriteLine(character.Name);
            }

            ResponseCache.SaveToFile(@"C:\test.xml");
            ResponseCache.Clear();
            ResponseCache.LoadFromFile(@"C:\test.xml");

            characterList = ResponseCache.Get("http://localhost/eveapi/Characters.xml?userId=asdf&apiKey=asdf") as CharacterList;
            Console.WriteLine(characterList.CachedUntil);
            foreach (Character character in characterList.Characters)
            {
                Console.WriteLine(character.Name);
            }
        }
    }
}
