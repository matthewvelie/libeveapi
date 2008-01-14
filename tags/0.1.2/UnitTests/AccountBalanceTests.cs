using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class AccountBalanceTests
    {
        [Test]
        public void GetCharAccountBalanceTest()
        {
            AccountBalance accountBalance = EveApi.GetAccountBalance(AccountBalanceType.Character, "userId", "charId", "apiKey");

            Assert.AreEqual(1, accountBalance.AccountBalanceItems.Length);
            Assert.AreEqual("4807144", accountBalance.AccountBalanceItems[0].AccountId);
            Assert.AreEqual("1000", accountBalance.AccountBalanceItems[0].AccountKey);
            Assert.AreEqual(209127823.31, accountBalance.AccountBalanceItems[0].Balance);
        }

        [Test]
        public void GetCorpAccountBalanceTest()
        {
            AccountBalance accountBalance = EveApi.GetAccountBalance(AccountBalanceType.Corporation, "userId", "charId", "apiKey");

            Assert.AreEqual(7, accountBalance.AccountBalanceItems.Length);
            
            AccountBalanceItem account;

            account = accountBalance.AccountBalanceItems[0];
            Assert.AreEqual("4759", account.AccountId);
            Assert.AreEqual("1000", account.AccountKey);
            Assert.AreEqual(74171957.08, account.Balance);

            account = accountBalance.AccountBalanceItems[6];
            Assert.AreEqual("5692", account.AccountId);
            Assert.AreEqual("1006", account.AccountKey);
            Assert.AreEqual(0.00, account.Balance);
        }

        [Test]
        public void AccountPersist()
        {
            ResponseCache.Clear();

            AccountBalance accountBalance = EveApi.GetAccountBalance(AccountBalanceType.Corporation, "userId", "charId", "apiKey");
            ResponseCache.SaveToFile("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.LoadFromFile("ResponseCache.xml");
            AccountBalance cachedAccountBalance = ResponseCache.Get(accountBalance.Url) as AccountBalance;

            Assert.AreEqual(accountBalance.CachedUntilLocal, cachedAccountBalance.CachedUntilLocal);

            for (int i = 0; i < accountBalance.AccountBalanceItems.Length; i++)
            {
                Assert.AreEqual(accountBalance.AccountBalanceItems[i].AccountId, cachedAccountBalance.AccountBalanceItems[i].AccountId);
                Assert.AreEqual(accountBalance.AccountBalanceItems[i].AccountKey, cachedAccountBalance.AccountBalanceItems[i].AccountKey);
                Assert.AreEqual(accountBalance.AccountBalanceItems[i].Balance, cachedAccountBalance.AccountBalanceItems[i].Balance);
            }
        }
    }
}
