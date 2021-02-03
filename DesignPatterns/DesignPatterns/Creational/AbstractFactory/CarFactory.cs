namespace DesignPatterns.Creational.AbstractFactory
{
    //abstract factory
    public abstract class CarFactory
    {
        //creates abstract product 1
        public abstract string[] GetModelList();

        //creates abstract product 2
        public abstract ICarModel CreateCar(string modelName);
    }
}
