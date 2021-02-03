namespace DesignPatterns.Structural.Facade
{
    public class Packer
    {
        public string PreparePackage(string product, string destination) => $"{product} was boxed and shipment label created for delivery to {destination}";
    }
}
