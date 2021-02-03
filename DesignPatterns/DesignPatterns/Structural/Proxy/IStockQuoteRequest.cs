namespace DesignPatterns.Structural.Proxy
{
    public interface IStockQuoteRequest
    {
        StockQuote GetDailyStockQuote(string symbol);
    }
}
