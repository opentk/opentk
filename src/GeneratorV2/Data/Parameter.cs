namespace GeneratorV2.Data
{
    public class Parameter
    {
        public PType Type { get; }
        public string Name { get; }

        public Parameter (PType type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
