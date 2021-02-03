namespace DesignPatterns.Behavioral.Command
{
    //concrete command
    public class BurgerOrder : BaseCommand, IOrderCommand
    {
        public BurgerOrder(Cook cook) : base(cook)
        {
        }

        public string Execute() => _cook.PrepareBurger();
    }
}
