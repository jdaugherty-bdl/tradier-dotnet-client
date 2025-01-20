using Newtonsoft.Json;
using System;

namespace Tradier.Client.Models.Trading
{
    public class OrderReponse : IOrder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        public bool IsSuccessStatusCode => Status == "ok";
        public DateTime OrderTime { get; set; }
    }
}
