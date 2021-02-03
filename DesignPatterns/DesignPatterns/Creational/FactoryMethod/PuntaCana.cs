namespace DesignPatterns.Creational.FactoryMethod
{
    //concrete product
    public class PuntaCana : IBeachTrip
    {
        public string BeachLocation => this.GetType().Name;

        public int TripPrice => 3799;

        public int DaysInTrip => 6;
    }
}
