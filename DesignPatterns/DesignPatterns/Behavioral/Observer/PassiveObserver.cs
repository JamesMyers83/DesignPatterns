namespace DesignPatterns.Behavioral.Observer
{
    public class PassiveObserver : IObserver
    {
        public PassiveObserver(string name)
        {
            IsPassive = true;
            Name = name;
        }

        public bool IsPassive { get; }

        public string Name { get; set; }

        public string SubscribedBlog { get; private set; }

        public void Update(ISubject subject)
        {
            //ignore in passive
        }

        public void Update(string message)
        {
            SubscribedBlog = message;
        }
    }
}
