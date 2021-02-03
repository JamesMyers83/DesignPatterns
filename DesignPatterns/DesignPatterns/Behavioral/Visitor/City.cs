namespace DesignPatterns.Behavioral.Visitor
{
    //concrete element
    public class City : IElement
    {
        public string Name { get; set; }

        public string AcceptVisitor(IVisitor visitor) => visitor.VisitCity(this);
    }
}
