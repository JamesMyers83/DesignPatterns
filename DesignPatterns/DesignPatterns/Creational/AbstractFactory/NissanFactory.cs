using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class NissanFactory : CarFactory
    {
        private string[] models = new string[] { "Altima", "GTR", "Maxima", "Sentra", "Versa", "370Z" };

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
                    return new Nissan.Altima();
                case 1:
                    return new Nissan.GTR();
                case 2:
                    return new Nissan.Maxima();
                case 3:
                    return new Nissan.Sentra();
                case 4:
                    return new Nissan.Versa();
                case 5:
                    return new Nissan.Z370();
                default:
                    return null;
            }
        }
    }
}
