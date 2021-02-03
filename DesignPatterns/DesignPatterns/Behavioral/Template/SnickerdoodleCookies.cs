namespace DesignPatterns.Behavioral.Template
{
    public class SnickerdoodleCookies : CookieMaker
    {
        protected override string GatherIngredients()
        {
            return "Obtaining butter, white sugar, eggs, vanilla, flour, and cinnamon";
        }

        protected override string PlaceOnBakingSheet()
        {
            return "Roll rounded teaspoonfuls of dough into balls, press finger into center, and place on a parchment paper-lined baking sheet";
        }

        protected override void SetOvenTemp()
        {
            ovenTemp = 350;
        }
    }
}
