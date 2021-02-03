namespace DesignPatterns.Structural.Decorator
{
    public class BeverageSugarDecorator : BeverageDecorator
    {
        public BeverageSugarDecorator(IHotBeverage hotBeverage) : base(hotBeverage)
        {
        }

        public override IHotBeverage MakeBeverage()
        {
            beverage.MakeBeverage();
            AddSugar();
            return beverage;
        }

        private void AddSugar() => beverage.BeverageDescription += " with sugar added";
    }
}
