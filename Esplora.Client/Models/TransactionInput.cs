using Newtonsoft.Json;

namespace Esplora.Client.Models
{
    public class TransactionInput
    {
        public string Txid { get; set; }

        public long Vout { get; set; }

        [JsonProperty("Prevout")] public TransactionValue PreviousTransactionValue { get; set; }

        public string[] Witness { get; set; }

        public long Sequence { get; set; }

        [JsonProperty("is_coinbase")] public bool IsCoinbase { get; set; }

        [JsonProperty("Scriptsig")] public string ScriptSignature { get; set; }

        [JsonProperty("scriptsig_asm")] public string ScriptSignatureAsm { get; set; }

        [JsonProperty("inner_redeemscript_asm")]
        public string InnerRedeemScriptAsm { get; set; }

        [JsonProperty("inner_witnessscript_asm")]
        public string InnerWitnessScriptAsm { get; set; }
    }
}