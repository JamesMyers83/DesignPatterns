using System;

namespace DesignPatterns.Clients
{
    public class InterpreterClient
    {
        public void PrintInterpreter()
        {
            Behavioral.Interpreter.IExpression expression = null;

            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Interpreter Exampler");
                Console.WriteLine();
                Console.WriteLine("Type integer to convert");

                bool isNumber = false;
                string input = "";
                int userNumber = 0;

                while (!isNumber)
                {
                    input = Console.ReadLine();
                    isNumber = int.TryParse(input, out userNumber);

                    if (!isNumber)
                        Console.WriteLine("Must enter an integer");
                }

                Behavioral.Interpreter.Context numberContext = new Behavioral.Interpreter.Context(userNumber);

                Console.WriteLine("Key selection");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - To Binary");
                Console.WriteLine("2 - To Hexadecimal");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        expression = new Behavioral.Interpreter.BinaryExpression();
                        break;
                    case "2":
                        expression = new Behavioral.Interpreter.HexadecimalExpression();
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 0-5");
                        break;
                }

                if (expression != null)
                {
                    expression.Interpret(numberContext);
                    Console.WriteLine($"Conversion: {numberContext.ExpressionString}");
                }

                expression = null;
                Console.WriteLine();
                Console.WriteLine("End Interpreter Example");
                Console.WriteLine();
            }
        }
    }
}
