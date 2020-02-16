using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenToolkit.Core.Emitter
{
    public class MethodGenerationContext
    {
        public readonly CallingConvention CallingConvention;
        public readonly MethodInfo MethodInfo;
        public readonly MethodBuilder MethodBuilder;
        public readonly ILGenerator ILGenerator;
        public readonly int Slot;
        public readonly string ProcName;

        public MethodGenerationContext(CallingConvention callingConvention, MethodInfo methodInfo, MethodBuilder methodBuilder, int slot, string procName)
        {
            CallingConvention = callingConvention;
            MethodInfo = methodInfo;
            MethodBuilder = methodBuilder;
            ILGenerator = methodBuilder.GetILGenerator();
            Slot = slot;
            ProcName = procName;
        }
    }
}
