namespace DesignPatterns.Behavioral.Strategy
{
    //concrete strategy
    public class AverageComputeStrategy : IComputeMetricStrategy
    {
        public double ComputeMetric(double[] numericArray)
        {
            double count = numericArray.Length;
            double sum = 0;

            foreach (double n in numericArray)
                sum += n;

            return sum / count;
        }
    }
}
