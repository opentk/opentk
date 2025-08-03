using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLGenerator
{
    internal static class Options
    {
        /// <summary>
        /// This option switches between generating bindings using "typesafe" gl handles in the generated functions vs not generating them.
        /// </summary>
        public static readonly bool UseTypesafeGLHandles = false;
    }
}
