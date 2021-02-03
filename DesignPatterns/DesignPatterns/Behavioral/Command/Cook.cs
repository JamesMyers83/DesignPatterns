namespace DesignPatterns.Behavioral.Command
{
    //receiver
    public class Cook : ICook
    {
        public string PrepareSalad() => "Spring mix salad in a bowl";

        public string PrepareBurger() => "Half pound beef burger on brioche bun";

        public string PrepareDessert() => "Slice of pie with scoop of ice cream";
    }
}
