using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tradier.Client.Models.Trading
{
    public class OrderResponseRootobject
    {
        [JsonProperty("order")]
        public OrderReponse OrderReponse { get; set; }
    }
}
