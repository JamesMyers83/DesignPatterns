using System;

namespace DesignPatterns.Clients
{
    public class TemplateClient
    {
        public void PrintTemplate()
        {
            Behavioral.Template.CookieMaker cookieMaker = null;
            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Template Example.");
                Console.WriteLine();
                Console.WriteLine("Type number of cookie to make");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Chocolate Chip");
                Console.WriteLine("2 - Peanut Butter");
                Console.WriteLine("3 - Snickerdoodle");
                Console.WriteLine("4 - Sugar");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        cookieMaker = new Behavioral.Template.ChocolateChipCookies();
                        break;
                    case "2":
                        cookieMaker = new Behavioral.Template.PeanutButterCookies();
                        break;
                    case "3":
                        cookieMaker = new Behavioral.Template.SnickerdoodleCookies();
                        break;
                    case "4":
                        cookieMaker = new Behavioral.Template.SugarCookies();
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 0-4");
                        break;
                }

                if (cookieMaker != null)
                    Console.Write(cookieMaker.MakeCookies());

                Console.WriteLine();
            }

            Console.WriteLine("End Template Example");
            Console.WriteLine();
        }
    }
}
