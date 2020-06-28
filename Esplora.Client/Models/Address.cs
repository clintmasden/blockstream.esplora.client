using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class Address
    {
        [JsonProperty("Address")] public string AddressId { get; set; }

        [JsonProperty("chain_stats")] public ChainStatistics ChainStatistics { get; set; }

        [JsonProperty("mempool_stats")] public MemoryPoolStatistics MemoryPoolStatistics { get; set; }

        public override string ToString()
        {
            return AddressId;
        }
    }
}