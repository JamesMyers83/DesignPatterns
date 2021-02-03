namespace DesignPatterns.Behavioral.Visitor
{
    //abstract or base element
    public interface IElement
    {
        string AcceptVisitor(IVisitor visitor);
    }
}
