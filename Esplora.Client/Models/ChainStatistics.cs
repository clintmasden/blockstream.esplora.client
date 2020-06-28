using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class ChainStatistics
    {
        [JsonProperty("funded_txo_count")] public int FundedTxoCount { get; set; }

        [JsonProperty("funded_txo_sum")] public long FundedTxoSum { get; set; }

        [JsonProperty("spent_txo_count")] public int SpentTxoCount { get; set; }

        [JsonProperty("spent_txo_sum")] public long SpentTxoSum { get; set; }

        [JsonProperty("tx_count")] public int TxCount { get; set; }
    }
}