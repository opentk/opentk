namespace OpenToolkit.Generator
{
    public struct Class
    {
        public string Namespace { get; }
        public string Name { get; }
        public Method[] Methods { get; }

        public Class(string ns, string name, Method[] methods)
        {
            Namespace = ns;
            Name = name;
            Methods = methods;
        }
    }
}
