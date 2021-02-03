namespace DesignPatterns.Structural.Adapter
{
    //abstract base class for bread
    public abstract class Bread
    {
        public IBreadRecipe BreadRecipe { get; set; }

        public abstract string BreadDescription();
    }
}
