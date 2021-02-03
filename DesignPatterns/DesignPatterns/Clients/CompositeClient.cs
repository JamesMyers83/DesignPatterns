using System;

namespace DesignPatterns.Clients
{
    public class CompositeClient
    {
        public void PrintComposite()
        {
            #region team1

            Structural.Composite.IComponent qb = new Structural.Composite.Player
            {
                Name = "Captain Big Arm",
                PlaceOfOrigin = "Texas",
                Salary = 25000000
            };

            Structural.Composite.IComponent wr = new Structural.Composite.Player
            {
                Name = "Speedy Good Hands",
                PlaceOfOrigin = "Florida",
                Salary = 13000000
            };

            Structural.Composite.IComponent rb = new Structural.Composite.Player()
            {
                Name = "Juke and Run",
                PlaceOfOrigin = "California",
                Salary = 7000000
            };

            Structural.Composite.Composite team = new Structural.Composite.Composite()
            {
                Name = "Ball Team",
                PlaceOfOrigin = "Chicago"
            };

            team.AddChild(qb);
            team.AddChild(wr);
            team.AddChild(rb);

            #endregion

            #region team2

            Structural.Composite.IComponent qb2 = new Structural.Composite.Player
            {
                Name = "The Cannon",
                PlaceOfOrigin = "California",
                Salary = 29500000
            };

            Structural.Composite.IComponent wr2 = new Structural.Composite.Player
            {
                Name = "Greased Lightning",
                PlaceOfOrigin = "Michigan",
                Salary = 9550000
            };

            Structural.Composite.IComponent wr3 = new Structural.Composite.Player
            {
                Name = "High Leaper",
                PlaceOfOrigin = "Nebraska",
                Salary = 12450000
            };

            Structural.Composite.IComponent rb2 = new Structural.Composite.Player()
            {
                Name = "Bull Dozer",
                PlaceOfOrigin = "Illinois",
                Salary = 11400000
            };

            Structural.Composite.Composite team2 = new Structural.Composite.Composite()
            {
                Name = "Sporting Team",
                PlaceOfOrigin = "Cleveland"
            };

            team2.AddChild(qb2);
            team2.AddChild(wr2);
            team2.AddChild(wr3);
            team2.AddChild(rb2);

            #endregion

            Structural.Composite.Composite league = new Structural.Composite.Composite()
            {
                Name = "Pro Football Legue",
                PlaceOfOrigin = "USA"
            };

            league.AddChild(team);
            league.AddChild(team2);

            Console.WriteLine($"Quarterback: {qb}");
            Console.WriteLine($"Wide reciever: {wr}");
            Console.WriteLine($"Running back: {rb}");
            Console.WriteLine($"Team: {team}");

            Console.WriteLine($"Quarterback: {qb2}");
            Console.WriteLine($"Wide reciever: {wr2}");
            Console.WriteLine($"Wide reciever: {wr3}");
            Console.WriteLine($"Running back: {rb2}");
            Console.WriteLine($"Team: {team2}");

            Console.WriteLine($"League: {league}");

            Console.WriteLine();
            Console.WriteLine("End Composite Exmaple");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
