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
            WalletTransactions walletTransactions = EveApi.GetWalletTransactionsList(WalletTransactionListType.Character, "userId", "charId", "apiKey");

            Assert.AreEqual(4, walletTransactions.WalletTransactionItems.Length);
            Assert.AreEqual(619, walletTransactions.WalletTransactionItems[0].transactionID);
        }

        [Test]
        public void GetCorpWalletTransactionsTest()
        {

        }

        [Test]
        public void WalletTransactionsPersist()
        {
            ResponseCache.Clear();

            WalletTransactions walletTransactions = EveApi.GetWalletTransactionsList(WalletTransactionListType.Corporation, "userId", "charId", "apiKey");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            WalletTransactions cachedwalletTransactions = EveApi.GetWalletTransactionsList(WalletTransactionListType.Corporation, "userId", "charId", "apiKey");

            Assert.AreEqual(walletTransactions.CachedUntilLocal, cachedwalletTransactions.CachedUntilLocal);

            for (int i = 0; i < walletTransactions.WalletTransactionItems.Length; i++)
            {
                Assert.AreEqual(walletTransactions.WalletTransactionItems[i].characterID, cachedwalletTransactions.WalletTransactionItems[i].characterID);
                Assert.AreEqual(walletTransactions.WalletTransactionItems[i].clientName, cachedwalletTransactions.WalletTransactionItems[i].clientName);
                Assert.AreEqual(walletTransactions.WalletTransactionItems[i].quantity, cachedwalletTransactions.WalletTransactionItems[i].quantity);
            }
             
        }
    }
}