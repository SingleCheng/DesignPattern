using System;
using FactoryMethodMode.Implements;

namespace FactoryMethodMode
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Mode Demo");

            var docFile = new DocFileFactory().Create();
            docFile.New();
            docFile.Save();
            
            var txtFile = new TxtFileFactory().Create();
            txtFile.New();
            txtFile.Save();
        }
    }
}