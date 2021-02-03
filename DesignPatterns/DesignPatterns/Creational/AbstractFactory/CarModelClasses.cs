/// <summary>
/// This file contains all models of cars placing each model in its car make namespace
/// </summary>
namespace DesignPatterns.Creational.AbstractFactory.AstonMartin
{
    public class Vantage : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 200000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.AstonMartin
{
    public class DB11 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Convertible;
        public int Price => 125000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Audi
{
    public class A3 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Wagon;
        public int Price => 27000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Audi
{
    public class A4 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 32000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Audi
{
    public class A5 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 38000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Audi
{
    public class A6 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 44000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Audi
{
    public class A7 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 51000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Audi
{
    public class A8 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 63000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Audi
{
    public class TT : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Convertible;
        public int Price => 46000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Audi
{
    public class R8 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 110000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Ferrari
{
    public class Ferrari812 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 145000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Ferrari
{
    public class SF90 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 125000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Ferrari
{
    public class F8 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 225000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Ferrari
{
    public class Ferrari488 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 185000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Ford
{
    public class Focus : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 18000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Ford
{
    public class Mustang : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 24000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Honda
{
    public class Accord : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 26000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Honda
{
    public class Civic : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 19000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Hyundai
{
    public class Accent : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 17000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Hyundai
{
    public class Elantra : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 21000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Hyundai
{
    public class Sonata : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 23000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Hyundai
{
    public class Veloster : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 22000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Mazda
{
    public class Mazda3 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Wagon;
        public int Price => 18000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Mazda
{
    public class Mazda5 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 21000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Mazda
{
    public class Mazda6 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 26000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Mazda
{
    public class MX5 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Convertible;
        public int Price => 27000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Nissan
{
    public class Z370 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Convertible;
        public int Price => 32000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Nissan
{
    public class GTR : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 44000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Nissan
{
    public class Altima : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 26000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Nissan
{
    public class Maxima : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 34000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Nissan
{
    public class Sentra : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 19000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Nissan
{
    public class Versa : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Wagon;
        public int Price => 17000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Porsche
{
    public class Boxster : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Convertible;
        public int Price => 56000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Porsche
{
    public class Carrera911 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 98000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Porsche
{
    public class Cayman : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 72000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Porsche
{
    public class Panamera : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 115000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Toyota
{
    public class Avalon : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 42000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Toyota
{
    public class Camry : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 36000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Toyota
{
    public class Corolla : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 21000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Toyota
{
    public class Supra : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 55000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Toyota
{
    public class GT86 : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 30000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Toyota
{
    public class Yaris : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Wagon;
        public int Price => 18000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Volkswagen
{
    public class Golf : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Wagon;
        public int Price => 19000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Volkswagen
{
    public class Jetta : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Coupe;
        public int Price => 25000;
    }
}


namespace DesignPatterns.Creational.AbstractFactory.Volkswagen
{
    public class Passat : ICarModel
    {
        public string ModelName => this.GetType().Name;
        public CarType CarType => CarType.Sedan;
        public int Price => 30000;
    }
}
