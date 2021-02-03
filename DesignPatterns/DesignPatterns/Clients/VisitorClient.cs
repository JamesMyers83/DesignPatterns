using System;

namespace DesignPatterns.Clients
{
    public class VisitorClient
    {
        public void PrintVisitor()
        {
            Behavioral.Visitor.TravelAgency travelAgency = new Behavioral.Visitor.TravelAgency();
            Behavioral.Visitor.IVisitor visitor = null;

            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Visitor Example.");
                Console.WriteLine();

                Console.WriteLine("Type visitor's name (or 0 to exit):");
                string visitorName = Console.ReadLine();
                Console.WriteLine();

                if (visitorName == "0")
                    break;

                Console.WriteLine("Type number of vistor type");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Tourist");
                Console.WriteLine("2 - Photographer");
                Console.WriteLine("3 - Security");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        visitor = new Behavioral.Visitor.Tourist() { Name = visitorName };
                        break;
                    case "2":
                        visitor = new Behavioral.Visitor.Photographer() { Name = visitorName };
                        break;
                    case "3":
                        visitor = new Behavioral.Visitor.Security() { Name = visitorName };
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 0-3");
                        break;
                }

                if (visitor != null)
                {
                    while (!exitLoop)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Type number of location");
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - Chicago");
                        Console.WriteLine("2 - Orlando");
                        Console.WriteLine("3 - New York");
                        Console.WriteLine("4 - Visit all");

                        ConsoleKeyInfo placeKey = Console.ReadKey();
                        Console.WriteLine();

                        switch (placeKey.KeyChar.ToString())
                        {
                            case "0":
                                exitLoop = true;
                                break;
                            case "1":
                                Console.WriteLine(visitor.VisitCity(travelAgency.Chicago));
                                Console.WriteLine(visitor.VisitAttraction(travelAgency.theBean));
                                break;
                            case "2":
                                Console.WriteLine(visitor.VisitCity(travelAgency.Orlando));
                                Console.WriteLine(visitor.VisitAttraction(travelAgency.disneyWorld));
                                break;
                            case "3":
                                Console.WriteLine(visitor.VisitCity(travelAgency.NewYork));
                                Console.WriteLine(visitor.VisitAttraction(travelAgency.empireState));
                                break;
                            case "4":
                                Console.WriteLine(travelAgency.VisitAllPlaces(visitor));
                                break;
                            default:
                                Console.WriteLine("Selection must be the numbers 0-4");
                                break;
                        }

                        Console.WriteLine();
                    }

                    exitLoop = false;
                    visitor = null;
                }

                Console.WriteLine();
                Console.WriteLine("End Visitor Example");
            }
        }
    }
}
