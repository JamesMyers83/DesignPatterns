namespace DesignPatterns.Creational.Prototype
{
    //protoype interface declaring clone method to return concrete implementation
    public interface IClonable<T> where T : IClonable<T>
    {
        T Clone();
    }
}
