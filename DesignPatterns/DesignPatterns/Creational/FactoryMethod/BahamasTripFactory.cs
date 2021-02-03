namespace DesignPatterns.Creational.FactoryMethod
{
    //concrete creator
    public class BahamasTripFactory : BeachTripFactory
    {
        protected override IBeachTrip GetBeachTrip()
        {
            return new Bahamas();
        }
    }
}
