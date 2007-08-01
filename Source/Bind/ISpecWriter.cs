using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;

namespace Bind
{
    interface ISpecWriter
    {
        void WriteDelegates(BindStreamWriter sw, DelegateCollection delegates);
        void WriteWrappers(BindStreamWriter sw, FunctionCollection wrappers, Dictionary<string, string> CSTypes);
        void WriteEnums(BindStreamWriter sw, EnumCollection enums);
        void WriteTypes(BindStreamWriter sw, Dictionary<string, string> CSTypes);
    }
}
