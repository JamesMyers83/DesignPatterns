namespace DesignPatterns.Structural.Adapter
{
    //recipe in imperial units (cups and fahrenheit)
    public class AmericanBreadRecipe : IBreadRecipe
    {
        public AmericanBreadRecipe()
        {
            ///set default recipe
            AmountOfFlour = 3; //cups
            AmountOfWater = 2; //cups
            BakeTemperature = 375; //Fº
        }

        public int AmountOfFlour { get; set; }
        public int AmountOfWater { get; set; }
        public int BakeTemperature { get; set; }

        public override string ToString()
        {
            return $"{AmountOfFlour} cups flour, {AmountOfWater} cups water baked at {BakeTemperature}Fº";
        }
    }
}
