using System;

namespace SingletonMode.Utilities
{
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;

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