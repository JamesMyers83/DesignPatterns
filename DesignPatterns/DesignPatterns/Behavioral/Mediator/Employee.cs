namespace DesignPatterns.Behavioral.Mediator
{
    //abstract coleague
    public abstract class Employee
    {
        protected Employee(string name, string title, IMediator mediator)
        {
            Name = name;
            Title = title;
            Mediator = mediator;
        }

        public string Name { get; }
        public string Title { get; }
        public IMediator Mediator { get;  }

        public abstract string Listen(Project project);

        public abstract string Communicate();
    }
}
