using System;

namespace DesignPatterns.Clients
{
    public class MediatorClient
    {
        public void PrintMediator()
        {
            Behavioral.Mediator.ProductOwner po = new Behavioral.Mediator.ProductOwner();
            Behavioral.Mediator.BusinessUser stakeHolder = new Behavioral.Mediator.BusinessUser("John", "Operations Manager", po);
            Behavioral.Mediator.Developer appDev = new Behavioral.Mediator.Developer("Sally", "Software Engineer", po);
            Behavioral.Mediator.Developer webDev = new Behavioral.Mediator.Developer("Tony", "UI Engineer", po);
            Behavioral.Mediator.Developer sqlDev = new Behavioral.Mediator.Developer("Frank", "Database Engineer", po);

            po.AddBusinessUser(stakeHolder);
            po.AddDeveloper(appDev);
            po.AddDeveloper(webDev);
            po.AddDeveloper(sqlDev);

            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Mediator Example");
                Console.WriteLine();

                Console.WriteLine("Type name of project:");
                string name = Console.ReadLine();

                Console.WriteLine("Type brief description:");
                string desc = Console.ReadLine();

                Behavioral.Mediator.Project project = new Behavioral.Mediator.Project(name, desc);
                Console.Write(stakeHolder.Listen(project));

                Console.WriteLine();
                Console.Write(stakeHolder.Communicate());

                Console.WriteLine();
                if (desc.Contains("SQL", StringComparison.OrdinalIgnoreCase))
                    Console.Write(po.AssignDeveloper(sqlDev));
                else if (desc.Contains("web", StringComparison.OrdinalIgnoreCase))
                    Console.Write(po.AssignDeveloper(webDev));
                else
                    Console.Write(po.AssignDeveloper(appDev));

                Console.WriteLine();
                Console.WriteLine("0 - Exit");
                Console.WriteLine("Any other key to repeat");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("End Mediator Example");
        }
    }
}
