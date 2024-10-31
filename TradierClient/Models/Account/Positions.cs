using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Tradier.Client.Helpers;

namespace Tradier.Client.Models.Account
{
    public class Positions
    {
        [JsonProperty("position")]
        [JsonConverter(typeof(SingleOrArrayConverter<Position>))]
        public List<Position> Position { get; set; }
    }
}