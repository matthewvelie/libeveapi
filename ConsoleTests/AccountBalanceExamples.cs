using System;
using System.Collections.Generic;
using System.Text;

using libeveapi;

namespace ConsoleTests
{
    class AccountBalanceExamples
    {
        public static void PrintAccounts()
        {
            AccountBalance accountBalance = EveApi.GetAccountBalance(AccountBalanceType.Corporation, "userId", "characterId", "fullApiKey");
            foreach (AccountBalanceItem abi in accountBalance.AccountBalanceItems)
            {
                Console.WriteLine("id: {0} key: {1} balance: {2}", abi.AccountId, abi.AccountKey, abi.Balance);
            }
        }
    }
}
