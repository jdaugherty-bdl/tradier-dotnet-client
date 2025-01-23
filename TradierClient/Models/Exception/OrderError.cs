using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Tradier.Client.Models.Trading;

namespace Tradier.Client.Models.Exception
{
    public class OrderError
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
