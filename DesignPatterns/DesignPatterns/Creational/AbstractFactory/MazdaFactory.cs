using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class MazdaFactory : CarFactory
    {
        private string[] models = new string[] { "Mazda3", "Mazda5", "Mazda6", "MX5" };

        //concrete product 1
        public override string[] GetModelList()
        {
            return models;
        }

        //concrete product 2
        public override ICarModel CreateCar(string modelName)
        {
            switch (Array.IndexOf(models, modelName))
            {
                case 0:
                    return new Mazda.Mazda3();
                case 1:
                    return new Mazda.Mazda5();
                case 2:
                    return new Mazda.Mazda6();
                case 3:
                    return new Mazda.MX5();
                default:
                    return null;
            }
        }
    }
}
