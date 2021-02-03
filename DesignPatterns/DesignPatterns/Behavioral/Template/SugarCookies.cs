namespace DesignPatterns.Behavioral.Template
{
    public class SugarCookies : CookieMaker
    {
        protected override string GatherIngredients()
        {
            return "Obtaining flour, butter, white sugar, egg and vanilla";
        }

        protected override string PlaceOnBakingSheet()
        {
            return "Roll rounded teaspoonfuls of dough into balls, and place onto ungreased cookie sheets";
        }

        protected override void SetOvenTemp()
        {
            ovenTemp = 375;
        }
    }
}
