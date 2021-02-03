namespace DesignPatterns.Creational.FactoryMethod
{
    // abstract creator
    public abstract class BeachTripFactory
    {
        protected abstract IBeachTrip GetBeachTrip();

        public IBeachTrip CreateTrip()
        {
            return GetBeachTrip();
        }
    }
}
