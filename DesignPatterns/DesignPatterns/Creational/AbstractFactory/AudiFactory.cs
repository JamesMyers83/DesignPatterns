using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //concrete factory
    public class AudiFactory : CarFactory
    {
        private string[] models = new string[] { "A3", "A4", "A5", "A6", "A7", "A8", "R8", "TT" };

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
                    return new Audi.A3();
                case 1:
                    return new Audi.A4();
                case 2:
                    return new Audi.A5();
                case 3:
                    return new Audi.A6();
                case 4:
                    return new Audi.A7();
                case 5:
                    return new Audi.A8();
                case 6:
                    return new Audi.R8();
                case 7:
                    return new Audi.TT();
                default:
                    return null;
            }
        }
    }
}
