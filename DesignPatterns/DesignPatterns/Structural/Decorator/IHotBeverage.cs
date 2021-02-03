namespace DesignPatterns.Structural.Decorator
{
    //component interface
    public interface IHotBeverage
    {
        int BeverageFluidOunces { get; set; }
        string BeverageDescription { get; set; }
        IHotBeverage MakeBeverage();
    }
}
