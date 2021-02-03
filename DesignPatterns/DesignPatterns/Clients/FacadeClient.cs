using System;

namespace DesignPatterns.Clients
{
    public class FacadeClient
    {
        public void PrintFacade()
        {
            Console.WriteLine("Facade Example.");

            Structural.Facade.OrderProcessingFacade orderProcessing = new Structural.Facade.OrderProcessingFacade();
            Structural.Facade.Product product = new Structural.Facade.Product();

            Console.WriteLine("Type product name to process order");
            Console.Write(product.ProductListToString());
            Console.WriteLine();
            string selectedProduct = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Type in delivery address");
            string address = Console.ReadLine();
            Console.WriteLine();

            Console.Write(orderProcessing.ProcessOrder(selectedProduct, address));

            Console.WriteLine();
            Console.WriteLine("End Facade Example.");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
