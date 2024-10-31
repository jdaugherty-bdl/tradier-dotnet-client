using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static Tradier.Client.Models.General.GeneralEnumHolder;
using Tradier.Client.Helpers;

namespace Tradier.Client.Models.MarketData
{
    public class Option
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exch")]
        public string Exchange { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("last")]
        public float? Last { get; set; }

        [JsonProperty("change")]
        public float? Change { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("open")]
        public float? Open { get; set; }

        [JsonProperty("high")]
        public float? High { get; set; }

        [JsonProperty("low")]
        public float? Low { get; set; }

        [JsonProperty("close")]
        public float? Close { get; set; }

        [JsonProperty("bid")]
        public float? Bid { get; set; }

        [JsonProperty("ask")]
        public float? Ask { get; set; }

        [JsonProperty("underlying")]
        public string Underlying { get; set; }

        [JsonProperty("strike")]
        public float Strike { get; set; }

        [JsonProperty("change_percentage")]
        public float? ChangePercentage { get; set; }

        [JsonProperty("average_volume")]
        public int AverageVolume { get; set; }

        [JsonProperty("last_volume")]
        public int LastVolume { get; set; }

        [JsonProperty("trade_date")]
        [JsonConverter(typeof(MillisecondsEpochConverter))]
        public DateTime TradeDate { get; set; }

        [JsonProperty("prevclose")]
        public float? PreviousClose { get; set; }

        [JsonProperty("week_52_high")]
        public float Week52High { get; set; }

        [JsonProperty("week_52_low")]
        public float Week52Low { get; set; }

        [JsonProperty("bidsize")]
        public int BidSize { get; set; }

        [JsonProperty("bidexch")]
        public string BidExchange { get; set; }

        [JsonProperty("bid_date")]
        [JsonConverter(typeof(MillisecondsEpochConverter))]
        public DateTime BidDate { get; set; }

        [JsonProperty("asksize")]
        public int AskSize { get; set; }

        [JsonProperty("askexch")]
        public string AskExchange { get; set; }

        [JsonProperty("ask_date")]
        [JsonConverter(typeof(MillisecondsEpochConverter))]
        public DateTime AskDate { get; set; }

        [JsonProperty("open_interest")]
        public int OpenInterest { get; set; }

        [JsonProperty("contract_size")]
        public int ContractSize { get; set; }

        [JsonProperty("expiration_date")]
        public DateTime ExpirationDate { get; set; }

        [JsonProperty("expiration_type")]
        public string ExpirationType { get; set; }

        [JsonProperty("option_type")]
        public OptionType OptionType { get; set; }

        [JsonProperty("root_symbol")]
        public string RootSymbol { get; set; }

        [JsonProperty("greeks")]
        public Greeks Greeks { get; set; }

    }
}
