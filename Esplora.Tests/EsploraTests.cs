using System;
using System.Threading.Tasks;
using Esplora.Client.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestEase;

namespace Esplora.Tests
{
    [TestClass]
    public class EsploraTests
    {
        private static IEsploraClient EsploraClient { get; set; }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [ClassInitialize]
        public static void SetupClient(TestContext con)
        {
            EsploraClient = RestClient.For<IEsploraClient>("https://blockstream.info/api/");
        }

        [TestMethod]
        public async Task GetTransaction_Pass()
        {
            var result = await EsploraClient.GetTransaction("4e0f11aa6b9c2bd299369759f7dc57f3db3f98fbe8c69783acf8f98f85ae8a24");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task PostTransaction_Pass()
        {
            //var result = await EsploraClient.PostTransaction("NOT-CONFIRMED");
            //Assert.IsTrue(result != null);
        }

        [TestMethod]
        public async Task GetTransactionStatus_Pass()
        {
            var result = await EsploraClient.GetTransactionStatus("4e0f11aa6b9c2bd299369759f7dc57f3db3f98fbe8c69783acf8f98f85ae8a24");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetTransactionInHexFormat_Pass()
        {
            var result = await EsploraClient.GetTransactionInHexFormat("4e0f11aa6b9c2bd299369759f7dc57f3db3f98fbe8c69783acf8f98f85ae8a24");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result);
        }

        [TestMethod]
        public async Task GetTransactionInBinaryFormat_Pass()
        {
            var result = await EsploraClient.GetTransactionInBinaryFormat("4e0f11aa6b9c2bd299369759f7dc57f3db3f98fbe8c69783acf8f98f85ae8a24");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result);
        }

        [TestMethod]
        public async Task GetTransactionInMerkelBlockProofFormat_Pass()
        {
            var result = await EsploraClient.GetTransactionInMerkelBlockProofFormat("4e0f11aa6b9c2bd299369759f7dc57f3db3f98fbe8c69783acf8f98f85ae8a24");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result);
        }

        [TestMethod]
        public async Task GetTransactionInMerkelProofFormat_Pass()
        {
            var result = await EsploraClient.GetTransactionInMerkelProofFormat("4e0f11aa6b9c2bd299369759f7dc57f3db3f98fbe8c69783acf8f98f85ae8a24");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result);
        }

        [TestMethod]
        public async Task GetSpentTransactionStatus_Pass()
        {
            var result = await EsploraClient.GetSpentTransactionStatus("4e0f11aa6b9c2bd299369759f7dc57f3db3f98fbe8c69783acf8f98f85ae8a24", 1);
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetSpentTransactions_Pass()
        {
            var result = await EsploraClient.GetSpentTransactions("4e0f11aa6b9c2bd299369759f7dc57f3db3f98fbe8c69783acf8f98f85ae8a24");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetAddress_Pass()
        {
            var result = await EsploraClient.GetAddress("3D2oetdNuZUqQHPJmcMDDHYoqkyNVsFk9r");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetAddressesByPrefix_Pass()
        {
            var result = await EsploraClient.GetAddressesByPrefix("3D2");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetAddressConfirmedTransactions_Pass()
        {
            var result = await EsploraClient.GetAddressConfirmedTransactions("3D2oetdNuZUqQHPJmcMDDHYoqkyNVsFk9r");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetAddressConfirmedTransactionsWithHistory_Pass()
        {
            var result = await EsploraClient.GetAddressConfirmedTransactions("3D2oetdNuZUqQHPJmcMDDHYoqkyNVsFk9r", "821fefa0210c99e01ea658be66e6247dca4366d3e02b06215922d9dafbc091b1");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetAddressUnConfirmedTransactions_Pass()
        {
            var result = await EsploraClient.GetAddressUnConfirmedTransactions("3D2oetdNuZUqQHPJmcMDDHYoqkyNVsFk9r");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetAddressUnspentTransactions_Pass()
        {
            var result = await EsploraClient.GetAddressUnspentTransactions("1AC4fMwgY8j9onSbXEWeH6Zan8QGMSdmtA");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetLatestBlockHash_Pass()
        {
            var result = await EsploraClient.GetLatestBlockHash();
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result);
        }

        [TestMethod]
        public async Task GetLatestBlockHeight_Pass()
        {
            var result = await EsploraClient.GetLatestBlockHeight();
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result);
        }

        [TestMethod]
        public async Task GetBlock_Pass()
        {
            var result = await EsploraClient.GetBlock("00000000000000000007d70bf1b41ec7e11b1a5028ae139075f9bac90c345ea9");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetBlockStatus_Pass()
        {
            var result = await EsploraClient.GetBlockStatus("00000000000000000007d70bf1b41ec7e11b1a5028ae139075f9bac90c345ea9");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetBlockAtHeight_Pass()
        {
            var result = await EsploraClient.GetBlockAtHeight("636760");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result);
        }

        [TestMethod]
        public async Task GetBlocksAtHeight_Pass()
        {
            var result = await EsploraClient.GetBlocksAtHeight("636760");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetBlockTransactions_Pass()
        {
            var result = await EsploraClient.GetBlockTransactions("00000000000000000007d70bf1b41ec7e11b1a5028ae139075f9bac90c345ea9", string.Empty);
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetBlockTransactionIds_Pass()
        {
            var result = await EsploraClient.GetBlockTransactionIds("00000000000000000007d70bf1b41ec7e11b1a5028ae139075f9bac90c345ea9");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetBlockInBinaryFormat_Pass()
        {
            var result = await EsploraClient.GetBlockInBinaryFormat("00000000000000000007d70bf1b41ec7e11b1a5028ae139075f9bac90c345ea9");
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result);
        }

        [TestMethod]
        public async Task GetMemoryPoolBacklogStatistics_Pass()
        {
            var result = await EsploraClient.GetMemoryPoolBacklogStatistics();
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetMemoryPoolTransactionsIds_Pass()
        {
            var result = await EsploraClient.GetMemoryPoolTransactionsIds();
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetLatestMemoryPoolTransactions_Pass()
        {
            var result = await EsploraClient.GetLatestMemoryPoolTransactions();
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result.ToString());
        }

        [TestMethod]
        public async Task GetFeeEstimates_Pass()
        {
            var result = await EsploraClient.GetFeeEstimates();
            Assert.IsTrue(result != null);

            TestContext.WriteLine(result);
        }
    }
}