using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static Tradier.Client.Models.General.GeneralEnumHolder;

namespace Tradier.Client.Models.Account
{
    public class Order
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public OrderType Type { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("side")]
        public OrderInstruction Side { get; set; }

        [JsonProperty("quantity")]
        public float Quantity { get; set; }

        [JsonProperty("status")]
        public OrderStatus Status { get; set; }

        [JsonProperty("duration")]
        public OrderDuration Duration { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("avg_fill_price")]
        public float AvgFillPrice { get; set; }

        [JsonProperty("exec_quantity")]
        public float ExecQuantity { get; set; }

        [JsonProperty("last_fill_price")]
        public float LastFillPrice { get; set; }

        [JsonProperty("last_fill_quantity")]
        public float LastFillQuantity { get; set; }

        [JsonProperty("remaining_quantity")]
        public float RemainingQuantity { get; set; }

        [JsonProperty("create_date")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("transaction_date")]
        public DateTime TransactionDate { get; set; }

        [JsonProperty("_class")]
        public OrderClass Class { get; set; }

        [JsonProperty("strategy")]
        public OrderStrategy Strategy { get; set; }

        [JsonProperty("option_symbol")]
        public string OptionSymbol { get; set; }

        [JsonProperty("stop_price")]
        public float StopPrice { get; set; }

        [JsonProperty("reason_description")]
        public string ReasonDescription { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("num_legs")]
        public int NumLegs { get; set; }

        [JsonProperty("leg")]
        public Leg[] Leg { get; set; }

        public Option SourceOption { get; set; }
    }
}
