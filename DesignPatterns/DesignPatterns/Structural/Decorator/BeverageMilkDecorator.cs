namespace DesignPatterns.Structural.Decorator
{
    public class BeverageMilkDecorator : BeverageDecorator
    {
        public BeverageMilkDecorator(IHotBeverage hotBeverage) : base(hotBeverage)
        {
        }

        public override IHotBeverage MakeBeverage()
        {
            beverage.MakeBeverage();
            AddMilk();
            return beverage;
        }

        private void AddMilk() => beverage.BeverageDescription += " with milk added";
    }
}
