namespace DesignPatterns.Creational.FactoryMethod
{
    //represents interface of products
    public interface IBeachTrip
    {
        string BeachLocation { get; }
        int TripPrice { get; }
        int DaysInTrip { get; }
    }
}
