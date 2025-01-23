using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Tradier.Client.Models.Exception;

namespace Tradier.Client.Models.Trading
{
    public class OrderPreviewResponseRootobject
    {
        [JsonProperty("order")]
        public OrderPreviewResponse OrderPreviewResponse { get; set; }
        [JsonProperty("errors")]
        public OrderError Errors { get; set; }
    }
}
