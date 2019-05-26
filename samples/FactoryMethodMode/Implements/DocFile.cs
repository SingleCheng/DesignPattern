using System;
using FactoryMethodMode.Interfaces;

namespace FactoryMethodMode.Implements
{
    public class DocFile : IFile
    {
        public void New()
        {
            Console.WriteLine("New Doc Create");
        }

        public void Save()
        {
            Console.WriteLine("Save Doc");
        }
    }
}