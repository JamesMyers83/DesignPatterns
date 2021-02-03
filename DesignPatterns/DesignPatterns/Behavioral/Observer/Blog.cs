using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Blog : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public Blog(string blogSiteName)
        {
            SiteName = blogSiteName;
            BlogMessage = "";
        }

        public string SiteName { get; }
        public string BlogMessage { get; private set; }
        public bool IsMajorUpdate { get; set; }

        //add message to top of blog
        public void AddBlogMessage(string message, bool isMajor)
        {
            IsMajorUpdate = isMajor;

            string update = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            update += " :: ";
            update += message;
            update += "\r\n";
            BlogMessage = update + BlogMessage;

            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                if (observer.IsPassive)
                    observer.Update(BlogMessage);
                else
                    observer.Update(this);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
