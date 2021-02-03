namespace DesignPatterns.Structural.Adapter
{
    //object adapter which uses object instantiation
    public class RecipeObjectAdapter : IRecipeTarget
    {
        FrenchBaker baker = new FrenchBaker();

        public Bread BakeBread(AmericanBreadRecipe recipe)
        {
            FrenchBreadRecipe frenchRecipe = new FrenchBreadRecipe
            {
                AmountOfFlour = recipe.AmountOfFlour * 120, //convert cups to grams
                AmountOfWater = recipe.AmountOfWater * 237, //convert cups to mL
                BakeTemperature = (recipe.BakeTemperature / 9 * 5) + 32 //convert F to C
            };

            return baker.Bake(frenchRecipe);
        }
    }
}
