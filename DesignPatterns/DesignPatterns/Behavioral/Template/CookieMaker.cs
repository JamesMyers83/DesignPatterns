using System.Text;

namespace DesignPatterns.Behavioral.Template
{
    //abstract template class
    public abstract class CookieMaker
    {
        protected int ovenTemp;
        private string cookie;

        protected CookieMaker()
        {
            cookie = this.GetType().Name;
            SetOvenTemp();
        }

        //primitive operations
        protected abstract void SetOvenTemp();
        protected abstract string GatherIngredients();
        internal string PreheatOven() => $"Preheating oven to {ovenTemp}";
        internal string MixIngredients() => $"Mixing all ingredients for {cookie}";
        protected abstract string PlaceOnBakingSheet();
        internal string Bake() => $"Baking {cookie} in oven at {ovenTemp}";
        internal string RemoveFromOven() => $"Removing {cookie} from oven";
        internal string CoolOnRack() => $"Cooling {cookie} on rack.";

        //TemplateMethod()
        public string MakeCookies()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GatherIngredients());
            sb.Append("\r\n");
            sb.Append(PreheatOven());
            sb.Append("\r\n");
            sb.Append(MixIngredients());
            sb.Append("\r\n");
            sb.Append(PlaceOnBakingSheet());
            sb.Append("\r\n");
            sb.Append(Bake());
            sb.Append("\r\n");
            sb.Append(RemoveFromOven());
            sb.Append("\r\n");
            sb.Append(CoolOnRack());
            sb.Append("\r\n");

            return sb.ToString();
        }
    }
}
