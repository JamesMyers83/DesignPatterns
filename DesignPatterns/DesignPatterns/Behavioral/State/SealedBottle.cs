namespace DesignPatterns.Behavioral.State
{
    //concrete state
    public class SealedBottle : BottleState
    {
        public override string CloseBottle()
        {
            return "Bottle has not been opened yet.";
        }

        public override string OpenBottle()
        {
            return "Bottle must be unsealed first";
        }

        public override string PourWine(int ounces)
        {
            return "Cannot pour wine, bottle is still closed and sealed.";
        }

        public override string RemoveSeal()
        {
            return "Seal has been removed";
        }
    }
}
