using System;

namespace DesignPatterns.Clients
{
    public class BuilderClient
    {
        public void PrintBuilder()
        {
            Creational.Builder.SandwichBuilder sandwichBuilder;
            Creational.Builder.SandwichDirector sandwichDirector;
            Creational.Builder.Sandwich selectedSandwich;

            bool exitLoop = false;

            while (!exitLoop)
            {
                sandwichBuilder = null;

                Console.WriteLine("Builder Example...");
                Console.WriteLine("Type number of sandwich to view");
                Console.WriteLine("0 - Exit");

                EnumPrinter.EnumerateEnumToString(typeof(Creational.Builder.SandwichType));

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        sandwichBuilder = new Creational.Builder.SubSandwichBuilder();
                        break;
                    case "2":
                        sandwichBuilder = new Creational.Builder.MeltSandwichBuilder();
                        break;
                    case "3":
                        sandwichBuilder = new Creational.Builder.DeliSandwichBuilder();
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 0-3");
                        break;
                }

                Console.WriteLine();

                if (sandwichBuilder != null)
                {
                    sandwichDirector = new Creational.Builder.SandwichDirector();
                    selectedSandwich = sandwichDirector.ConstructSandwich(sandwichBuilder);
                    Console.WriteLine(selectedSandwich.GetSandwichDescription());
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("End Builder Example");
        }
    }
}
