namespace DesignPatterns.Behavioral.Template
{
    public class PeanutButterCookies : CookieMaker
    {
        protected override string GatherIngredients()
        {
            return "Obtaining butter, peanut butter, white sugar, brown sugar, eggs, and flour";
        }

        protected override string PlaceOnBakingSheet()
        {
            return "Scoop spoonful on baking sheet and press with wet fork for design";
        }

        protected override void SetOvenTemp()
        {
            ovenTemp = 375;
        }
    }
}
