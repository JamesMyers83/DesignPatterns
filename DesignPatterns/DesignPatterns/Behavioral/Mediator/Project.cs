namespace DesignPatterns.Behavioral.Mediator
{
    //class to pass between coleagues
    public class Project
    {
        public Project(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }
        public string Description { get; }
    }
}
