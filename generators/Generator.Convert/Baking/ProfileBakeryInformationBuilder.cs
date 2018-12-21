using System.Linq;

namespace Generator.Convert.Baking
{
    public class ProfileBakeryInformationBuilder
    {
        public ProfileBakeryInformation Result { get; private set; }

        public ProfileBakeryInformationBuilder()
        {
            Result = new ProfileBakeryInformation();
        }

        public ProfileBakeryInformationBuilder Extends(params string[] extends)
        {
            Result.Extends.AddRange(extends);
            return this;
        }
        
        public ProfileBakeryInformationBuilder Implements(params string[] implements)
        {
            Result.Implements.AddRange(implements);
            return this;
        }
        
        public ProfileBakeryInformationBuilder WithNamespaces(string ns, string extensionNs)
        {
            Result.Namespace = ns;
            Result.ExtensionsNamespace = extensionNs;
            return this;
        }
        
        public ProfileBakeryInformationBuilder WithName(string name)
        {
            Result.Name = name;
            return this;
        }
        
        public ProfileBakeryInformationBuilder WithOutputFolder(string folder)
        {
            Result.OutputFolder = folder;
            return this;
        }
    }
}
