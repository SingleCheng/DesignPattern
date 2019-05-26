using System;

namespace SingletonMode.Utilities
{
    public class Singleton
    {
        private static Singleton _instance;
        
        private static readonly object Padlock = new object();

        private Singleton()
        {
            Console.WriteLine("Singleton double check");
        }
        
        public static Singleton Instance()
        {
            if (_instance == null)
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }
}