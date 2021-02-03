using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Strategy
{
    //concrete strategy
    public class MedianComputeStrategy : IComputeMetricStrategy
    {
        public double ComputeMetric(double[] numericArray)
        {
            List<double> sorted = numericArray.ToList();
            sorted.Sort();

            int med = numericArray.Length / 2;

            return sorted[med];
        }
    }
}
