namespace DesignPatterns.Creational.SimpleFactory
{
    //concrete product
    public class Tulip : IFlower
    {
        public string FlowerType()
        {
            return "Tulip";
        }

        public double Price()
        {
            return 9.99;
        }
    }
}
