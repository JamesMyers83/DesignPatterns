namespace DesignPatterns.Behavioral.Strategy
{
    public class SortContext
    {
        private ISortStrategy strategy;

        public void SetSortStrategy(ISortStrategy sortStrategy) => strategy = sortStrategy;

        public void SortAscending(ref double[] numericArray) => strategy.SortAscending(ref numericArray);
    }
}
