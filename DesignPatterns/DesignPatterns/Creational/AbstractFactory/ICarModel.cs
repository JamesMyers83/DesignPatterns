namespace DesignPatterns.Creational.AbstractFactory
{
    //abstract product
    public interface ICarModel
    {
        string ModelName { get; }
        CarType CarType { get; }
        int Price { get; }
    }
}
