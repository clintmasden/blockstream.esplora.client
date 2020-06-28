using System.Collections.Generic;
using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class Transaction
    {
        public string Txid { get; set; }

        public int Version { get; set; }

        public int Locktime { get; set; }

        [JsonProperty("Vin")] public List<TransactionInput> InTransactions { get; set; }

        [JsonProperty("Vout")] public List<TransactionValue> OutTransactions { get; set; }

        public int Size { get; set; }

        public int Weight { get; set; }

        public int Fee { get; set; }

        public TransactionStatus Status { get; set; }
    }
}