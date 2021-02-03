namespace DesignPatterns.Creational.SimpleFactory
{
    //concrete product
    public class RoseBush : IFlower
    {
        public string FlowerType()
        {
            return "Rose Bush";
        }

        public double Price()
        {
            return 39.99;
        }
    }
}
