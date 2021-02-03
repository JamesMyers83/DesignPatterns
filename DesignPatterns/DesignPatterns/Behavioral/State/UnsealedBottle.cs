namespace DesignPatterns.Behavioral.State
{
    //concrete state
    public class UnsealedBottle : BottleState
    {
        public override string CloseBottle()
        {
            return "Bottle has not been opened yet.";
        }

        public override string OpenBottle()
        {
            return "Bottle has been uncorked";
        }

        public override string PourWine(int ounces)
        {
            return "Cannot pour wine, bottle is still closed";
        }
    }
}
