namespace DesignPatterns.Behavioral.Command
{
    //base command for common constructor
    public abstract class BaseCommand
    {
        protected ICook _cook;

        protected BaseCommand(ICook cook) =>_cook = cook;
    }
}
