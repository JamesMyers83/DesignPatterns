namespace DesignPatterns.Structural.Adapter
{
    //interface for baker
    public interface IBaker
    {
        Bread Bake(IBreadRecipe breadRecipe);
    }
}
