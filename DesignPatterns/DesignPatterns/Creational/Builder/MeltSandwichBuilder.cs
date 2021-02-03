namespace DesignPatterns.Creational.Builder
{
    //concrete builder
    public class MeltSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.Condiments = @"thousand island dressing";
        }

        public override void AddMeat()
        {
            sandwich.Meat = "corned beef";
        }

        public override void AddVeggies()
        {
            sandwich.Veggies = @"carmelized onions, saurkraut";
        }

        public override void PrepareSandwich()
        {
            sandwich.Preparation = "served with a pickle, on grilled rye, cut on the bias";
        }

        public override void SetSandwichType()
        {
            sandwich.SandwichStyle = SandwichType.Melt;
        }
    }
}
