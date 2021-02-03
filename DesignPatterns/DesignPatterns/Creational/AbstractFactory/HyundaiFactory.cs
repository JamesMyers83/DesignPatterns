using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class HyundaiFactory : CarFactory
    {
        private string[] models = new string[] { "Accent", "Elantra", "Sonata", "Veloster" };

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
                    return new Hyundai.Accent();
                case 1:
                    return new Hyundai.Elantra();
                case 2:
                    return new Hyundai.Sonata();
                case 3:
                    return new Hyundai.Veloster();
                default:
                    return null;
            }
        }
    }
}
