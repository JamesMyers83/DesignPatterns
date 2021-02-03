namespace DesignPatterns.Creational.Builder
{
    //director class which constructs a new product with concrete builder,
    //calls methods in proper order and returns fully built product.
    public class SandwichDirector
    {
        public Sandwich ConstructSandwich(SandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.CreateNewSandwich();
            sandwichBuilder.SetSandwichType();
            sandwichBuilder.AddCondiments();
            sandwichBuilder.AddMeat();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.PrepareSandwich();

            return sandwichBuilder.GetSandwich();
        }
    }
}
