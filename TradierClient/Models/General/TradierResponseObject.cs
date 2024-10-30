using System;
using System.Collections.Generic;
using System.Text;

namespace Tradier.Client.Models.General
{
    public class TradierResponseObject
    {
        public bool HasError => Error != null;

        public string Error { get; set; }
    }
}
