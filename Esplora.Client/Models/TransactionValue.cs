using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class TransactionValue
    {
        [JsonProperty("scriptpubkey")] public string Key { get; set; }

        [JsonProperty("scriptpubkey_asm")] public string Asm { get; set; }

        [JsonProperty("scriptpubkey_type")] public string Type { get; set; }

        [JsonProperty("scriptpubkey_address")] public string Address { get; set; }

        public long Value { get; set; }
    }
}