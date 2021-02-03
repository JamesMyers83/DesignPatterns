using System;

namespace DesignPatterns.Clients
{
    public class FactoryMethodClient
    {
        public void PrintFactoryMethod()
        {
            bool exitLoop = false;

            Creational.FactoryMethod.BeachTripFactory beachTripFactory;
            Creational.FactoryMethod.IBeachTrip selectedTrip;

            while (!exitLoop)
            {
                beachTripFactory = null;
                Console.WriteLine("Factory Method Example. Enter 1 for Bahamas Trip, 2 for Cancun Trip, 3 for Jamaica Trip, 4 for Punta Cana Trip, or 5 to exit:");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.KeyChar.ToString().Equals("1"))
                    beachTripFactory = new Creational.FactoryMethod.BahamasTripFactory();
                else if (keyInfo.KeyChar.ToString().Equals("2"))
                    beachTripFactory = new Creational.FactoryMethod.CancunTripFactory();
                else if (keyInfo.KeyChar.ToString().Equals("3"))
                    beachTripFactory = new Creational.FactoryMethod.JamaicaTripFactory();
                else if (keyInfo.KeyChar.ToString().Equals("4"))
                    beachTripFactory = new Creational.FactoryMethod.PuntaCanaTripFactory();
                else if (keyInfo.KeyChar.ToString().Equals("5"))
                    exitLoop = true;
                else
                    Console.WriteLine("Selection must be the numbers 1-5");

                Console.WriteLine();

                if (beachTripFactory != null)
                {
                    selectedTrip = beachTripFactory.CreateTrip();
                    Console.WriteLine($"Selected Trip: {selectedTrip.BeachLocation} for {selectedTrip.DaysInTrip} days at a price of ${selectedTrip.TripPrice}");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("End Factory Method Example");
        }
    }
}
