namespace DesignPatterns.Creational.Builder
{
    //concrete builder
    public class DeliSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.Condiments = "mayo, mustard";
        }

        public override void AddMeat()
        {
            sandwich.Meat = "sliced turkey";
        }

        public override void AddVeggies()
        {
            sandwich.Veggies = "lettuce, tomato, onion, pickles";
        }

        public override void PrepareSandwich()
        {
            sandwich.Preparation = "served with chips, on sliced wheat bread cut in half";
        }

        public override void SetSandwichType()
        {
            sandwich.SandwichStyle = SandwichType.Deli;
        }
    }
}
