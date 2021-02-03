using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class FerrariFactory : CarFactory
    {
        private string[] models = new string[] { "F8", "488", "812", "SF90" };

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
                    return new Ferrari.F8();
                case 1:
                    return new Ferrari.Ferrari488();
                case 2:
                    return new Ferrari.Ferrari812();
                case 3:
                    return new Ferrari.SF90();
                default:
                    return null;
            }
        }
    }
}
