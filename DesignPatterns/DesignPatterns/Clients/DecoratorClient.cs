using System;

namespace DesignPatterns.Clients
{
    public class DecoratorClient
    {
        public void PrintDecorator()
        {
            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Decorator Example.");

                Structural.Decorator.IHotBeverage beverage = null;

                Console.WriteLine("Type number of beverage to make");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Coffee");
                Console.WriteLine("2 - Tea");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        beverage = new Structural.Decorator.Coffee();
                        break;
                    case "2":
                        beverage = new Structural.Decorator.Tea();
                        break;
                    default:
                        Console.WriteLine("Must choose option 0-2");
                        break;
                }

                if (beverage != null)
                {
                    beverage.MakeBeverage();
                    Console.WriteLine(beverage.BeverageDescription);
                    Console.WriteLine();

                    Console.WriteLine("Type number of addittion to add ('decorate') to beverage");
                    Console.WriteLine("0 - Exit");
                    Console.WriteLine("1 - Milk");
                    Console.WriteLine("2 - Sugar");

                    keyInfo = Console.ReadKey();

                    switch (keyInfo.KeyChar.ToString())
                    {
                        case "0":
                            exitLoop = true;
                            break;
                        case "1":
                            Structural.Decorator.BeverageMilkDecorator milkDecorator = new Structural.Decorator.BeverageMilkDecorator(beverage);
                            milkDecorator.MakeBeverage();
                            Console.WriteLine(beverage.BeverageDescription);
                            break;
                        case "2":
                            Structural.Decorator.BeverageSugarDecorator sugarDecorator = new Structural.Decorator.BeverageSugarDecorator(beverage);
                            sugarDecorator.MakeBeverage();
                            Console.WriteLine(beverage.BeverageDescription);
                            break;
                        default:
                            Console.WriteLine("Must selecte 0-2");
                            break;
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("End Decorator Example.");
        }
    }
}
