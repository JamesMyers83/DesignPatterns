namespace DesignPatterns.Behavioral.Strategy
{
    //concrete strategy
    public class MinComputeStrategy : IComputeMetricStrategy
    {
        public double ComputeMetric(double[] numericArray)
        {   
            double min = numericArray[0];

            foreach (double n in numericArray)
                if (n < min)
                    min = n;

            return min;
        }
    }
}
