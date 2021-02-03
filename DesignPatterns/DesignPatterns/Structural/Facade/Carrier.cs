namespace DesignPatterns.Structural.Facade
{
    public class Carrier
    {
        public string ShipPackage(string product, string destination) => $"{product} has been delivered to {destination}";
    }
}
