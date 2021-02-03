namespace DesignPatterns.Structural.Adapter
{
    //the adaptee in the pattern
    //baker who makes french bread
    public class FrenchBaker : IBaker
    {
        public Bread Bake(IBreadRecipe breadRecipe)
        {
            return new FrenchBread
            {
                BreadRecipe = breadRecipe
            };
        }
    }
}
