namespace DesignPatterns.Behavioral.Observer
{
    public class ActiveObserver : IObserver
    {
        public ActiveObserver(string name)
        {
            IsPassive = false;
            Name = name;
        }

        public bool IsPassive { get; }

        public string Name { get; set; }
        public string SubscribedBlog { get; private set; }

        //only updates if major update
        //this method needs to know the concrete subject
        public void Update(ISubject subject)
        {
            Blog blog = (Blog)subject;
            if (blog.IsMajorUpdate)
                SubscribedBlog = blog.BlogMessage;
        }

        public void Update(string message)
        {
            //ignore in passive
        }
    }
}
