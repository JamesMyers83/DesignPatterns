namespace DesignPatterns.Behavioral.Mediator
{
    //abstract mediator
    public interface IMediator
    {
        public string PassMessage(string message, Employee employee, Project project);

    }
}
