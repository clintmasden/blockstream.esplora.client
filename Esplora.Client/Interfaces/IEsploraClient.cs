using System.Collections.Generic;
using System.Threading.Tasks;
using Esplora.Client.Models;
using RestEase;

namespace Esplora.Client.Interfaces
{
    /// <summary>
    ///     Blockstream Esplora Api Endpoints.
    ///     <see href="https://github.com/Blockstream/esplora/blob/master/API.md">See Api Spec.</see>
    /// </summary>
    public interface IEsploraClient
    {
        /// <summary>
        ///     Returns information about the transaction.
        /// </summary>
        /// <param name="txid"></param>
        /// <returns></returns>
        [Get("tx/{txid}")]
        Task<Transaction> GetTransaction([Path] string txid);

        /// <summary>
        ///     Broadcast a raw transaction to the network. [The transaction should be provided as hex in the request body.]
        /// </summary>
        /// <param name="transactionInHexFormat"></param>
        /// <returns>The txid will be returned on success.</returns>
        [Post("tx/")]
        Task<string> PostTransaction([Body] string transactionInHexFormat);

        /// <summary>
        ///     Returns the transaction confirmation status.
        /// </summary>
        /// <param name="txid"></param>
        /// <returns></returns>
        [Get("tx/{txid}/status")]
        Task<TransactionStatus> GetTransactionStatus([Path] string txid);

        /// <summary>
        ///     Returns the information in hex.
        /// </summary>
        /// <param name="txid"></param>
        /// <returns></returns>
        [Get("tx/{txid}/hex")]
        Task<string> GetTransactionInHexFormat([Path] string txid);

        /// <summary>
        ///     Returns the information in binary.
        /// </summary>
        /// <param name="txid"></param>
        /// <returns></returns>
        [Get("tx/{txid}/raw")]
        Task<string> GetTransactionInBinaryFormat([Path] string txid);

        /// <summary>
        ///     Returns a merkle inclusion proof for the transaction using bitcoind's merkleblock format.
        /// </summary>
        /// <param name="txid"></param>
        /// <returns></returns>
        [Get("tx/{txid}/merkleblock-proof")]
        Task<string> GetTransactionInMerkelBlockProofFormat([Path] string txid);

        /// <summary>
        ///     Returns a merkle inclusion proof for the transaction using Electrum's blockchain.transaction.get_merkle format.
        /// </summary>
        /// <param name="txid"></param>
        /// <returns></returns>
        [Get("tx/{txid}/merkle-proof")]
        Task<string> GetTransactionInMerkelProofFormat([Path] string txid);

        /// <summary>
        ///     Returns the spending status of a transaction output.
        /// </summary>
        /// <param name="txid"></param>
        /// <param name="vout"></param>
        /// <returns></returns>
        [Get("tx/{txid}/outspend/{vout}")]
        Task<SpentTransactionStatus> GetSpentTransactionStatus([Path] string txid, [Path] int vout);

        /// <summary>
        ///     Returns the spending status of all transaction outputs.
        /// </summary>
        /// <param name="txid"></param>
        /// <returns></returns>
        [Get("tx/{txid}/outspends")]
        Task<List<SpentTransaction>> GetSpentTransactions([Path] string txid);

        /// <summary>
        ///     Get information about an address.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        [Get("address/{address}")]
        Task<Address> GetAddress([Path] string address);

        /// <summary>
        ///     Search for addresses beginning with the request. [Returns 10 results per request.]
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        [Get("address-prefix/{address}")]
        Task<List<string>> GetAddressesByPrefix([Path] string address);

        /// <summary>
        ///     Get transaction history for the specified address, sorted with newest first. [Returns up to 50 mempool transactions
        ///     plus the first 25 confirmed transactions. You can request more confirmed transactions using the override with
        ///     txid.]
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        [Get("address/{address}/txs")]
        Task<List<Transaction>> GetAddressConfirmedTransactions([Path] string address);

        /// <summary>
        ///     Get confirmed transaction history for the specified address, sorted with newest first. [Returns 25 transactions per
        ///     request.]
        /// </summary>
        /// <param name="address"></param>
        /// <param name="txid"></param>
        /// <returns></returns>
        [Get("address/{address}/txs/chain/{txid}")]
        Task<List<Transaction>> GetAddressConfirmedTransactions([Path] string address, [Path] string txid);

        /// <summary>
        ///     Get unconfirmed transaction history for the specified address. [Returns up to 50 transactions.]
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        [Get("address/{address}/txs/mempool")]
        Task<List<Transaction>> GetAddressUnConfirmedTransactions([Path] string address);

        /// <summary>
        ///     Get the list of unspent transaction outputs associated with the address.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        [Get("address/{address}/utxo")]
        Task<List<UnspentTransaction>> GetAddressUnspentTransactions([Path] string address);

        /// <summary>
        ///     Returns the hash of the last block.
        /// </summary>
        /// <returns></returns>
        [Get("blocks/tip/hash")]
        Task<string> GetLatestBlockHash();

        /// <summary>
        ///     Returns the height of the last block.
        /// </summary>
        /// <returns></returns>
        [Get("blocks/tip/height")]
        Task<string> GetLatestBlockHeight();

        /// <summary>
        ///     Returns information about a block.
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        [Get("block/{hash}")]
        Task<Block> GetBlock([Path] string hash);

        /// <summary>
        ///     Returns the block status.
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        [Get("block/{hash}/status")]
        Task<BlockStatus> GetBlockStatus([Path] string hash);

        /// <summary>
        ///     Returns the hash of the block currently at height.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        [Get("block-height/{height}")]
        Task<string> GetBlockAtHeight([Path] string height);

        /// <summary>
        ///     Returns the 10 newest blocks starting at the tip or at height if specified.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        [Get("blocks/{height}")]
        Task<List<Block>> GetBlocksAtHeight([Path] string height);

        /// <summary>
        ///     Returns a list of transactions in the block (up to 25 transactions beginning at txid).
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="txid"></param>
        /// <returns></returns>
        [Get("block/{hash}/txs/{txid}")]
        Task<List<Transaction>> GetBlockTransactions([Path] string hash, [Path] string txid);

        /// <summary>
        ///     Returns a list of all txids in the block
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        [Get("block/{hash}/txids")]
        Task<List<string>> GetBlockTransactionIds([Path] string hash);

        /// <summary>
        ///     Returns the raw block representation in binary.
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        [Get("block/{hash}/raw")]
        Task<string> GetBlockInBinaryFormat([Path] string hash);

        /// <summary>
        ///     Get mempool backlog statistics.
        /// </summary>
        /// <returns></returns>
        [Get("mempool")]
        Task<MemoryPoolBacklogStatistics> GetMemoryPoolBacklogStatistics();

        /// <summary>
        ///     Get the full list of txids in the mempool as an array. [The order of the txids is arbitrary and does not match
        ///     bitcoind's.]
        /// </summary>
        /// <returns></returns>
        [Get("mempool/txids")]
        Task<List<string>> GetMemoryPoolTransactionsIds();

        /// <summary>
        ///     Get a list of the last 10 transactions to enter the mempool.
        /// </summary>
        /// <returns></returns>
        [Get("mempool/recent")]
        Task<List<MemoryPoolTransaction>> GetLatestMemoryPoolTransactions();

        /// <summary>
        ///     Get an object where the key is the confirmation target (in number of blocks) and the value is the estimated feerate
        ///     (in sat/vB). [The available confirmation targets are 1-25, 144, 504 and 1008 blocks.]
        /// </summary>
        /// <returns></returns>
        [Get("fee-estimates")]
        Task<string> GetFeeEstimates();
    }
}