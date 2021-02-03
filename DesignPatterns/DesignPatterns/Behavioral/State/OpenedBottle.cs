namespace DesignPatterns.Behavioral.State
{
    //concrete state
    public class OpenedBottle : BottleState
    {
        public override string CloseBottle()
        {
            return "Bottle has be recorked";
        }

        public override string OpenBottle()
        {
            return "Bottle has already been opened";
        }

        public override string PourWine(int ounces)
        {
            return $"{ounces} oz of wine have been poured";
        }
    }
}
