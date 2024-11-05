using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tradier.Client.Models.Account
{
    public class Position
    {
        public int Index { get; set; }

        [JsonProperty("cost_basis")]
        public float CostBasis { get; set; }

        [JsonProperty("date_acquired")]
        public DateTime DateAcquired { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("quantity")]
        public float Quantity { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}
