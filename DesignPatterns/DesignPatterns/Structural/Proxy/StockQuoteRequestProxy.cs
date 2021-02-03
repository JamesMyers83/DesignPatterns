using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Proxy
{
    //proxy class, only makes expensive request to web if quote is not cached from today
    //this would be a good candidate for a singleton pattern
    public class StockQuoteRequestProxy : IStockQuoteRequest
    {
        private List<StockQuote> stockQuotes = new List<StockQuote>();

        public bool IsFromCache { get; set; }

        public StockQuote GetDailyStockQuote(string symbol)
        {
            IsFromCache = true;
            StockQuote quote = new StockQuote();

            if (stockQuotes.Count() > 0 && stockQuotes.Any(q => q.Symbol == symbol && q.RequestDate == quote.RequestDate))
                quote = stockQuotes.Where(q => q.Symbol == symbol && q.RequestDate == quote.RequestDate).First();

            if (quote.QuoteResponse == null)
            {
                IsFromCache = false;
                StockQuoteRequest request = new StockQuoteRequest();
                quote = request.GetDailyStockQuote(symbol);
                stockQuotes.Add(quote);
            }

            return quote;
        }
    }
}
