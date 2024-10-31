using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tradier.Client.Models.Account
{
    public class OrdersRootobject
    {
        [JsonProperty("orders")]
        public Orders Orders { get; set; }
    }
}
