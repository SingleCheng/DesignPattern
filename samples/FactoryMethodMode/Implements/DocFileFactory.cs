using FactoryMethodMode.Interfaces;

namespace FactoryMethodMode.Implements
{
    public class DocFileFactory : IFileFactory
    {
        public IFile Create()
        {
            return new DocFile();
        }
    }
}