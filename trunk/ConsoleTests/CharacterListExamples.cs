using System;
using System.Collections.Generic;
using System.Text;

using libeveapi;

namespace ConsoleTests
{
    public class CharacterListExamples
    {
        public static void PrintCharacterList()
        {
            CharacterList characterList = EveApi.GetAccountCharacters("userId", "apiKey");
            foreach (CharacterListItem cli in characterList.Characters)
            {
                Console.WriteLine("Name: {0} Corporation: {1}", cli.Name, cli.CorporationName);
            }
        }
    }
}
