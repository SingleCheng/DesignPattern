using System;

namespace SingletonMode
{
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;

        private static readonly object _padlock = new object();

        private SimpleSingleton()
        {
            Console.WriteLine("Simple Singleton");
        }

        public static SimpleSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new SimpleSingleton();
            }

            return _instance;
        }
    }
}