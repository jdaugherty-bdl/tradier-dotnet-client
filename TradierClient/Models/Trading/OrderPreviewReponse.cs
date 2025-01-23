using Newtonsoft.Json;
using System;
using static Tradier.Client.Models.General.GeneralEnumHolder;

namespace Tradier.Client.Models.Trading
{
    public class OrderPreviewResponse : IOrder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        public bool IsSuccessStatusCode => Status == "ok";
        public DateTime OrderTime { get; set; }

        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        [JsonProperty("commission")]
        public float? Commision { get; set; }

        [JsonProperty("cost")]
        public float? Cost { get; set; }

        [JsonProperty("fees")]
        public float? Fees { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("side")]
        public OrderInstruction Side { get; set; }

        [JsonProperty("type")]
        public OrderType Type { get; set; }

        [JsonProperty("duration")]
        public OrderDuration Duration { get; set; }

        [JsonProperty("result")]
        public bool? Result { get; set; }

        [JsonProperty("order_cost")]
        public float? OrderCost { get; set; }

        [JsonProperty("margin_change")]
        public float? MarginChange { get; set; }
        
        [JsonProperty("option_requirement")]
        public float? OptionRequirement { get; set; }

        [JsonProperty("request_date")]
        public DateTime? RequestDate { get; set; }

        [JsonProperty("extended_hours")]
        public bool? ExtendedHours { get; set; }

        [JsonProperty("option_symbol")]
        public string OptionSymbol { get; set; }

        [JsonProperty("class")]
        public string ClassOrder { get; set; }

        [JsonProperty("strategy")]
        public string Strategy { get; set; }

        [JsonProperty("day_trades")]
        public int? DayTrades { get; set; }

        public string ErrorMessage { get; set; }
    }
}
