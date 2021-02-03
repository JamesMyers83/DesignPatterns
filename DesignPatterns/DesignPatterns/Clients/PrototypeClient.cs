using System;
using System.Collections.Generic;

namespace DesignPatterns.Clients
{
    public class PrototypeClient
    {
        public void PrintPrototype()
        {
            Console.WriteLine("Prototype Example. This solution differs from GoF slightly.");
            Console.WriteLine("By using object serialization you can deep copy object properties. Also implements interface that declares cloning itself.");
            Console.WriteLine("This does not solve issues with circular object references, as will be demonstrated");
            Console.WriteLine();
            Console.WriteLine("First example creates a Person object then copies the object with an = operator and displays the data of both.");

            string bobsName = "Bob Belcher";
            string lindasName = "Linda Belcher";

            //this would be a great place to use the Fluent Interface pattern
            Creational.Prototype.SafePerson bob = new Creational.Prototype.SafePerson
            {
                Name = "Bob Belcher",
                Age = 50,
                Address = new Creational.Prototype.Address
                {
                    Street = "",
                    City = new Creational.Prototype.City
                    {
                        CityName = "Seymours Bay",
                        CountryName = "USA"
                    }
                }
            };


            Creational.Prototype.SafePerson linda = bob;

            Console.WriteLine($"First Person:{bob}");
            Console.WriteLine();
            Console.WriteLine($"Second Person:{linda}");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine($"Updating second person name to {lindasName} to show object copies are references only.");
            Console.WriteLine();

            linda.Name = lindasName;

            Console.Write($"First Person:{bob}");
            Console.WriteLine();
            Console.Write($"Second Person:{linda}");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine($"Resetting first person name to {bobsName}.");
            Console.WriteLine($"Impementing Clone method and updating second person age and name to {lindasName}");
            Console.WriteLine();

            bob.Name = bobsName;
            linda = bob.Clone();
            linda.Name = lindasName;
            linda.Age = 45;

            Console.Write($"First Person:{bob}");
            Console.WriteLine();
            Console.Write($"Second Person:{linda}");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine("Adding children with Father and Mother properties");

            Creational.Prototype.SafePerson tina = bob.Clone();
            tina.Name = "Tina Belcher";
            tina.Age = 13;
            tina.Father = bob;
            tina.Mother = linda;

            Creational.Prototype.SafePerson gene = tina.Clone();
            gene.Name = "Gene Belcher";
            gene.Age = 11;

            Creational.Prototype.SafePerson louise = tina.Clone();
            louise.Name = "Louise Belcher";
            louise.Age = 9;

            Console.WriteLine("Printing all people:");
            Console.Write($"Bob: {bob}");
            Console.WriteLine();
            Console.Write($"Linda: {linda}");
            Console.WriteLine();
            Console.Write($"Tina: {tina}");
            Console.WriteLine();
            Console.Write($"Gene: {gene}");
            Console.WriteLine();
            Console.Write($"Louise: {louise}");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine($"Now adding children to fisrt person ({bobsName})");

            bob.Children = new List<Creational.Prototype.SafePerson>() { tina, gene, louise };

            Console.Write($"Bob: {bob}");
            Console.WriteLine();

            Console.WriteLine($"Now adding children to second person ({lindasName})");

            linda.Children = new List<Creational.Prototype.SafePerson>() { tina, gene, louise };

            Console.Write($"Linda: {linda}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("End Prototype Example");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
