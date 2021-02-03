namespace DesignPatterns.Structural.Adapter
{
    //target interface
    interface IRecipeTarget
    {
        Bread BakeBread(AmericanBreadRecipe recipe);
    }
}
