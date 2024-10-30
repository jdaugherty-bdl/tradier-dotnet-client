using System;
using System.Collections.Generic;
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
            StopLimit
        }

        public enum OrderInstruction
        {
            None,
            BuyToOpen,
            BuyToClose,
            SellToOpen,
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
    }
}
