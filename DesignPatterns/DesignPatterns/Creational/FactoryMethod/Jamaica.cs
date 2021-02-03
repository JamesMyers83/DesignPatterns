namespace DesignPatterns.Creational.FactoryMethod
{
    //concrete product
    public class Jamaica : IBeachTrip
    {
        public string BeachLocation => this.GetType().Name;

        public int TripPrice => 2999;

        public int DaysInTrip => 4;
    }
}
