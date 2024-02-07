using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabler.Docs.Data
{
    public class MarketQuote
    {
        public int id { get; set; }
        public DateTime QuoteDate { get; set; }
        public string Broker { get; set; }
        public string CUSIP { get; set; }
        public string Bond { get; set; }
        public int Size { get; set; }
        public string Actions { get; set; }
        public decimal Price { get; set; }
    }

}
