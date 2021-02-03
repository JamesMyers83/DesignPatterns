namespace DesignPatterns.Behavioral.Visitor
{
    //abstract or base visitor
    public interface IVisitor
    {
        string VisitCity(City city);
        string VisitAttraction(TouristAttraction attraction);
    }
}
