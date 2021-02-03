namespace DesignPatterns.Behavioral.Strategy
{
    public class ComputeMetricContext
    {
        private IComputeMetricStrategy strategy;

        public void SetComputeStrategy(IComputeMetricStrategy metricStrategy) => strategy = metricStrategy;

        public double ComputeMetric(double[] numericArray) => strategy.ComputeMetric(numericArray);
    }
}
