using System;
using FactoryMethodMode.Interfaces;

namespace FactoryMethodMode.Implements
{
    public class TxtFile : IFile
    {
        public void New()
        {
            Console.WriteLine("New Txt Create");
        }

        public void Save()
        {
            Console.WriteLine("Save Txt");
        }
    }
}