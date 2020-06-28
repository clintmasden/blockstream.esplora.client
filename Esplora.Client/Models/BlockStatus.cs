using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class BlockStatus
    {
        [JsonProperty("in_best_chain")] public bool InBestChain { get; set; }

        public int Height { get; set; }

        [JsonProperty("next_best")] public object NextBest { get; set; }
    }
}