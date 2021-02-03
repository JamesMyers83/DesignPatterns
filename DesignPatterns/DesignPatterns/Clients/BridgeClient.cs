using System;

namespace DesignPatterns.Clients
{
    public class BridgeClient
    {
        public void PrintBridge()
        {
            bool exitLoop = false;

            while (!exitLoop)
            {
                Structural.Bridge.AbstractDataManager dataManager = null;
                Structural.Bridge.IDataRepo repo = null;

                string inputData = null;

                Console.WriteLine("Bridge Example.");
                Console.WriteLine();
                Console.WriteLine("Type number for where to save data");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Database");
                Console.WriteLine("2 - File");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        Console.WriteLine("Enter database connection:");
                        repo = new Structural.Bridge.Database(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("Enter file name:");
                        repo = new Structural.Bridge.File(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Must choose option 0-2");
                        break;
                }

                if (!exitLoop)
                {
                    Console.WriteLine("Type number of data to enter");
                    Console.WriteLine("0 - Exit");
                    Console.WriteLine("1 - User");
                    Console.WriteLine("2 - Log");

                    keyInfo = Console.ReadKey();
                    Console.WriteLine();

                    switch (keyInfo.KeyChar.ToString())
                    {
                        case "0":
                            exitLoop = true;
                            break;
                        case "1":
                            Console.WriteLine("Enter User Name:");
                            inputData = Console.ReadLine();
                            dataManager = new Structural.Bridge.UserEnteredDataManager(repo);
                            break;
                        case "2":
                            Console.WriteLine("Enter log message:");
                            inputData = Console.ReadLine();
                            dataManager = new Structural.Bridge.LogDataManager(repo);
                            break;
                        default:
                            Console.WriteLine("Must choose option 0-2");
                            break;
                    }
                }

                if (inputData != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Type number of how to interact with data");
                    Console.WriteLine("0 - Exit");
                    Console.WriteLine("1 - Save");
                    Console.WriteLine("2 - Delete");
                    Console.WriteLine("3 - Update");

                    keyInfo = Console.ReadKey();
                    Console.WriteLine();

                    switch (keyInfo.KeyChar.ToString())
                    {
                        case "0":
                            exitLoop = true;
                            break;
                        case "1":
                            Console.WriteLine(dataManager.SaveDataToRepo(inputData));
                            break;
                        case "2":
                            Console.WriteLine(dataManager.DeleteDataFromRepo(inputData));
                            break;
                        case "3":
                            Console.WriteLine("Type old data to replace:");
                            string old = "";
                            old = Console.ReadLine();
                            if (old != null)
                                Console.WriteLine(dataManager.UpdateDataInRepo(old, inputData));
                            break;
                        default:
                            Console.WriteLine("Must choose option 0-3");
                            break;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Bridge Decorator Example.");
        }
    }
}
