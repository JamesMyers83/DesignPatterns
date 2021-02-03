using System;

namespace DesignPatterns.Structural.Proxy
{
    //simple object for holding stock info
    public class StockQuote
    {
        public string Symbol { get; set; }
        public int RequestDate => int.Parse(DateTime.Now.ToString("yyyyMMdd"));
        public string QuoteResponse { get; set; }


    }
}
