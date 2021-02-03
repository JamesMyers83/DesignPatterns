namespace DesignPatterns.Behavioral.State
{
    public abstract class BottleState
    {
        public virtual string RemoveSeal() => "Seal has already been removed";
        public abstract string CloseBottle();
        public abstract string OpenBottle();
        public abstract string PourWine(int ounces);

        public string ReadLabel()
        {
            return "Tasting the wine reveals juicy, sweet, berry fruit wrapped up in a smooth texture. It turns a bit oaky and leathery mid-palate and then some nice underlying earthy notes lead into the finish. It ends dry with cola, earth and sweet berry fruit lasting for quite awhile.";
        }
    }
}
