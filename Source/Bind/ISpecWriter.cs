#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System.Collections.Generic;
using Bind.Structures;

namespace Bind
{
    interface ISpecWriter
    {
    	void WriteBindings(DelegateCollection delegates, FunctionCollection functions,
    	               EnumCollection enums);
        void WriteDelegates(BindStreamWriter sw, DelegateCollection delegates);
        void WriteWrappers(BindStreamWriter sw, FunctionCollection wrappers, Dictionary<string, string> CSTypes);
        void WriteEnums(BindStreamWriter sw, EnumCollection enums);
        void WriteTypes(BindStreamWriter sw, Dictionary<string, string> CSTypes);
        void WriteLicense(BindStreamWriter sw);
    }
}
