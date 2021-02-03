namespace DesignPatterns.Behavioral.State
{
    //concrete state
    public class ClosedBottle : BottleState
    {
        public override string OpenBottle()
        {
            return "Bottle has been reopened";
        }

        public override string CloseBottle()
        {
            return "Bottle is already closed";
        }

        public override string PourWine(int ounces)
        {
            return "Cannot pour wine because bottle is closed";
        }
    }
}
