namespace DesignPatterns.Behavioral.State
{
    //context
    public class WineBottleContext : BottleState
    {
        private BottleState bottleState = new SealedBottle();

        public override string RemoveSeal()
        {
            string output = bottleState.RemoveSeal();

            if (bottleState is SealedBottle)
                bottleState = new UnsealedBottle();

            return output;
        }

        public override string OpenBottle()
        {
            string output = bottleState.OpenBottle();

            if (bottleState is UnsealedBottle || bottleState is ClosedBottle)
                bottleState = new OpenedBottle();

            return output;
        }

        public override string PourWine(int ounces)
        {
            return bottleState.PourWine(ounces);
        }

        public override string CloseBottle()
        {
            string output = bottleState.CloseBottle();

            if (bottleState is OpenedBottle)
                bottleState = new ClosedBottle();

            return output;
        }
    }
}
