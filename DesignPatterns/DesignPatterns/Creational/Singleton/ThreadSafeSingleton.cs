using System;

namespace DesignPatterns.Creational.Singleton
{
    //sealed so it can not be inherited
    public sealed class ThreadSafeSingleton
    {
        //static counter to show instantiations
        private static int instanceCount = 0;

        //singletons have private constructors
        private ThreadSafeSingleton()
        {
            instanceCount++;
        }

        //eager loading
        private static readonly ThreadSafeSingleton eagerInstance = new ThreadSafeSingleton();
        public static ThreadSafeSingleton Instance => eagerInstance;

        //lazy loading
        //private static readonly Lazy<ThreadSafeSingleton> lazyInstance = new Lazy<ThreadSafeSingleton>(() => new ThreadSafeSingleton());
        //public static ThreadSafeSingleton Instance => lazyInstance.Value;

        //generic method
        public string GetInstanceCountMessage(string sender)
        {
            return $"{sender} invoked ThreadSafeSingleton. Current count is {instanceCount}";
        }
    }
}
