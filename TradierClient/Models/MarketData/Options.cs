using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Tradier.Client.Helpers;
using static Tradier.Client.Models.General.GeneralEnumHolder;

namespace Tradier.Client.Models.MarketData
{
    public class Options
    {
        [JsonProperty("option")]
        [JsonConverter(typeof(SingleOrArrayConverter<Option>))]
        public List<Option> Option { get; set; }
    }
}