using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class TransactionStatus
    {
        public bool Confirmed { get; set; }

        [JsonProperty("block_height")] public int BlockHeight { get; set; }

        [JsonProperty("block_hash")] public string BlockHash { get; set; }

        [JsonProperty("block_time")] public int BlockTime { get; set; }
    }
}