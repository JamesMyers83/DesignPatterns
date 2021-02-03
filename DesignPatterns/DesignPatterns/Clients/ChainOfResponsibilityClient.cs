using System;

namespace DesignPatterns.Clients
{
    public class ChainOfResponsibilityClient
    {
        public void PrintChainOfResponsibility()
        {
            Behavioral.ChainOfResponsibility.LoginRequester login = new Behavioral.ChainOfResponsibility.LoginRequester();
            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Chain Of Responsibility Example.");
                Console.WriteLine();
                Console.Write("Enter user name (or 0 to exit):");
                string user = Console.ReadLine();

                if (user == "0")
                    exitLoop = true;
                else
                {
                    Console.Write("Enter password:");
                    string pwd = Console.ReadLine();
                    Console.WriteLine(login.GetLoginResponse(user, pwd));
                }

                Console.WriteLine();
            }

            Console.WriteLine("End Chain Of Responsibility Example");
            Console.WriteLine();
        }
    }
}
