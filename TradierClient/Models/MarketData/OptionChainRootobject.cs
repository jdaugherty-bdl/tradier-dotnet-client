using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tradier.Client.Models.MarketData
{
    public class OptionChainRootobject
    {
        [JsonProperty("options")]
        public Options Options { get; set; }
    }
}
