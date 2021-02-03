using System;

namespace DesignPatterns.Clients
{
    public class CommandClient
    {
        public void PrintCommand()
        {
            Behavioral.Command.Cook cook = new Behavioral.Command.Cook();
            Behavioral.Command.Waiter waiter = new Behavioral.Command.Waiter();

            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Command Example.");
                Console.WriteLine();
                Console.WriteLine("Type number item to order");
                Console.WriteLine("1 - Order salad");
                Console.WriteLine("2 - Order burger");
                Console.WriteLine("3 - Order dessert");
                Console.WriteLine("4 - Complete order");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "1":
                        waiter.TakeOrder(new Behavioral.Command.SaladOrder(cook));
                        break;
                    case "2":
                        waiter.TakeOrder(new Behavioral.Command.BurgerOrder(cook));
                        break;
                    case "3":
                        waiter.TakeOrder(new Behavioral.Command.DessertOrder(cook));
                        break;
                    case "4":
                        exitLoop = true;
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 1-4");
                        break;
                }
            }

            Console.WriteLine();
            Console.Write(waiter.PlaceOrders());
            Console.WriteLine();
            Console.WriteLine("End Command Example");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
