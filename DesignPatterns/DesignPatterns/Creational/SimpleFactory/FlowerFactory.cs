namespace DesignPatterns.Creational.SimpleFactory
{
    // creator
    public class FlowerFactory
    {
        public IFlower GetFlower(string flowerType)
        {
            IFlower flower = null;

            if (flowerType == "Rose Bush")
                flower = new RoseBush();
            else if (flowerType == "Tulip")
                flower = new Tulip();
            else if (flowerType == "Orchid")
                flower = new Orchid();

            return flower;
        }
    }
}
