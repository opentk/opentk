namespace GeneratorV2.Data
{
    public class Method
    {
        public PType ReturnType { get; }
        public string EntryPoint { get; }
        public string Suffix { get; set; }
        public Parameter[] Parameters { get; }

        public Method(PType returnType, string entryPoint, params Parameter[] parameters)
        {
            ReturnType = returnType;
            EntryPoint = entryPoint;
            Parameters = parameters;
        }
    }

    public class Method2
    {
        public readonly PType2 ReturnType;
        public readonly string EntryPoint;
        public Parameter2[] Parameters;

        public Method2(PType2 returnType, string entryPoint, params Parameter2[] parameters)
        {
            ReturnType = returnType;
            EntryPoint = entryPoint;
            Parameters = parameters;
        }
    }
}
