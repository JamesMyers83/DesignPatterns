namespace DesignPatterns.Structural.Adapter
{
    //bread assuming it was made with metric units 
    public class FrenchBread : Bread
    {
        public override string BreadDescription()
        {
            return $"Bread made with {BreadRecipe.AmountOfFlour}g of flour, {BreadRecipe.AmountOfWater}mL of water and baked at {BreadRecipe.BakeTemperature}Cº";
        }
    }
}
