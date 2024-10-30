using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tradier.Client.Models.MarketData
{
    public class Expiration
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("contract_size")]
        public int ContractSize { get; set; }

        [JsonProperty("expiration_type")]
        public string ExpirationType { get; set; }

        [JsonProperty("strikes")]
        public StrikesRootObject Strikes { get; set; }
    }
}
