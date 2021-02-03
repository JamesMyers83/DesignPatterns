namespace DesignPatterns.Behavioral.Mediator
{
    public class Developer : Employee
    {
        private Project currentProject; 

        public Developer(string name, string title, IMediator mediator) : base(name, title, mediator)
        {
        }

        public override string Listen(Project project)
        {
            currentProject = project;
            return $"{Title} {Name} has read the development request for {currentProject.Name}";
        }

        public override string Communicate()
        {
            return Mediator.PassMessage($"{Title} {Name} has agreed to devleop {currentProject.Description} for {currentProject.Name}", this, currentProject);
        }
    }
}
