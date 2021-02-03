using System;

namespace DesignPatterns.Clients
{
    public class FlyweightClient
    {
        public void PrintFlyweight()
        {
            Structural.Flyweight.CodedCharacterFactory characterFactory = new Structural.Flyweight.CodedCharacterFactory();

            Console.WriteLine("Flyweight Example");
            Console.WriteLine();
            Console.WriteLine("Morse code converer");

            Console.WriteLine("Type string to represent the dot and press enter:");
            string dot = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Type string to represent the dash and press enter:");
            string dash = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Type or copy a block of text and press enter to convert to morse code:");
            string userInput = Console.ReadLine();

            //this will ignore and skip any characters not in morse code dictionary
            foreach (char c in userInput)
            {
                int charNum = c;

                if (charNum == 32 || charNum == 44 || charNum == 46 || charNum == 63 || (charNum > 64 && charNum < 91) || (charNum > 96 && charNum < 123))
                {
                    Structural.Flyweight.MorseCodeCharacter codedCharacter = (Structural.Flyweight.MorseCodeCharacter)characterFactory.GetCodedCharacter(charNum);
                    codedCharacter.SetDashString(dash);
                    codedCharacter.SetDotString(dot);
                    Console.Write(codedCharacter.GetCodedCharacter());
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Number characters entered: {userInput.Length}");
            Console.WriteLine($"Number of morse code character objects created: {characterFactory.CharacterCreationCounter}");

            Console.WriteLine();
            Console.WriteLine("End Flyweight Exmaple");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
