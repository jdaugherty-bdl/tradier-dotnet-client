using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tradier.Client.Models.Trading
{
    public class OrderPreviewResponseRootobject
    {
        [JsonProperty("order")]
        public OrderPreviewResponse OrderPreviewResponse { get; set; }
    }
}
