namespace DesignPatterns.Behavioral.Template
{
    public class ChocolateChipCookies : CookieMaker
    {
        protected override string GatherIngredients()
        {
            return "Obtaining butter, white sugar, brown sugar, vanilla extract, eggs, flour, and chocolate chips";
        }

        protected override string PlaceOnBakingSheet()
        {
            return "Roll two to three rounded teaspoonfuls of dough into balls and place onto prepared cookie sheet then press flat slightly";
        }

        protected override void SetOvenTemp()
        {
            ovenTemp = 350;
        }
    }
}
