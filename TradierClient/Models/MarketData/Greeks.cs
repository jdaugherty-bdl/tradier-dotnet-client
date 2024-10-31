using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Tradier.Client.Helpers;

namespace Tradier.Client.Models.MarketData
{
    public class Greeks
    {
        [JsonProperty("delta")]
        public float Delta { get; set; }

        [JsonProperty("gamma")]
        public float Gamma { get; set; }

        [JsonProperty("theta")]
        public float Theta { get; set; }

        [JsonProperty("vega")]
        public float Vega { get; set; }

        [JsonProperty("rho")]
        public float Rho { get; set; }

        [JsonProperty("phi")]
        public float Phi { get; set; }

        [JsonProperty("bid_iv")]
        public float BidIV { get; set; }

        [JsonProperty("mid_iv")]
        public float MidIV { get; set; }

        [JsonProperty("ask_iv")]
        public float AskIV { get; set; }

        [JsonProperty("smv_vol")]
        public float SmvIV { get; set; }

        [JsonProperty("updated_at")]
        [JsonConverter(typeof(ParseExactConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}
