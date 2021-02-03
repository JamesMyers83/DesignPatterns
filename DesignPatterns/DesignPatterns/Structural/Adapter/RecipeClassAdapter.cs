namespace DesignPatterns.Structural.Adapter
{
    //class adapter which uses inheritance instead of object instantiation
    public class RecipeClassAdapter : FrenchBaker, IRecipeTarget
    {
        public Bread BakeBread(AmericanBreadRecipe recipe)
        {
            FrenchBreadRecipe frenchRecipe = new FrenchBreadRecipe
            {
                AmountOfFlour = recipe.AmountOfFlour * 120, //convert cups to grams
                AmountOfWater = recipe.AmountOfWater * 237, //convert cups to mL
                BakeTemperature = (recipe.BakeTemperature / 9 * 5) + 32 //convert F to C
            };

            return Bake(frenchRecipe);
        }
    }
}
