using System;

namespace DesignPatterns.Clients
{
    public class MementoClient
    {
        public void PrintMemento()
        {
            Behavioral.Memento.Caretaker caretaker = new Behavioral.Memento.Caretaker();

            bool exitLoop = false;

            while (!exitLoop)
            {
                Behavioral.Memento.MessageOriginator message = null;

                Console.WriteLine("Memento Example");
                Console.WriteLine();

                Console.WriteLine("Type message to save (or 0 to exit)");
                string entry = Console.ReadLine();
                Console.WriteLine();

                if (entry == "0")
                    exitLoop = true;
                else
                {
                    message = new Behavioral.Memento.MessageOriginator(entry);
                    caretaker.AddMemento(message.Save());
                }

                if (!exitLoop)
                {
                    Console.WriteLine("All message saved:");
                    foreach (Behavioral.Memento.Memento memento in caretaker.GetAllMementos())
                        Console.WriteLine($"{memento.GetMessage()}");

                    Console.WriteLine();
                    Console.WriteLine("Type 0 to type a new message or 1 to remove previoius");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.WriteLine();

                    if (keyInfo.KeyChar.ToString() == "1")
                    {
                        message.Restore(caretaker.GetPreviousMemento());
                        Console.WriteLine($"Restored to previous message: {message.MessageContents}");
                        caretaker.RemoveMemento(caretaker.GetMemento(caretaker.GetAllMementos().Count - 1));
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("End Mediator Example");
        }
    }
}
