using System;

namespace DesignPatterns.Clients
{
    public class FluentInterfaceClient
    {
        public void PrintFluentInterface()
        {
            Creational.FluentInterface.FluentSportsTeam sportsTeam = new Creational.FluentInterface.FluentSportsTeam();

            Console.WriteLine("Fluent Interface Example. This is not an original 23 GoF pattern.");
            Console.WriteLine("This example is better illustrated by stepping through.");
            Console.WriteLine("Instead of setting each property separately, we can string methods together to make building an object more 'fluent'.");
            Console.WriteLine();
            Console.WriteLine("Example code: sportsTeam.NameOfTeam('Chicago Bears').LocatedIn('Chicago, IL').PlaysSport('Football').HasNumberOfActivePlayers(53).AreCurrentChampionsInTheirLeague(false);'");

            sportsTeam.NameOfTeam("Chicago Bears")
                .LocatedIn("Chicago, IL")
                .PlaysSport("Football")
                .HasNumberOfActivePlayers(53)
                .AreCurrentChampionsInTheirLeague(false);

            Console.WriteLine("Output:");
            Console.WriteLine(sportsTeam.GetSportsTeam().ToString());
            Console.WriteLine();
            Console.WriteLine("End Fluent Interface Example");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
