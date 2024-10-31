using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Tradier.Client.Models.General
{
    public class GeneralEnumHolder
    {
        public enum OptionType
        {
            None,
            Call,
            Put
        }

        public enum OrderType
        {
            None,
            Market,
            Limit,
            Stop,
            [EnumMember(Value = "stop_limit")]
            StopLimit,
            Debit,
            Credit,
            Even
        }

        public enum OrderInstruction
        {
            None,
            Buy,
            [EnumMember(Value = "buy_to_cover")]
            BuyToCover,
            Sell,
            [EnumMember(Value = "sell_short")]
            SellShort,
            [EnumMember(Value = "buy_to_open")]
            BuyToOpen,
            [EnumMember(Value = "buy_to_close")]
            BuyToClose,
            [EnumMember(Value = "sell_to_open")]
            SellToOpen,
            [EnumMember(Value = "sell_to_close")]
            SellToClose
        }

        public enum OrderDuration
        {
            None,
            Day,
            Gtc,
            Pre,
            Post
        }

        public enum OrderStatus
        {
            None,
            Open,
            [EnumMember(Value = "partially_filled")]
            PartiallyFilled,
            Filled,
            Expired,
            Canceled,
            Pending,
            Rejected,
            Error
        }

        public enum OrderClass
        {
            None,
            Equity,
            Option,
            Combo,
            Multileg
        }

        public enum OrderStrategy
        {
            None,
            Freeform,
            [EnumMember(Value = "covered_call")]
            CoveredCall,
            [EnumMember(Value = "protective_put")]
            ProtectivePut,
            Strangle,
            Straddle,
            Spread,
            Collar,
            Butterfly,
            Condor,
            Unknown
        }
    }
}
