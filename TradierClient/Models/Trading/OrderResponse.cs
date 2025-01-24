using Newtonsoft.Json;
using System;
using static Tradier.Client.Models.General.GeneralEnumHolder;

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
        public string ErrorMessage { get; set; }
        public string OptionSymbol { get; set; }
        public OrderInstruction Side { get; set; }
        public OrderType Type { get; set; }
        public OrderDuration Duration { get; set; }
    }
}
