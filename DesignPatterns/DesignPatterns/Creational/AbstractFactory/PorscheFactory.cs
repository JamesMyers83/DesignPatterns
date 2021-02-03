using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class PorshceFactory : CarFactory
    {
        private string[] models = new string[] { "Boxster", "911", "Cayman", "Panamera" };

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
                    return new Porsche.Boxster();
                case 1:
                    return new Porsche.Carrera911();
                case 2:
                    return new Porsche.Cayman();
                case 3:
                    return new Porsche.Panamera();
                default:
                    return null;
            }
        }
    }
}
