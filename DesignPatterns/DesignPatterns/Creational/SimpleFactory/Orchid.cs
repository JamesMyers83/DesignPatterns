namespace DesignPatterns.Creational.SimpleFactory
{
    //concrete product
    public class Orchid : IFlower
    {
        public string FlowerType()
        {
            return "Orchid";
        }

        public double Price()
        {
            return 19.99;
        }
    }
}
