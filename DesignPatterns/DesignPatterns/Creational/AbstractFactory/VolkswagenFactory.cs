using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class VolkswagenFactory : CarFactory
    {
        private string[] models = new string[] { "Golf", "Jetta", "Passat" };

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
                    return new Volkswagen.Golf();
                case 1:
                    return new Volkswagen.Jetta();
                case 2:
                    return new Volkswagen.Passat();
                default:
                    return null;
            }
        }
    }
}
