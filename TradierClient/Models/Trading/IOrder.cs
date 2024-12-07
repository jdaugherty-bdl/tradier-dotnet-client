using Newtonsoft.Json;
using System;

namespace Tradier.Client.Models.Trading
{
    public interface IOrder
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        public bool IsSuccessStatusCode { get; }
        public DateTime OrderTime { get; }
    }

}
