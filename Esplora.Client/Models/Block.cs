using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class Block
    {
        public string Id { get; set; }

        public int Height { get; set; }

        public int Version { get; set; }

        public int Timestamp { get; set; }

        [JsonProperty("tx_count")] public int TxCount { get; set; }

        public long Size { get; set; }

        public long Weight { get; set; }

        [JsonProperty("merkle_root")] public string MerkleRoot { get; set; }

        public string PreviousBlockHash { get; set; }

        public long Nonce { get; set; }

        public long Bits { get; set; }

        public long Difficulty { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}";
        }
    }
}