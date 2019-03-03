using System.Collections.Generic;
using Generator.Common.Functions;

namespace Generator.Bind.Overloading
{
    public class CharPointerStringArrayOverloader : IFunctionOverloader
    {
        // TODO: Account for ADL not being able to marshall char pointer pointers to string arrays
        
        public bool IsApplicable(Function function)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            throw new System.NotImplementedException();
        }
    }
}
