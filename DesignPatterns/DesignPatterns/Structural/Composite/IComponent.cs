namespace DesignPatterns.Structural.Composite
{
    //interface of all components
    //a discussion by GoF on whether safety or transparency is more important in the component representation
    //their example uses the transparent option, and specifies that the client should manipulate objects through the component interface
    //for safety, no operations on child objects would be here, and composited classes would declare and implement those
    //for transparency, the operations on child objects would be declared here and implemented only in composite classes
    //      an abstract class with default behavior (typically thrown exceptions) for leaf class child operations would be implemented
    
    //their example uses the transparent option, and specifies that the client should manipulate objects through the component interface
    //this uses the safe approach, and therefore composites have an extended interface
    public interface IComponent
    {
        string Name { get; set; }
        string PlaceOfOrigin { get; set; }
        double Salary { get; set; }
        string ToString();
    }
}
