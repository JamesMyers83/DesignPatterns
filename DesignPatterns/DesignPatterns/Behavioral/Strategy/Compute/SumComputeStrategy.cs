namespace DesignPatterns.Behavioral.Strategy
{
    //concrete strategy
    public class SumComputeStrategy : IComputeMetricStrategy
    {
        public double ComputeMetric(double[] numericArray)
        {   
            double sum = 0;

            foreach (double n in numericArray)
                sum += n;

            return sum;
        }
    }
}
