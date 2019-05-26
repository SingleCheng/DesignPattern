using System;

namespace SingletonMode
{
    public class Singleton
    {
        private static Singleton instance;
        
        private static readonly object _padlock = new object();

        private Singleton()
        {
            Console.WriteLine("Singleton double check");
        }
        
        public static Singleton Instance()
        {
            if (instance == null)
            {
                lock (_padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }
}