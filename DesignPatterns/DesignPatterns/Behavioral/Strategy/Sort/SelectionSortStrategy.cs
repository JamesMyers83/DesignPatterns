namespace DesignPatterns.Behavioral.Strategy
{
    //concrete strategy
    public class SelectionSortStrategy : ISortStrategy
    {
        public void SortAscending(ref double[] numericArray)
        {
            for (int n = 0; n < numericArray.Length; n++)
            {
                int lowerIndex = n;

                for (int m = n + 1; m < numericArray.Length; m++)
                    if (numericArray[lowerIndex] > numericArray[m])
                        lowerIndex = m;

                if (lowerIndex != n)
                {
                    double lowerValue = numericArray[lowerIndex];
                    numericArray[lowerIndex] = numericArray[n];
                    numericArray[n] = lowerValue;
                }
            }
        }
    }
}
