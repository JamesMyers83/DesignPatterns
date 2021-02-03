namespace DesignPatterns.Structural.Adapter
{
    //recipe in metric units 
    public class FrenchBreadRecipe : IBreadRecipe
    {
        public FrenchBreadRecipe()
        {
            ///set default recipe
            AmountOfFlour = 450; //grams
            AmountOfWater = 285; //mL
            BakeTemperature = 230; //Cº
        }

        public int AmountOfFlour { get; set; }
        public int AmountOfWater { get; set; }
        public int BakeTemperature { get; set; }

        public override string ToString()
        {
            return $"{AmountOfFlour} grams flour, {AmountOfWater} mL water baked at {BakeTemperature}Cº";
        }
    }
}
