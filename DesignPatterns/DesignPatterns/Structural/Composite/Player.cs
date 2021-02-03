namespace DesignPatterns.Structural.Composite
{
    //leaf class, has no children
    public class Player : IComponent
    {
        public string Name { get; set; }

        public string PlaceOfOrigin { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Player: {Name} from {PlaceOfOrigin} - Salary: {Salary.ToString("C0")}";
        }
    }
}
