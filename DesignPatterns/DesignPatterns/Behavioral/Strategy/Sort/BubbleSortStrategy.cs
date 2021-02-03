namespace DesignPatterns.Behavioral.Strategy
{
    //concrete strategy
    public class BubbleSortStrategy : ISortStrategy
    {
        //O(n^2)
        public void SortAscending(ref double[] numericArray)
        {
            bool hasMoved = true;

            while (hasMoved)
            {
                hasMoved = false;

                for (int n = 0; n < numericArray.Length - 1; n++)
                {
                    if (numericArray[n] > numericArray[n + 1])
                    {
                        double lower = numericArray[n + 1];
                        numericArray[n + 1] = numericArray[n];
                        numericArray[n] = lower;
                        hasMoved = true;
                    }
                }
            }
        }
    }
}
