namespace DesignPatterns.Creational.FactoryMethod
{
    //concrete creator
    public class JamaicaTripFactory : BeachTripFactory
    {
        protected override IBeachTrip GetBeachTrip()
        {
            return new Jamaica();
        }
    }
}
