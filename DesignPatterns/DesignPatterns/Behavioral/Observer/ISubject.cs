namespace DesignPatterns.Behavioral.Observer
{
    //abstract subject
    public interface ISubject
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void NotifyObservers();
    }
}
