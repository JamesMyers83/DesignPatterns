namespace DesignPatterns.Behavioral.Strategy
{
    public class QuickSortStrategy : ISortStrategy
    {
        public void SortAscending(ref double[] numericArray)
        {
            QuickSort(numericArray, 0, numericArray.Length - 1);
        }

        private void QuickSort(double[] input, int a, int b)
        {
            if (a < b)
            {
                int c = Partition(input, a, b);

                QuickSort(input, a, c);
                QuickSort(input, c + 1, b);
            }
        }

        private int Partition(double[] input, int a, int b)
        {
            double c = input[a];
            int x = a;
            int y = b;

            while (true)
            {
                while (input[x] < c) x++;

                while (input[y] > c) y--;

                if (x >= y)
                    return y;
                
                double d = input[x];
                input[x] = input[y];
                input[y] = d;
                x++;
                y--;
            }
        }
    }
}
