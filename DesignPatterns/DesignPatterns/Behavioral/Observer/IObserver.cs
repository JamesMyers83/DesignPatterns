namespace DesignPatterns.Behavioral.Observer
{
    //abstract observer
    public interface IObserver
    {
        //not really apart of the pattern. Could use mediator pattern for change manager class
        bool IsPassive { get; }

        //"pull" option for active
        void Update(ISubject subject);

        //"push" option for passive
        void Update(string message);
    }
}
