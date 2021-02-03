namespace DesignPatterns.Structural.Proxy
{
    //real subject that returns stock quote object populating the response with web quote
    public class StockQuoteRequest : IStockQuoteRequest
    {
        private const string apiKey = @"30FSPNYSK5UT308F";
        private const string stockUrl = @"https://www.alphavantage.co/query?function=";
        private string functionType = "TIME_SERIES_DAILY";

        public StockQuote GetDailyStockQuote(string symbol)
        {
            HttpUtility httpUtility = new HttpUtility();            

            StockQuote quote = new StockQuote
            {
                Symbol = symbol,
                QuoteResponse = httpUtility.GetHttpResponseText(GetStockUrl(symbol), HttpUtility.HttpRequestMethods.GET)
            };

            return quote;
        }

        private string GetStockUrl(string symbol) => $"{stockUrl}{functionType}&symbol={symbol}&apikey={apiKey}";

    }
}
