using System;

namespace DesignPatterns.Clients
{
    public class AbstractFactoryClient
    {
        public void PrintAbstractFactory()
        {
            bool exitLoop = false;
            Creational.AbstractFactory.CarFactory carFactory;
            Creational.AbstractFactory.ICarModel carModel;

            while (!exitLoop)
            {
                carFactory = null;
                carModel = null;

                Console.WriteLine("Abstract Factory Example...");
                Console.WriteLine("Type number of Car Company to view");
                Console.WriteLine("0 - Exit");

                EnumPrinter.EnumerateEnumToString(typeof(Creational.AbstractFactory.CarCompany));

                switch (Console.ReadLine())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        carFactory = new Creational.AbstractFactory.AstonMartinFactory();
                        break;
                    case "2":
                        carFactory = new Creational.AbstractFactory.AudiFactory();
                        break;
                    case "3":
                        carFactory = new Creational.AbstractFactory.FerrariFactory();
                        break;
                    case "4":
                        carFactory = new Creational.AbstractFactory.FordFactory();
                        break;
                    case "5":
                        carFactory = new Creational.AbstractFactory.HondaFactory();
                        break;
                    case "6":
                        carFactory = new Creational.AbstractFactory.HyundaiFactory();
                        break;
                    case "7":
                        carFactory = new Creational.AbstractFactory.MazdaFactory();
                        break;
                    case "8":
                        carFactory = new Creational.AbstractFactory.NissanFactory();
                        break;
                    case "9":
                        carFactory = new Creational.AbstractFactory.PorshceFactory();
                        break;
                    case "10":
                        carFactory = new Creational.AbstractFactory.ToyotaFactory();
                        break;
                    case "11":
                        carFactory = new Creational.AbstractFactory.VolkswagenFactory();
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 0-11");
                        break;
                }

                Console.WriteLine();

                if (carFactory != null)
                {
                    Console.WriteLine("Type one of the following models");

                    foreach (string model in carFactory.GetModelList())
                        Console.WriteLine($"{model}");

                    string selectedModel = Console.ReadLine();
                    Console.WriteLine($"{selectedModel} was selected");

                    carModel = carFactory.CreateCar(selectedModel);

                    if (carModel == null)
                        Console.WriteLine("Must type correct product name");
                    else
                        Console.WriteLine($"Selected {carModel.ModelName}, {carModel.CarType} ${carModel.Price}");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("End Abstract Factory Example");
        }
    }
}
