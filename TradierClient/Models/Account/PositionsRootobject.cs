using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tradier.Client.Models.Account
{
    public class PositionsRootobject
    {
        [JsonProperty("positions")]
        public Positions Positions { get; set; }
    }
}
