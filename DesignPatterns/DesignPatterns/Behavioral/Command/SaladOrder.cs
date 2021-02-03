namespace DesignPatterns.Behavioral.Command
{
    //concrete command
    public class SaladOrder : BaseCommand, IOrderCommand
    {
        public SaladOrder(Cook cook) : base(cook)
        {
        }

        public string Execute() => _cook.PrepareSalad();
    }
}
