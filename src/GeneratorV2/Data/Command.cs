using System.Collections.Generic;
using System.Linq;

namespace GeneratorV2.Data
{
    public class Command2
    {
        public readonly string EntryPoint;
        public readonly PType ReturnType;
        public GLParameter[] Parameters;

        public Command2(string entryPoint, PType returnType, GLParameter[] parameters)
        {
            EntryPoint = entryPoint;
            ReturnType = returnType;
            Parameters = parameters;
        }
    }
}
