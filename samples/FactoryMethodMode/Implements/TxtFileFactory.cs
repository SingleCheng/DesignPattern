using FactoryMethodMode.Interfaces;

namespace FactoryMethodMode.Implements
{
    public class TxtFileFactory : IFileFactory
    {
        public IFile Create()
        {
            return new TxtFile();
        }
    }
}