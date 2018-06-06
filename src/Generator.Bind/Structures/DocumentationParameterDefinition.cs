namespace Bind.Structures
{
    internal class DocumentationParameterDefinition
    {
        public string Name { get; set; }

        public string Documentation { get; set; }

        public DocumentationParameterDefinition(string name, string doc)
        {
            Name = name;
            Documentation = doc;
        }
    }
}
