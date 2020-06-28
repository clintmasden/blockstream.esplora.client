using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class MemoryPoolBacklogStatistics
    {
        public int Count { get; set; }

        public int Vsize { get; set; }

        [JsonProperty("total_fee")] public int TotalFee { get; set; }

        [JsonProperty("fee_histogram")] public float[][] FeeHistogram { get; set; }
    }
}