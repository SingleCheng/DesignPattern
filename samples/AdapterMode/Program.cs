using System;

namespace AdapterMode
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Adapter Mode Demo");
            
            var myStack = new MyStack<string>(); 
            
            myStack.Push("First String");
            myStack.Push("Second String");
            myStack.Push("Third String");

            myStack.Pop();
            
            myStack.PrintAll();
        }
    }
}
