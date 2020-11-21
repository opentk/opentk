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

    public class Parameter2
    {
        public readonly PType2 Type;
        public readonly string Name;

        public Parameter2(PType2 type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
