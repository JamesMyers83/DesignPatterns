namespace DesignPatterns.Creational.FactoryMethod
{
    //concrete creator
    public class PuntaCanaTripFactory : BeachTripFactory
    {
        protected override IBeachTrip GetBeachTrip()
        {
            return new PuntaCana();
        }
    }
}
