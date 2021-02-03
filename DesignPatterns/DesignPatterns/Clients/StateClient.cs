using System;

namespace DesignPatterns.Clients
{
    public class StateClient
    {
        public void PrintState()
        {
            Behavioral.State.WineBottleContext wineBottle = new Behavioral.State.WineBottleContext();
            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("State Example.");
                Console.WriteLine();
                Console.WriteLine("Type number to perform action");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Read label");
                Console.WriteLine("2 - Unseal bottle");
                Console.WriteLine("3 - Open bottle");
                Console.WriteLine("4 - Pour standard wine glass");
                Console.WriteLine("5 - Close bottle");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        Console.WriteLine(wineBottle.ReadLabel());
                        break;
                    case "2":
                        Console.WriteLine(wineBottle.RemoveSeal());
                        break;
                    case "3":
                        Console.WriteLine(wineBottle.OpenBottle());
                        break;
                    case "4":
                        Console.WriteLine(wineBottle.PourWine(5));
                        break;
                    case "5":
                        Console.WriteLine(wineBottle.CloseBottle());
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 0-5");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("End State Example");
            Console.WriteLine();

        }
    }
}
