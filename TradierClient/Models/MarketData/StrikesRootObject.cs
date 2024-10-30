using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tradier.Client.Models.MarketData
{
    public class StrikesRootObject
    {
        [JsonProperty("strike")]
        public List<double> Strike { get; set; }
    }
}
