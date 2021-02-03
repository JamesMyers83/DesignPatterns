namespace DesignPatterns.Behavioral.Command
{
    //concrete command
    public class DessertOrder : BaseCommand, IOrderCommand
    {
        public DessertOrder(Cook cook) : base(cook)
        {
        }

        public string Execute() => _cook.PrepareDessert();
    }
}
