namespace DesignPatterns.Structural.Decorator
{
    //abstract decorator
    public class BeverageDecorator : IHotBeverage
    {
        protected IHotBeverage beverage;

        public BeverageDecorator(IHotBeverage hotBeverage)
        {
            beverage = hotBeverage;
        }

        public int BeverageFluidOunces { get => beverage.BeverageFluidOunces; set => beverage.BeverageFluidOunces = value; }
        public string BeverageDescription { get => beverage.BeverageDescription; set => beverage.BeverageDescription = value; }

        public virtual IHotBeverage MakeBeverage()
        {
            return beverage.MakeBeverage();
        }
    }
}
