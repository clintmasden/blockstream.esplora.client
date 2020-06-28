using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class MemoryPoolTransaction
    {
        public string Txid { get; set; }

        public int Fee { get; set; }

        [JsonProperty("Vsize")] public int Size { get; set; }

        public long Value { get; set; }
    }
}