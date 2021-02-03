using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class HondaFactory : CarFactory
    {
        private string[] models = new string[] { "Accord", "Civic" };

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
                    return new Honda.Accord();
                case 1:
                    return new Honda.Civic();
                default:
                    return null;
            }
        }
    }
}
