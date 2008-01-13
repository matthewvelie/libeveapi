using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using libeveapi;

namespace ConsoleTests
{
    class Examples
    {
        public static void Main(String[] args)
        {
            CharacterListExamples.PrintCharacterList();
            AccountBalanceExamples.PrintAccounts();
            PrintStarbaseList();
        }

        public static void PrintStarbaseList()
        {
            StarbaseList starbaseList = EveApi.GetStarbaseList("userId", "characterId", "fullApiKey");
            foreach (StarbaseListItem sli in starbaseList.StarbaseListItems)
            {
                Console.WriteLine("ItemID: {0} LocationID: {1} State: {2}", sli.ItemId, sli.LocationId, sli.State);
            }
        }
    }
}
