namespace DesignPatterns.Behavioral.Command
{
    //abstract receiver
    public interface ICook
    {
        string PrepareBurger();
        string PrepareDessert();
        string PrepareSalad();
    }
}