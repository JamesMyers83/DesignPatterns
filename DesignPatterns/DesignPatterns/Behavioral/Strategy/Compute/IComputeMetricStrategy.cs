namespace DesignPatterns.Behavioral.Strategy
{
    //strategy interface
    public interface IComputeMetricStrategy
    {
        double ComputeMetric(double[] numericArray);
    }
}
