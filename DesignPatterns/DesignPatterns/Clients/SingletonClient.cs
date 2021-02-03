using System;
using System.Threading.Tasks;

namespace DesignPatterns.Clients
{
    public class SingletonClient
    {
        public void PrintSingleton()
        {
            Console.WriteLine("Singelton Example.");
            Console.WriteLine("Initiliazing two instances and returning internal count.");
            Parallel.Invoke(
                () => SingletonFirstCaller(),
                () => SingletonSecondCaller()
                );

            Console.WriteLine();
            Console.WriteLine("End Singelton Example");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


        private void SingletonFirstCaller()
        {
            Creational.Singleton.ThreadSafeSingleton singleton = Creational.Singleton.ThreadSafeSingleton.Instance;
            Console.WriteLine(singleton.GetInstanceCountMessage("First Caller"));
        }

        private void SingletonSecondCaller()
        {
            Creational.Singleton.ThreadSafeSingleton singleton = Creational.Singleton.ThreadSafeSingleton.Instance;
            Console.WriteLine(singleton.GetInstanceCountMessage("Second Caller"));
        }
    }
}
