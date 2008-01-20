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
            WalletTransactions walletTransactions = EveApi.GetWalletTransactionsList(WalletTransactionListType.Character, 0, 0, "apiKey");

            Assert.AreEqual(4, walletTransactions.WalletTransactionItems.Length);
            Assert.AreEqual(619, walletTransactions.WalletTransactionItems[0].TransactionId);
        }

        [Test]
        public void GetCorpWalletTransactionsTest()
        {

        }

        [Test]
        public void WalletTransactionsPersist()
        {
            ResponseCache.Clear();

            WalletTransactions walletTransactions = EveApi.GetWalletTransactionsList(WalletTransactionListType.Corporation, 0, 0, "apiKey");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            WalletTransactions cachedwalletTransactions = EveApi.GetWalletTransactionsList(WalletTransactionListType.Corporation, 0, 0, "apiKey");

            Assert.AreEqual(walletTransactions.CachedUntilLocal, cachedwalletTransactions.CachedUntilLocal);

            for (int i = 0; i < walletTransactions.WalletTransactionItems.Length; i++)
            {
                Assert.AreEqual(walletTransactions.WalletTransactionItems[i].CharacterId, cachedwalletTransactions.WalletTransactionItems[i].CharacterId);
                Assert.AreEqual(walletTransactions.WalletTransactionItems[i].ClientName, cachedwalletTransactions.WalletTransactionItems[i].ClientName);
                Assert.AreEqual(walletTransactions.WalletTransactionItems[i].Quantity, cachedwalletTransactions.WalletTransactionItems[i].Quantity);
            }
             
        }
    }
}
