using System;

namespace DesignPatterns.Clients
{
    public class IteratorClient
    {
        public void PrintIterator()
        {
            Console.WriteLine("Iterator Example");
            Console.WriteLine();

            Behavioral.Iterator.GuitarAggregate collection = new Behavioral.Iterator.GuitarAggregate();

            #region AddGuitars

            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Ernie", Model = "Ball Music Man John Petrucci Majesty Monarchy" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Ibanez", Model = "RG5121" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Gibson", Model = "Les Paul Standard 2019" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "EVH", Model = "Striped Series 5150" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Fender", Model = "American Special Stratocaster" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Yamaha", Model = "RevStar RS420" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Charvel", Model = "Pro-Mod DK24 HSH 2PT CM" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Ibanez", Model = "RG450DX" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Yamaha", Model = "Pacifica Series PAC112V" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Squier", Model = "Affinity Stratocaster SSS" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Fender", Model = "Modern Player Telecaster" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Gretsch", Model = "Electromatic G5425" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Squier", Model = "Affinity Jazzmaster HH" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Fender", Model = "American Special Telecaster" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Ibanez", Model = "Series Iron Label SIX6FDFM" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Yamaha", Model = "RevStar RS420-2" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Squier", Model = "by Fender Classic Vibe 50s Telecaster" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Epiphone", Model = "Les Paul Standard" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Jackson", Model = "JS32 Rhoads" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Ibanez", Model = "RG421" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Squier", Model = "Standard Stratocaster" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Schecter", Model = "C-1 SGR" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Squier", Model = "Bullet Mustang HH" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Yamaha", Model = "Pacifica Series PAC012" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Fender", Model = "Rory Gallagher Signature Stratocaster" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Godin", Model = "LGXT 3-Voice Solid Body" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Dean", Model = "MAB1 Speed of Light" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Godin", Model = "5th Avenue CWKingpin II" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Gretsch", Model = "G5420T" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Schecter", Model = "Banshee Elite-7 FR S" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Ibanez", Model = "M80M Meshuggah Signature" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Gretsch", Model = "G100CE Synchromatic" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "Fender", Model = "Eric Clapton Stratocaster" });
            collection.AddGuitar(new Behavioral.Iterator.Guitar() { Brand = "ESP", Model = "LTD EC-Black Metal" });

            #endregion

            Behavioral.Iterator.GuitarIterator guitarIterator = collection.CreateIterator();

            Console.WriteLine("Guitar Collection:");

            for (Behavioral.Iterator.Guitar guitar = guitarIterator.First(); !guitarIterator.IsDone(); guitar = guitarIterator.Next())
                Console.WriteLine($"Brand: {guitar.Brand} | Model: {guitar.Model}");

            Console.WriteLine();
            Console.WriteLine("End Iterator Example");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
