using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class FordFactory : CarFactory
    {
        private string[] models = new string[] { "Focus", "Mustang" };

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
                    return new Ford.Focus();
                case 1:
                    return new Ford.Mustang();
                default:
                    return null;
            }
        }
    }
}
