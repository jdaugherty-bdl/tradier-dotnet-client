using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Tradier.Client.Models.General;

namespace Tradier.Client.Models.MarketData
{
    public class ExpirationCollection : TradierResponseObject
    {
        [JsonProperty("expiration")]
        public Expiration[] Expiration { get; set; }
    }
}
