using System;

namespace DesignPatterns.Clients
{
    public class ProxyClient
    {
        public void PrintProxy()
        {
            Structural.Proxy.StockQuote quote = null;
            Structural.Proxy.StockQuoteRequestProxy requestProxy = new Structural.Proxy.StockQuoteRequestProxy();

            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Proxy Example.");
                Console.WriteLine();
                Console.WriteLine("Type stock symbol to lookup or 0 to exit");

                string userInput = Console.ReadLine();

                if (userInput == "0")
                    exitLoop = true;
                else
                {
                    Console.WriteLine();

                    DateTime startTime = DateTime.Now;
                    Console.WriteLine($"Response start time: {startTime.ToLongTimeString()}");

                    quote = requestProxy.GetDailyStockQuote(userInput);

                    if (quote == null)
                        Console.WriteLine($"No stock quote returned for {userInput}");
                    else
                    {
                        Console.WriteLine($"Symbol {quote.Symbol}:");
                        Console.WriteLine($"Requested on {quote.RequestDate}:");
                        Console.WriteLine($"Response: {quote.QuoteResponse}");
                        Console.WriteLine($"Was this cached: {requestProxy.IsFromCache}");
                        quote = null;

                        TimeSpan span = DateTime.Now - startTime;
                        Console.WriteLine($"Response elapsed millisecons {span.TotalMilliseconds}");
                        Console.WriteLine($"Response start time: {startTime.ToLongTimeString()}");
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("End Proxy Example.");
            Console.WriteLine();
        }
    }
}
