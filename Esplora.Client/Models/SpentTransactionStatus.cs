using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class SpentTransactionStatus
    {
        [JsonProperty("Spent")] public bool IsSpent { get; set; }
    }
}