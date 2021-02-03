using System;

namespace DesignPatterns.Clients
{
    public class SimpleFactoryClient
    {
        public void PrintSimpleFactory()
        {
            bool exitLoop = false;

            Creational.SimpleFactory.FlowerFactory flowerFactory = new Creational.SimpleFactory.FlowerFactory();
            Creational.SimpleFactory.IFlower selectedFlower;

            while (!exitLoop)
            {
                selectedFlower = null;
                Console.WriteLine("Simple Factory Example. Enter 1 for RoseBush, 2 for Tulip, 3 for Orchid, or 4 to exit:");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.KeyChar.ToString().Equals("1"))
                    selectedFlower = flowerFactory.GetFlower("Rose Bush");
                else if (keyInfo.KeyChar.ToString().Equals("2"))
                    selectedFlower = flowerFactory.GetFlower("Tulip");
                else if (keyInfo.KeyChar.ToString().Equals("3"))
                    selectedFlower = flowerFactory.GetFlower("Orchid");
                else if (keyInfo.KeyChar.ToString().Equals("4"))
                    exitLoop = true;
                else
                    Console.WriteLine("Selection must be the numbers 1-4");

                Console.WriteLine();

                if (selectedFlower != null)
                    Console.WriteLine($"Selected flower: {selectedFlower.FlowerType()} has price of ${selectedFlower.Price()}");
            }

            Console.WriteLine();
            Console.WriteLine("End Sample Factory Example");
        }
    }
}
