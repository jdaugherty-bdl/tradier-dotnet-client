using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Tradier.Client.Models.MarketData
{

    public class OptionExpirationsRootobject
    {
        [JsonProperty("expirations")]
        public ExpirationCollection Expirations { get; set; }
    }
}
