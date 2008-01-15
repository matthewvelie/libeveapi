using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class WalletTransactionsTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetCharWalletTransactionsTest()
        {

        }

        [Test]
        public void GetCorpWalletTransactionsTest()
        {

        }

        [Test]
        public void WalletTransactionsPersist()
        {
            ResponseCache.Clear();

            WalletTransactions marketTransactions = EveApi.GetMarketTransactionsList(WalletTransactionListType.Corporation, "userId", "charId", "apiKey");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            WalletTransactions cachedmarketTransactions = EveApi.GetMarketTransactionsList(WalletTransactionListType.Corporation, "userId", "charId", "apiKey");

            Assert.AreEqual(marketTransactions.CachedUntilLocal, cachedmarketTransactions.CachedUntilLocal);

            /*
            for (int i = 0; i < accountBalance.AccountBalanceItems.Length; i++)
            {
                Assert.AreEqual(accountBalance.AccountBalanceItems[i].AccountId, cachedAccountBalance.AccountBalanceItems[i].AccountId);
                Assert.AreEqual(accountBalance.AccountBalanceItems[i].AccountKey, cachedAccountBalance.AccountBalanceItems[i].AccountKey);
                Assert.AreEqual(accountBalance.AccountBalanceItems[i].Balance, cachedAccountBalance.AccountBalanceItems[i].Balance);
            }
             */
        }
    }
}
