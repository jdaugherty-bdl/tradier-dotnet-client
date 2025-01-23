using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Tradier.Client.Models.Exception;

namespace Tradier.Client.Models.Trading
{
    public class OrderResponseRootobject
    {
        [JsonProperty("order")]
        public OrderReponse OrderReponse { get; set; }
        [JsonProperty("errors")]
        public OrderError Errors { get; set; }
    }
}
