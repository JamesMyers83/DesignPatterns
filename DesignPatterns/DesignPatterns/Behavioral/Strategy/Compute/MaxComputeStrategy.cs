namespace DesignPatterns.Behavioral.Strategy
{
    //concrete strategy
    public class MaxComputeStrategy : IComputeMetricStrategy
    {
        public double ComputeMetric(double[] numericArray)
        {   
            double max = numericArray[0];

            foreach (double n in numericArray)
                if (n > max)
                    max = n;

            return max;
        }
    }
}
