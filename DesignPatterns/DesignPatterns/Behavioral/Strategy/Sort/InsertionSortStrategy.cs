namespace DesignPatterns.Behavioral.Strategy
{
    //concrete strategy
    public class InsertionSortStrategy : ISortStrategy
    {
        public void SortAscending(ref double[] numericArray)
        {
            for (int n = 0; n < numericArray.Length; n++)
            {
                double currentItem = numericArray[n];
                int currentIndex = n;

                while (currentIndex > 0 && numericArray[currentIndex - 1] > currentItem)
                {
                    numericArray[currentIndex] = numericArray[currentIndex - 1];
                    currentIndex--;
                }

                numericArray[currentIndex] = currentItem;
            }    
        }
    }
}
