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
}
