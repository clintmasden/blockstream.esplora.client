using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class UnspentTransaction
    {
        public string Txid { get; set; }

        [JsonProperty("Vout")] public int OutTransaction { get; set; }

        public TransactionStatus Status { get; set; }

        public long Value { get; set; }
    }
}