using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Tradier.Client.Helpers;

namespace Tradier.Client.Models.Account
{
    public class Orders
    {
        [JsonProperty("order")]
        [JsonConverter(typeof(SingleOrArrayConverter<Order>))]
        public List<Order> Order { get; set; }
    }
}
