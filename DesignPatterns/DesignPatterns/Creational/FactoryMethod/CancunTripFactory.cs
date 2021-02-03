namespace DesignPatterns.Creational.FactoryMethod
{
    //concrete creator
    public class CancunTripFactory : BeachTripFactory
    {
        protected override IBeachTrip GetBeachTrip()
        {
            return new Cancun();
        }
    }
}
