namespace DesignPatterns.Structural.Facade
{
    public class Order
    {
        public string ProcessPayment(double amount, string product) => $"Payment of ${amount} was processed for {product}"; 
    }
}
