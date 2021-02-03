namespace DesignPatterns.Creational.FactoryMethod
{
    //concrete product
    public class Cancun : IBeachTrip
    {
        public string BeachLocation => this.GetType().Name;

        public int TripPrice => 4599;

        public int DaysInTrip => 7;
    }
}
