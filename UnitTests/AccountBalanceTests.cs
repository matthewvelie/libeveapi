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

            Assert.AreEqual(1, accountBalance.Accounts.Length);
            Assert.AreEqual("4807144", accountBalance.Accounts[0].AccountId);
            Assert.AreEqual("1000", accountBalance.Accounts[0].AccountKey);
            Assert.AreEqual(209127823.31, accountBalance.Accounts[0].Balance);
        }

        [Test]
        public void GetCorpAccountBalanceTest()
        {
            AccountBalance accountBalance = EveApi.GetAccountBalance(AccountBalanceType.Corporation, "userId", "charId", "apiKey");

            Assert.AreEqual(7, accountBalance.Accounts.Length);
            
            AccountBalanceItem account;

            account = accountBalance.Accounts[0];
            Assert.AreEqual("4759", account.AccountId);
            Assert.AreEqual("1000", account.AccountKey);
            Assert.AreEqual(74171957.08, account.Balance);

            account = accountBalance.Accounts[6];
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

            for (int i = 0; i < accountBalance.Accounts.Length; i++)
            {
                Assert.AreEqual(accountBalance.Accounts[i].AccountId, cachedAccountBalance.Accounts[i].AccountId);
                Assert.AreEqual(accountBalance.Accounts[i].AccountKey, cachedAccountBalance.Accounts[i].AccountKey);
                Assert.AreEqual(accountBalance.Accounts[i].Balance, cachedAccountBalance.Accounts[i].Balance);
            }
        }
    }
}
