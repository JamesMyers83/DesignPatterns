namespace DesignPatterns.Behavioral.Visitor
{
    //concrete element
    public class TouristAttraction : IElement
    {
        public string Name { get; set; }

        public City InCity { get; set; }

        public string AcceptVisitor(IVisitor visitor) => visitor.VisitAttraction(this);
    }
}
