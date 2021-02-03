namespace DesignPatterns.Structural.Decorator
{
    //concrete component
    public class Coffee : IHotBeverage
    {
        public int BeverageFluidOunces { get; set; }
        public string BeverageDescription { get; set; }

        public IHotBeverage MakeBeverage()
        {
            BeverageFluidOunces = 6;
            BeverageDescription = "Fair trade Colombian roast";
            return this;
        }
    }
}
