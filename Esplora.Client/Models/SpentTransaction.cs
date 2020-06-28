using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class SpentTransaction
    {
        public string Txid { get; set; }

        [JsonProperty("Spent")] public bool IsSpent { get; set; }

        [JsonProperty("Vin")] public int InTransaction { get; set; }

        public TransactionStatus Status { get; set; }
    }
}