using System;
using System.Linq;

namespace DesignPatterns.Clients
{
    public class StrategyClient
    {
        public void PrintStrategy()
        {
            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine("Strategy Example.");
                Console.WriteLine();
                Console.WriteLine("Type number of strategy to test");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Aggregates");
                Console.WriteLine("2 - Sorting");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        PrintComputeStrategy();
                        break;
                    case "2":
                        PrintSortStrategy();
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 0-2");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("End Strategy Example");
        }

        private void PrintComputeStrategy()
        {
            Behavioral.Strategy.ComputeMetricContext context = new Behavioral.Strategy.ComputeMetricContext();
            Behavioral.Strategy.IComputeMetricStrategy strategy = null;

            bool exitLoop = false;

            Console.WriteLine("Strategy (Aggregate) Example.");
            Console.WriteLine("Generating 9 random numbers...");

            Random random = new Random();
            double[] randomArray = new double[9];

            for (int r = 0; r < randomArray.Length; r++)
            {
                double d = random.NextDouble();
                d = Math.Round(d * 10.00, 1);
                Console.WriteLine($"#{r + 1}: {d}");
                randomArray[r] = d;
            }

            Console.WriteLine();

            while (!exitLoop)
            {
                Console.WriteLine();
                Console.WriteLine("Key selection");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Average");
                Console.WriteLine("2 - Max");
                Console.WriteLine("3 - Min");
                Console.WriteLine("4 - Median");
                Console.WriteLine("5 - Sum");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        strategy = new Behavioral.Strategy.AverageComputeStrategy();
                        break;
                    case "2":
                        strategy = new Behavioral.Strategy.MaxComputeStrategy();
                        break;
                    case "3":
                        strategy = new Behavioral.Strategy.MinComputeStrategy();
                        break;
                    case "4":
                        strategy = new Behavioral.Strategy.MedianComputeStrategy();
                        break;
                    case "5":
                        strategy = new Behavioral.Strategy.SumComputeStrategy();
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 0-5");
                        break;
                }

                if (strategy != null)
                {
                    context.SetComputeStrategy(strategy);
                    Console.WriteLine(context.ComputeMetric(randomArray));
                }

                strategy = null;
                Console.WriteLine();
            }
        }

        private void PrintSortStrategy()
        {
            Behavioral.Strategy.ISortStrategy strategy = null;
            bool exitLoop = false;

            while (!exitLoop)
            {
                int numberOfItems = 50000;

                Console.WriteLine("Strategy (Sort) Example ");
                Console.WriteLine($"Generating {numberOfItems} random numbers...");

                Random random = new Random();
                double[] randomArray = new double[numberOfItems];

                for (int r = 0; r < numberOfItems; r++)
                {
                    double d = random.NextDouble();
                    d = Math.Round(d * numberOfItems / 10.00, 1);
                    //Console.WriteLine($"#{r + 1}: {d}");
                    randomArray[r] = d;
                }

                Console.WriteLine($"first number in array: {randomArray[0]}, last number in array: {randomArray[numberOfItems - 1]}");
                Console.WriteLine($"lowest number in array: {randomArray.ToList().Min()}, highest number in array: {randomArray.ToList().Max()}");

                Console.WriteLine();
                Console.WriteLine("Key selection");
                Console.WriteLine("0 - exit");
                Console.WriteLine("1 - Bubble");
                Console.WriteLine("2 - Insertion");
                Console.WriteLine("3 - Merge");
                Console.WriteLine("4 - Quick");
                Console.WriteLine("5 - Selection");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        strategy = new Behavioral.Strategy.BubbleSortStrategy();
                        break;
                    case "2":
                        strategy = new Behavioral.Strategy.InsertionSortStrategy();
                        break;
                    case "3":
                        strategy = new Behavioral.Strategy.MergeSortStrategy();
                        break;
                    case "4":
                        strategy = new Behavioral.Strategy.QuickSortStrategy();
                        break;
                    case "5":
                        strategy = new Behavioral.Strategy.SelectionSortStrategy();
                        break;
                    default:
                        Console.WriteLine("Selection must be the numbers 0-5");
                        break;
                }

                if (strategy != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorting...");

                    DateTime start = DateTime.Now;

                    strategy.SortAscending(ref randomArray);

                    TimeSpan timeSpan = DateTime.Now - start;

                    Console.WriteLine($"Elapsed milliseconds: {timeSpan.TotalMilliseconds}");

                    Console.WriteLine($"Now first number in array is: {randomArray[0]} and last number in array is: {randomArray[numberOfItems - 1]}");
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.WriteLine();
                strategy = null;
            }
        }
    }
}
