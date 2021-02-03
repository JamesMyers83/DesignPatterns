namespace DesignPatterns.Structural.Adapter
{
    //interface for a bread recipe, regardless of units used
    public interface IBreadRecipe
    {
        int AmountOfFlour { get; set; }
        int AmountOfWater { get; set; }
        int BakeTemperature { get; set; }

        string ToString();
    }
}
