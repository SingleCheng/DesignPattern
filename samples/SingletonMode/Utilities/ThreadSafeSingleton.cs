using System;

namespace SingletonMode.Utilities
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance = new ThreadSafeSingleton();

        private ThreadSafeSingleton()
        {
            Console.WriteLine("Thread Safe Singleton");
        }

        public static ThreadSafeSingleton Instance()
        {
            return _instance;
        }
    }
}