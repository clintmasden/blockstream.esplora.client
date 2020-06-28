using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class MemoryPoolStatistics
    {
        [JsonProperty("funded_txo_count")] public int FundedTxoCount { get; set; }

        [JsonProperty("funded_txo_sum")] public int FundedTxoSum { get; set; }

        [JsonProperty("spent_txo_count")] public int SpentTxoCount { get; set; }

        [JsonProperty("spent_txo_sum")] public int SpentTxoSum { get; set; }

        [JsonProperty("tx_count")] public int TxCount { get; set; }
    }
}