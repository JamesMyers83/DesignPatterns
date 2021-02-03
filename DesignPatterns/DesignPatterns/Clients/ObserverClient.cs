using System;

namespace DesignPatterns.Clients
{
    public class ObserverClient
    {
        public void PrintObserver()
        {
            Behavioral.Observer.Blog blog = new Behavioral.Observer.Blog("Sample Blog");
            Behavioral.Observer.PassiveObserver po = new Behavioral.Observer.PassiveObserver("Passive");
            Behavioral.Observer.ActiveObserver ao = new Behavioral.Observer.ActiveObserver("Active");
            blog.Register(po);
            blog.Register(ao);

            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Observer Example.");
                Console.WriteLine();
                Console.WriteLine("Write a new blog entry (or 0 to exit):");

                string blogEntry = Console.ReadLine();

                if (blogEntry == "0")
                    exitLoop = true;

                if (!exitLoop)
                {
                    Console.WriteLine("Is this a major update? [yes]/[no]:");
                    string major = Console.ReadLine();

                    if (major == "yes")
                        blog.AddBlogMessage(blogEntry, true);
                    else //default is no
                        blog.AddBlogMessage(blogEntry, false);

                    Console.Write($"{po.Name}: {po.SubscribedBlog}");
                    Console.WriteLine();
                    Console.WriteLine($"{ao.Name}: {ao.SubscribedBlog}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("End Observer Example");
            Console.WriteLine();
        }
    }
}
