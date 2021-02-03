using System;

namespace DesignPatterns.Creational.Builder
{
    //product
    public class Sandwich
    {
        public SandwichType SandwichStyle { get; set; }
        public string Meat { get; set; }
        public string Veggies { get; set; }
        public string Condiments { get; set; }
        public string Preparation { get; set; }
        private string SandwichStyleToString => Enum.GetName(typeof(SandwichType), SandwichStyle);

        public string GetSandwichDescription()
        {
            return $"{SandwichStyleToString} sandwich {Preparation}, comes with {Meat} and {Veggies} and {Condiments}";
        }
    }
}
