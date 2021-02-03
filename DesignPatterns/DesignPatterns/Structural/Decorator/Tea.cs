namespace DesignPatterns.Structural.Decorator
{
    //concrete component
    public class Tea : IHotBeverage
    {
        public int BeverageFluidOunces { get; set; }
        public string BeverageDescription { get; set; }

        public IHotBeverage MakeBeverage()
        {
            BeverageFluidOunces = 8;
            BeverageDescription = "Green tea with mint flavor";
            return this;
        }
    }
}
