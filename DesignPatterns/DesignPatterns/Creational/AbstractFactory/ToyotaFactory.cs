using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class ToyotaFactory : CarFactory
    {
        private string[] models = new string[] { "Avalon", "Camry", "Corolla", "GT86", "Supra", "Yaris" };

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
                    return new Toyota.Avalon();
                case 1:
                    return new Toyota.Camry();
                case 2:
                    return new Toyota.Corolla();
                case 3:
                    return new Toyota.GT86();
                case 4:
                    return new Toyota.Supra();
                case 5:
                    return new Toyota.Yaris();
                default:
                    return null;
            }
        }
    }
}
