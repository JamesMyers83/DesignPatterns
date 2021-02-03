namespace DesignPatterns.Behavioral.Mediator
{
    public class BusinessUser : Employee
    {
        private Project currentProject;

        public BusinessUser(string name, string title, IMediator mediator) : base(name, title, mediator)
        {
        }

        public override string Listen(Project project)
        {
            if (currentProject != null)
                return $"{Title} {Name} is stake holder {currentProject.Name}";
            else
            {
                currentProject = project;
                return $"{Title} {Name} has a new project named {currentProject.Name} that is described as {currentProject.Description}";
            }
        }

        public override string Communicate()
        {
            return Mediator.PassMessage($"{Title} {Name} would like someone to devleop {currentProject.Description} for the {currentProject.Name} project", this, currentProject);
        }
    }
}
