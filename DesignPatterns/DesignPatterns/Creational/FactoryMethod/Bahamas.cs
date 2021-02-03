namespace DesignPatterns.Creational.FactoryMethod
{
    //concrete product
    public class Bahamas : IBeachTrip
    {
        public string BeachLocation => this.GetType().Name;

        public int TripPrice => 2499;

        public int DaysInTrip => 5;
    }
}
