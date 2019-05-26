using System;

namespace SingletonMode
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Singleton Mode Demo");

            SimpleSingleton.Instance();

            Singleton.Instance();

            ThreadSafeSingleton.Instance();
        }
    }
}
