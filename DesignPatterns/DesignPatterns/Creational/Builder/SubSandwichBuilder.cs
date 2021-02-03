namespace DesignPatterns.Creational.Builder
{
    //concrete builder
    public class SubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.Condiments = "oil and vinegar";
        }

        public override void AddMeat()
        {
            sandwich.Meat = "ham, salami, pastrami";
        }

        public override void AddVeggies()
        {
            sandwich.Veggies = "lettuce, tomato, red onionis, pickles";
        }

        public override void PrepareSandwich()
        {
            sandwich.Preparation = "on toasted french bread cut in half";
        }

        public override void SetSandwichType()
        {
            sandwich.SandwichStyle = SandwichType.Sub;
        }
    }
}
