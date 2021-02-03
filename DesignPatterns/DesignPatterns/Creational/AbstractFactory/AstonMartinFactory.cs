using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class AstonMartinFactory : CarFactory
    {
        private string[] models = new string[] { "DB11", "Vantage" };

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
                    return new AstonMartin.DB11();
                case 1:
                    return new AstonMartin.Vantage();
                default:
                    return null;
            }
        }
    }
}
